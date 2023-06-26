// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.ChecksService.v1alpha
{
    /// <summary>The ChecksService Service.</summary>
    public class ChecksServiceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1alpha";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public ChecksServiceService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public ChecksServiceService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Accounts = new AccountsResource(this);
            Privacypolicy = new PrivacypolicyResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "checks";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://checks.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://checks.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Checks API.</summary>
        public class Scope
        {
            /// <summary>Test scope for access to the Zoo service</summary>
            public static string XapiZoo = "https://www.googleapis.com/auth/xapi.zoo";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Checks API.</summary>
        public static class ScopeConstants
        {
            /// <summary>Test scope for access to the Zoo service</summary>
            public const string XapiZoo = "https://www.googleapis.com/auth/xapi.zoo";
        }

        /// <summary>Gets the Accounts resource.</summary>
        public virtual AccountsResource Accounts { get; }

        /// <summary>Gets the Privacypolicy resource.</summary>
        public virtual PrivacypolicyResource Privacypolicy { get; }
    }

    /// <summary>A base abstract class for ChecksService requests.</summary>
    public abstract class ChecksServiceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new ChecksServiceBaseServiceRequest instance.</summary>
        protected ChecksServiceBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1 = 0,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2 = 1,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 0,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media = 1,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto = 2,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>
        /// API key. Your API key identifies your project and provides you with API access, quota, and reports. Required
        /// unless you provide an OAuth 2.0 token.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>
        /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a
        /// user, but should not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes ChecksService parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "accounts" collection of methods.</summary>
    public class AccountsResource
    {
        private const string Resource = "accounts";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccountsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Apps = new AppsResource(service);
        }

        /// <summary>Gets the Apps resource.</summary>
        public virtual AppsResource Apps { get; }

        /// <summary>The "apps" collection of methods.</summary>
        public class AppsResource
        {
            private const string Resource = "apps";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AppsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Operations = new OperationsResource(service);
            }

            /// <summary>Gets the Operations resource.</summary>
            public virtual OperationsResource Operations { get; }

            /// <summary>The "operations" collection of methods.</summary>
            public class OperationsResource
            {
                private const string Resource = "operations";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public OperationsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>
                /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
                /// result at intervals as recommended by the API service.
                /// </summary>
                public class GetRequest : ChecksServiceBaseServiceRequest<Google.Apis.ChecksService.v1alpha.Data.Operation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>The name of the operation resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1alpha/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^accounts/[^/]+/apps/[^/]+/operations/[^/]+$",
                        });
                    }
                }
            }
        }
    }

    /// <summary>The "privacypolicy" collection of methods.</summary>
    public class PrivacypolicyResource
    {
        private const string Resource = "privacypolicy";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PrivacypolicyResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>Analyzes the privacy policy of the given policy URL or content.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual AnalyzeRequest Analyze(Google.Apis.ChecksService.v1alpha.Data.AnalyzePrivacyPolicyRequest body)
        {
            return new AnalyzeRequest(service, body);
        }

        /// <summary>Analyzes the privacy policy of the given policy URL or content.</summary>
        public class AnalyzeRequest : ChecksServiceBaseServiceRequest<Google.Apis.ChecksService.v1alpha.Data.AnalyzePrivacyPolicyResponse>
        {
            /// <summary>Constructs a new Analyze request.</summary>
            public AnalyzeRequest(Google.Apis.Services.IClientService service, Google.Apis.ChecksService.v1alpha.Data.AnalyzePrivacyPolicyRequest body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.ChecksService.v1alpha.Data.AnalyzePrivacyPolicyRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "analyze";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1alpha/privacypolicy:analyze";

            /// <summary>Initializes Analyze parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }
    }
}
namespace Google.Apis.ChecksService.v1alpha.Data
{
    /// <summary>The request proto for AnalyzePrivacyPolicy method.</summary>
    public class AnalyzePrivacyPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Web page raw HTML content for the privacy policy page to be analyzed. Useful when the client wants to
        /// analyze a privacy policy already fetched.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privacyPolicyPageContent")]
        public virtual string PrivacyPolicyPageContent { get; set; }

        /// <summary>
        /// URL for the privacy policy page to be analyzed. https://linter.aip.dev/140/uri (Use `uri` instead of `url`
        /// in field name)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privacyPolicyUri")]
        public virtual string PrivacyPolicyUri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response proto for AnalyzePrivacyPolicy method.</summary>
    public class AnalyzePrivacyPolicyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of all data types in the privacy policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataPurposeAnnotations")]
        public virtual System.Collections.Generic.IList<PolicyPurposeOfUseAnnotation> DataPurposeAnnotations { get; set; }

        /// <summary>List of all data types in the privacy policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataTypeAnnotations")]
        public virtual System.Collections.Generic.IList<PolicyDataTypeAnnotation> DataTypeAnnotations { get; set; }

        /// <summary>HTML content for the privacy policy page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("htmlContent")]
        public virtual string HtmlContent { get; set; }

        /// <summary>Information about the date when the privacy policy was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdatedDateInfo")]
        public virtual LastUpdatedDate LastUpdatedDateInfo { get; set; }

        /// <summary>List of all sections in the privacy policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionAnnotations")]
        public virtual System.Collections.Generic.IList<PolicySectionAnnotation> SectionAnnotations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a whole or partial calendar date, such as a birthday. The time of day and time zone are either
    /// specified elsewhere or are insignificant. The date is relative to the Gregorian Calendar. This can represent one
    /// of the following: * A full date, with non-zero year, month, and day values. * A month and day, with a zero year
    /// (for example, an anniversary). * A year on its own, with a zero month and a zero day. * A year and month, with a
    /// zero day (for example, a credit card expiration date). Related types: * google.type.TimeOfDay *
    /// google.type.DateTime * google.protobuf.Timestamp
    /// </summary>
    public class Date : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Day of a month. Must be from 1 to 31 and valid for the year and month, or 0 to specify a year by itself or a
        /// year and month where the day isn't significant.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("day")]
        public virtual System.Nullable<int> Day { get; set; }

        /// <summary>Month of a year. Must be from 1 to 12, or 0 to specify a year without a month and day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("month")]
        public virtual System.Nullable<int> Month { get; set; }

        /// <summary>Year of the date. Must be from 1 to 9999, or 0 to specify a date without a year.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("year")]
        public virtual System.Nullable<int> Year { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information about the date when the privacy policy was last updated.</summary>
    public class LastUpdatedDate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Byte offsets for the end of the date text inside the full text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOffset")]
        public virtual System.Nullable<long> EndOffset { get; set; }

        /// <summary>Date when the privacy policy was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdatedDate")]
        public virtual Date LastUpdatedDateValue { get; set; }

        /// <summary>Byte offsets for the start of the date text inside the full text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startOffset")]
        public virtual System.Nullable<long> StartOffset { get; set; }

        /// <summary>
        /// The bytes of actual text content in the section. NOTE: - This will correspond to the whole sentence that
        /// includes the date. - This field might contain HTML and it is not sanitized.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textContent")]
        public virtual string TextContent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation. It typically contains progress information and
        /// common metadata such as create time. Some services might not provide such metadata. Any method that returns
        /// a long-running operation should document the metadata type, if any.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned name, which is only unique within the same service that originally returns it. If you
        /// use the default HTTP mapping, the `name` should be a resource name ending with `operations/{unique_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal response of the operation in case of success. If the original method returns no data on success,
        /// such as `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PolicyDataTypeAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of the data mentioned in the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataType")]
        public virtual string DataType { get; set; }

        /// <summary>Byte offsets for the end of the data type sentence inside the full text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOffset")]
        public virtual System.Nullable<long> EndOffset { get; set; }

        /// <summary>
        /// Score given by the model representing how confident it was regarding this `text_content` being of
        /// `data_type`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>Byte offsets for the start of the data type sentence inside the full text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startOffset")]
        public virtual System.Nullable<long> StartOffset { get; set; }

        /// <summary>
        /// Actual text content in the section. This makes it much easier to consume the information. NOTE: This field
        /// might contain HTML and does not guarantee a SafeHtml security contract go/safehtmltypecontracts#safehtml.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textContent")]
        public virtual string TextContent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PolicyPurposeOfUseAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Byte offsets for the end of the purpose of use sentence inside the full text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOffset")]
        public virtual System.Nullable<long> EndOffset { get; set; }

        /// <summary>Purpose of use mentioned in the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("purposeOfUse")]
        public virtual string PurposeOfUse { get; set; }

        /// <summary>
        /// Score given by the model representing how confident it was regarding this `text_content` being of
        /// `purpose_of_use`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>Byte offsets for the start of the purpose of use sentence inside the full text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startOffset")]
        public virtual System.Nullable<long> StartOffset { get; set; }

        /// <summary>
        /// The bytes of actual text content in the sentence that mentions the purpose of use. This makes it much easier
        /// to consume the information. NOTE: This field might contain HTML and does not guarantee a SafeHtml security
        /// contract go/safehtmltypecontracts#safehtml.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textContent")]
        public virtual string TextContent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    public class PolicySectionAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Byte offsets for the end of the section inside the full text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endOffset")]
        public virtual System.Nullable<long> EndOffset { get; set; }

        /// <summary>
        /// Score given by the model representing how confident it was regarding this `text_content` being of
        /// `section_type`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; }

        /// <summary>Type of the high-level category in the policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sectionType")]
        public virtual string SectionType { get; set; }

        /// <summary>Byte offsets for the start of the section inside the full text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startOffset")]
        public virtual System.Nullable<long> StartOffset { get; set; }

        /// <summary>
        /// Actual text content in the section. This makes it much easier to consume the information. NOTE: This field
        /// might contain HTML and does not guarantee a SafeHtml security contract go/safehtmltypecontracts#safehtml.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textContent")]
        public virtual string TextContent { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}