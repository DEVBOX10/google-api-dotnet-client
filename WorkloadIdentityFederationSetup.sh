#!/bin/bash

set -e

# This script is used to generate the project configurations needed to
# end-to-end test workload identity pools in the Auth library, specifically
# OIDC-based credentials and AWS credentials. This script only needs to be run once.
#
# In order to run this script, the GOOGLE_APPLICATION_CREDENTIALS environment
# variable needs to be set to point to a service account key file.
# Additional fields must be provided in this file.
# Detailed instructions are documented below.
#
# GCP project changes:
# --------------------
# The following IAM roles need to be set on the service account:
# 1. IAM Workload Identity Pool Admin (needed to create resources for workload
#    identity pools).
# 2. Security Admin (needed to get and set IAM policies).
# 3. Service Account Token Creator (needed to generate Google ID tokens and
#    access tokens).
#
# The following APIs need to be enabled on the project:
# 1. Identity and Access Management (IAM) API.
# 2. IAM Service Account Credentials API.
# 3. Cloud Resource Manager API.
# 4. The API being accessed in the test, eg. DNS.
#
# AWS developer account changes:
# ------------------------------
# For testing AWS credentials, the following are needed:
# 1. An AWS developer account is needed. The account ID will need to
#    be provided in the configuration object below.
# 2. A role for web identity federation. This will also need to be provided
#    in the configuration object below.
#    - In AWS, an OIDC Google identity provider needs to be created with the following:
#      issuer: accounts.google.com
#      audience: Use the client_id of the service account.
#    - A role for OIDC web identity federation is needed with the created
#      Google provider as a trusted entity:
#      "accounts.google.com:aud": "$CLIENT_ID"
#    The role creation steps are documented at:
#    https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_create_for-idp_oidc.html
#
# This script needs to be run once. It will do the following:
# 1. Create a random workload identity pool.
# 2. Create a random OIDC provider in that pool which uses the
# 3. Enable OIDC tokens generated by the current service account to impersonate
#    the service account. (Identified by the OIDC token sub field which is the
#    service account client ID).
# 4. Create a random AWS provider in that pool which uses the provided AWS
#    account ID.
# 5. Enable AWS provider to impersonate the service account. (Principal is
#    identified by the AWS role name).
# 6. Print out the STS audience fields associated with the created providers
#    and AWS role name/arn after the setup completes successfully so that
#    they can be used in the tests.
#
# The same service account used for this setup script should be used for
# the test script.
#
# It is safe to run the setup script again. A new pool is created and new
# audiences are printed. If run multiple times, it is advisable to delete
# unused pools. Note that deleted pools are soft deleted and may remain for
# a while before they are completely deleted. The old pool ID cannot be used
# in the meantime.

suffix=""

function generate_random_string () {
  local valid_chars=abcdefghijklmnopqrstuvwxyz0123456789
  for i in {1..8} ; do
    suffix+="${valid_chars:RANDOM%${#valid_chars}:1}"
    done
}

generate_random_string

pool_id="pool-"${suffix}
oidc_provider_id="oidc-"${suffix}
aws_provider_id="aws-"${suffix}

# Fill in (Googlers, see go/wif-integration-settings).
project_id=""
project_number=""
aws_account_id=""
aws_role_name=""
service_account_email=""
sub=""; # client_id from service account key file

oidc_aud="//iam.googleapis.com/projects/${project_number}/locations/global/workloadIdentityPools/${pool_id}/providers/${oidc_provider_id}"
aws_aud="//iam.googleapis.com/projects/${project_number}/locations/global/workloadIdentityPools/${pool_id}/providers/${aws_provider_id}"

gcloud config set project ${project_id}

# Create the Workload Identity Pool.
gcloud iam workload-identity-pools create ${pool_id} \
    --location="global" \
    --description="Test pool" \
    --display-name="Test pool for .NET"

# Create the OIDC Provider.
gcloud iam workload-identity-pools providers create-oidc ${oidc_provider_id} \
    --workload-identity-pool=${pool_id} \
    --issuer-uri="https://accounts.google.com" \
    --location="global" \
    --attribute-mapping="google.subject=assertion.sub"

# Create the AWS Provider.
gcloud iam workload-identity-pools providers create-aws ${aws_provider_id} \
    --workload-identity-pool=${pool_id} \
    --account-id=${aws_account_id} \
    --location="global"

# Give permission to impersonate the service account.
gcloud iam service-accounts add-iam-policy-binding ${service_account_email} \
--role roles/iam.workloadIdentityUser \
--member "principal://iam.googleapis.com/projects/${project_number}/locations/global/workloadIdentityPools/${pool_id}/subject/${sub}"

gcloud iam service-accounts add-iam-policy-binding ${service_account_email} \
  --role roles/iam.workloadIdentityUser \
  --member "principalSet://iam.googleapis.com/projects/${project_number}/locations/global/workloadIdentityPools/${pool_id}/attribute.aws_role/arn:aws:sts::${aws_account_id}:assumed-role/${aws_role_name}"

echo "OIDC audience:"${oidc_aud}
echo "AWS audience:"${aws_aud}
echo "AWS role name:"${aws_role_name}
echo "AWS role ARN: arn:aws:iam::${aws_account_id}:role/${aws_role_name}"