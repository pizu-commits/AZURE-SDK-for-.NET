// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Purview.Account
{
    /// <summary> The PurviewResourceSetRule service client. </summary>
    public partial class PurviewResourceSetRule
    {
        private static readonly string[] AuthorizationScopes = { "https://purview.azure.net/.default" };
        private readonly TokenCredential _tokenCredential;

        private readonly HttpPipeline _pipeline;
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline { get => _pipeline; }

        /// <summary> Initializes a new instance of PurviewResourceSetRule for mocking. </summary>
        protected PurviewResourceSetRule()
        {
        }

        /// <summary> Get a resource set config service model. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format),
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;
        ///   },
        ///   name: string,
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string,
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         path: string
        ///       }
        ///     ],
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         typeName: string
        ///       }
        ///     ],
        ///     createdBy: string,
        ///     enableDefaultPatterns: boolean,
        ///     lastUpdatedTimestamp: number,
        ///     modifiedBy: string,
        ///     normalizationRules: [
        ///       {
        ///         description: string,
        ///         disabled: boolean,
        ///         dynamicReplacement: boolean,
        ///         entityTypes: [string],
        ///         lastUpdatedTimestamp: number,
        ///         name: string,
        ///         regex: {
        ///           maxDigits: number,
        ///           maxLetters: number,
        ///           minDashes: number,
        ///           minDigits: number,
        ///           minDigitsOrLetters: number,
        ///           minDots: number,
        ///           minHex: number,
        ///           minLetters: number,
        ///           minUnderscores: number,
        ///           options: number,
        ///           regexStr: string
        ///         },
        ///         replaceWith: string,
        ///         version: number
        ///       }
        ///     ],
        ///     regexReplacers: [
        ///       {
        ///         condition: string,
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         doNotReplaceRegex: FastRegex,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         regex: FastRegex,
        ///         replaceWith: string
        ///       }
        ///     ],
        ///     rejectedPatterns: [Filter],
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string,
        ///         rules: [
        ///           {
        ///             displayName: string,
        ///             isResourceSet: boolean,
        ///             lastUpdatedTimestamp: number,
        ///             name: string,
        ///             qualifiedName: string
        ///           }
        ///         ],
        ///         storeType: string
        ///       }
        ///     ],
        ///     version: number
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> GetResourceSetRuleAsync(RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("PurviewResourceSetRule.GetResourceSetRule");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetResourceSetRuleRequest();
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a resource set config service model. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format),
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;
        ///   },
        ///   name: string,
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string,
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         path: string
        ///       }
        ///     ],
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         typeName: string
        ///       }
        ///     ],
        ///     createdBy: string,
        ///     enableDefaultPatterns: boolean,
        ///     lastUpdatedTimestamp: number,
        ///     modifiedBy: string,
        ///     normalizationRules: [
        ///       {
        ///         description: string,
        ///         disabled: boolean,
        ///         dynamicReplacement: boolean,
        ///         entityTypes: [string],
        ///         lastUpdatedTimestamp: number,
        ///         name: string,
        ///         regex: {
        ///           maxDigits: number,
        ///           maxLetters: number,
        ///           minDashes: number,
        ///           minDigits: number,
        ///           minDigitsOrLetters: number,
        ///           minDots: number,
        ///           minHex: number,
        ///           minLetters: number,
        ///           minUnderscores: number,
        ///           options: number,
        ///           regexStr: string
        ///         },
        ///         replaceWith: string,
        ///         version: number
        ///       }
        ///     ],
        ///     regexReplacers: [
        ///       {
        ///         condition: string,
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         doNotReplaceRegex: FastRegex,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         regex: FastRegex,
        ///         replaceWith: string
        ///       }
        ///     ],
        ///     rejectedPatterns: [Filter],
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string,
        ///         rules: [
        ///           {
        ///             displayName: string,
        ///             isResourceSet: boolean,
        ///             lastUpdatedTimestamp: number,
        ///             name: string,
        ///             qualifiedName: string
        ///           }
        ///         ],
        ///         storeType: string
        ///       }
        ///     ],
        ///     version: number
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response GetResourceSetRule(RequestOptions options)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("PurviewResourceSetRule.GetResourceSetRule");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetResourceSetRuleRequest();
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an resource set config. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format),
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;
        ///   },
        ///   name: string,
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string,
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string (required),
        ///         path: string (required)
        ///       }
        ///     ],
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         typeName: string
        ///       }
        ///     ],
        ///     createdBy: string (required),
        ///     enableDefaultPatterns: boolean (required),
        ///     lastUpdatedTimestamp: number,
        ///     modifiedBy: string,
        ///     normalizationRules: [
        ///       {
        ///         description: string,
        ///         disabled: boolean,
        ///         dynamicReplacement: boolean,
        ///         entityTypes: [string],
        ///         lastUpdatedTimestamp: number,
        ///         name: string,
        ///         regex: {
        ///           maxDigits: number,
        ///           maxLetters: number,
        ///           minDashes: number,
        ///           minDigits: number,
        ///           minDigitsOrLetters: number,
        ///           minDots: number,
        ///           minHex: number,
        ///           minLetters: number,
        ///           minUnderscores: number,
        ///           options: number,
        ///           regexStr: string
        ///         },
        ///         replaceWith: string,
        ///         version: number
        ///       }
        ///     ],
        ///     regexReplacers: [
        ///       {
        ///         condition: string,
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean (required),
        ///         disableRecursiveReplacerApplication: boolean,
        ///         doNotReplaceRegex: FastRegex,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string (required),
        ///         regex: FastRegex,
        ///         replaceWith: string
        ///       }
        ///     ],
        ///     rejectedPatterns: [Filter],
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string (required),
        ///         rules: [
        ///           {
        ///             displayName: string,
        ///             isResourceSet: boolean,
        ///             lastUpdatedTimestamp: number,
        ///             name: string,
        ///             qualifiedName: string (required)
        ///           }
        ///         ],
        ///         storeType: string (required)
        ///       }
        ///     ],
        ///     version: number
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format),
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;
        ///   },
        ///   name: string,
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string,
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         path: string
        ///       }
        ///     ],
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         typeName: string
        ///       }
        ///     ],
        ///     createdBy: string,
        ///     enableDefaultPatterns: boolean,
        ///     lastUpdatedTimestamp: number,
        ///     modifiedBy: string,
        ///     normalizationRules: [
        ///       {
        ///         description: string,
        ///         disabled: boolean,
        ///         dynamicReplacement: boolean,
        ///         entityTypes: [string],
        ///         lastUpdatedTimestamp: number,
        ///         name: string,
        ///         regex: {
        ///           maxDigits: number,
        ///           maxLetters: number,
        ///           minDashes: number,
        ///           minDigits: number,
        ///           minDigitsOrLetters: number,
        ///           minDots: number,
        ///           minHex: number,
        ///           minLetters: number,
        ///           minUnderscores: number,
        ///           options: number,
        ///           regexStr: string
        ///         },
        ///         replaceWith: string,
        ///         version: number
        ///       }
        ///     ],
        ///     regexReplacers: [
        ///       {
        ///         condition: string,
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         doNotReplaceRegex: FastRegex,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         regex: FastRegex,
        ///         replaceWith: string
        ///       }
        ///     ],
        ///     rejectedPatterns: [Filter],
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string,
        ///         rules: [
        ///           {
        ///             displayName: string,
        ///             isResourceSet: boolean,
        ///             lastUpdatedTimestamp: number,
        ///             name: string,
        ///             qualifiedName: string
        ///           }
        ///         ],
        ///         storeType: string
        ///       }
        ///     ],
        ///     version: number
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> CreateOrUpdateResourceSetRuleAsync(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("PurviewResourceSetRule.CreateOrUpdateResourceSetRule");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateResourceSetRuleRequest(content);
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates an resource set config. </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <remarks>
        /// Schema for <c>Request Body</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format),
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;
        ///   },
        ///   name: string,
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string,
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string (required),
        ///         path: string (required)
        ///       }
        ///     ],
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         typeName: string
        ///       }
        ///     ],
        ///     createdBy: string (required),
        ///     enableDefaultPatterns: boolean (required),
        ///     lastUpdatedTimestamp: number,
        ///     modifiedBy: string,
        ///     normalizationRules: [
        ///       {
        ///         description: string,
        ///         disabled: boolean,
        ///         dynamicReplacement: boolean,
        ///         entityTypes: [string],
        ///         lastUpdatedTimestamp: number,
        ///         name: string,
        ///         regex: {
        ///           maxDigits: number,
        ///           maxLetters: number,
        ///           minDashes: number,
        ///           minDigits: number,
        ///           minDigitsOrLetters: number,
        ///           minDots: number,
        ///           minHex: number,
        ///           minLetters: number,
        ///           minUnderscores: number,
        ///           options: number,
        ///           regexStr: string
        ///         },
        ///         replaceWith: string,
        ///         version: number
        ///       }
        ///     ],
        ///     regexReplacers: [
        ///       {
        ///         condition: string,
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean (required),
        ///         disableRecursiveReplacerApplication: boolean,
        ///         doNotReplaceRegex: FastRegex,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string (required),
        ///         regex: FastRegex,
        ///         replaceWith: string
        ///       }
        ///     ],
        ///     rejectedPatterns: [Filter],
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string (required),
        ///         rules: [
        ///           {
        ///             displayName: string,
        ///             isResourceSet: boolean,
        ///             lastUpdatedTimestamp: number,
        ///             name: string,
        ///             qualifiedName: string (required)
        ///           }
        ///         ],
        ///         storeType: string (required)
        ///       }
        ///     ],
        ///     version: number
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Body</c>:
        /// <code>{
        ///   advancedResourceSet: {
        ///     modifiedAt: string (ISO 8601 Format),
        ///     resourceSetProcessing: &quot;Default&quot; | &quot;Advanced&quot;
        ///   },
        ///   name: string,
        ///   pathPatternConfig: {
        ///     acceptedPatterns: [
        ///       {
        ///         createdBy: string,
        ///         filterType: &quot;Pattern&quot; | &quot;Regex&quot;,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         path: string
        ///       }
        ///     ],
        ///     complexReplacers: [
        ///       {
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         typeName: string
        ///       }
        ///     ],
        ///     createdBy: string,
        ///     enableDefaultPatterns: boolean,
        ///     lastUpdatedTimestamp: number,
        ///     modifiedBy: string,
        ///     normalizationRules: [
        ///       {
        ///         description: string,
        ///         disabled: boolean,
        ///         dynamicReplacement: boolean,
        ///         entityTypes: [string],
        ///         lastUpdatedTimestamp: number,
        ///         name: string,
        ///         regex: {
        ///           maxDigits: number,
        ///           maxLetters: number,
        ///           minDashes: number,
        ///           minDigits: number,
        ///           minDigitsOrLetters: number,
        ///           minDots: number,
        ///           minHex: number,
        ///           minLetters: number,
        ///           minUnderscores: number,
        ///           options: number,
        ///           regexStr: string
        ///         },
        ///         replaceWith: string,
        ///         version: number
        ///       }
        ///     ],
        ///     regexReplacers: [
        ///       {
        ///         condition: string,
        ///         createdBy: string,
        ///         description: string,
        ///         disabled: boolean,
        ///         disableRecursiveReplacerApplication: boolean,
        ///         doNotReplaceRegex: FastRegex,
        ///         lastUpdatedTimestamp: number,
        ///         modifiedBy: string,
        ///         name: string,
        ///         regex: FastRegex,
        ///         replaceWith: string
        ///       }
        ///     ],
        ///     rejectedPatterns: [Filter],
        ///     scopedRules: [
        ///       {
        ///         bindingUrl: string,
        ///         rules: [
        ///           {
        ///             displayName: string,
        ///             isResourceSet: boolean,
        ///             lastUpdatedTimestamp: number,
        ///             name: string,
        ///             qualifiedName: string
        ///           }
        ///         ],
        ///         storeType: string
        ///       }
        ///     ],
        ///     version: number
        ///   }
        /// }
        /// </code>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response CreateOrUpdateResourceSetRule(RequestContent content, RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("PurviewResourceSetRule.CreateOrUpdateResourceSetRule");
            scope.Start();
            try
            {
                using HttpMessage message = CreateCreateOrUpdateResourceSetRuleRequest(content);
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a ResourceSetRuleConfig resource. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual async Task<Response> DeleteResourceSetRuleAsync(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("PurviewResourceSetRule.DeleteResourceSetRule");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteResourceSetRuleRequest();
                return await _pipeline.ProcessMessageAsync(message, _clientDiagnostics, options).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a ResourceSetRuleConfig resource. </summary>
        /// <param name="options"> The request options. </param>
        /// <remarks>
        /// Schema for <c>Response Error</c>:
        /// <code>{
        ///   error: {
        ///     code: string,
        ///     details: [
        ///       {
        ///         code: string,
        ///         details: [ErrorModel],
        ///         message: string,
        ///         target: string
        ///       }
        ///     ],
        ///     message: string,
        ///     target: string
        ///   }
        /// }
        /// </code>
        /// 
        /// </remarks>
#pragma warning disable AZC0002
        public virtual Response DeleteResourceSetRule(RequestOptions options = null)
#pragma warning restore AZC0002
        {
            using var scope = _clientDiagnostics.CreateScope("PurviewResourceSetRule.DeleteResourceSetRule");
            scope.Start();
            try
            {
                using HttpMessage message = CreateDeleteResourceSetRuleRequest();
                return _pipeline.ProcessMessage(message, _clientDiagnostics, options);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetResourceSetRuleRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/resourceSetRuleConfigs/defaultResourceSetRuleConfig", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateCreateOrUpdateResourceSetRuleRequest(RequestContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/resourceSetRuleConfigs/defaultResourceSetRuleConfig", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            message.ResponseClassifier = ResponseClassifier200.Instance;
            return message;
        }

        internal HttpMessage CreateDeleteResourceSetRuleRequest()
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/resourceSetRuleConfigs/defaultResourceSetRuleConfig", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            message.ResponseClassifier = ResponseClassifier200204.Instance;
            return message;
        }

        private sealed class ResponseClassifier200 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    _ => true
                };
            }
        }
        private sealed class ResponseClassifier200204 : ResponseClassifier
        {
            private static ResponseClassifier _instance;
            public static ResponseClassifier Instance => _instance ??= new ResponseClassifier200204();
            public override bool IsErrorResponse(HttpMessage message)
            {
                return message.Response.Status switch
                {
                    200 => false,
                    204 => false,
                    _ => true
                };
            }
        }
    }
}
