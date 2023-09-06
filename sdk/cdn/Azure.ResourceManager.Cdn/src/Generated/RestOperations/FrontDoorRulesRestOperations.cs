// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Cdn.Models;

namespace Azure.ResourceManager.Cdn
{
    internal partial class FrontDoorRulesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of FrontDoorRulesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public FrontDoorRulesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2021-06-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListByRuleSetRequest(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/ruleSets/", false);
            uri.AppendPath(ruleSetName, true);
            uri.AppendPath("/rules", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all of the existing delivery rules within a rule set. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="ruleSetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RuleListResult>> ListByRuleSetAsync(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var message = CreateListByRuleSetRequest(subscriptionId, resourceGroupName, profileName, ruleSetName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RuleListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RuleListResult.DeserializeRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all of the existing delivery rules within a rule set. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="ruleSetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RuleListResult> ListByRuleSet(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var message = CreateListByRuleSetRequest(subscriptionId, resourceGroupName, profileName, ruleSetName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RuleListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RuleListResult.DeserializeRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, string ruleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/ruleSets/", false);
            uri.AppendPath(ruleSetName, true);
            uri.AppendPath("/rules/", false);
            uri.AppendPath(ruleName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets an existing delivery rule within a rule set. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/> or <paramref name="ruleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/> or <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<FrontDoorRuleData>> GetAsync(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, profileName, ruleSetName, ruleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FrontDoorRuleData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FrontDoorRuleData.DeserializeFrontDoorRuleData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((FrontDoorRuleData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets an existing delivery rule within a rule set. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/> or <paramref name="ruleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/> or <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<FrontDoorRuleData> Get(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, profileName, ruleSetName, ruleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FrontDoorRuleData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FrontDoorRuleData.DeserializeFrontDoorRuleData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((FrontDoorRuleData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateRequest(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, string ruleName, FrontDoorRuleData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/ruleSets/", false);
            uri.AppendPath(ruleSetName, true);
            uri.AppendPath("/rules/", false);
            uri.AppendPath(ruleName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = data;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates a new delivery rule within the specified rule set. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="data"> The delivery rule properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/>, <paramref name="ruleName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/> or <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateAsync(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, string ruleName, FrontDoorRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, profileName, ruleSetName, ruleName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates a new delivery rule within the specified rule set. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="data"> The delivery rule properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/>, <paramref name="ruleName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/> or <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Create(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, string ruleName, FrontDoorRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateRequest(subscriptionId, resourceGroupName, profileName, ruleSetName, ruleName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateUpdateRequest(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, string ruleName, FrontDoorRulePatch patch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/ruleSets/", false);
            uri.AppendPath(ruleSetName, true);
            uri.AppendPath("/rules/", false);
            uri.AppendPath(ruleName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = patch;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Updates an existing delivery rule within a rule set. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="patch"> Delivery rule properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/>, <paramref name="ruleName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/> or <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> UpdateAsync(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, string ruleName, FrontDoorRulePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, profileName, ruleSetName, ruleName, patch);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Updates an existing delivery rule within a rule set. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="patch"> Delivery rule properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/>, <paramref name="ruleName"/> or <paramref name="patch"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/> or <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Update(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, string ruleName, FrontDoorRulePatch patch, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));
            Argument.AssertNotNull(patch, nameof(patch));

            using var message = CreateUpdateRequest(subscriptionId, resourceGroupName, profileName, ruleSetName, ruleName, patch);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, string ruleName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Cdn/profiles/", false);
            uri.AppendPath(profileName, true);
            uri.AppendPath("/ruleSets/", false);
            uri.AppendPath(ruleSetName, true);
            uri.AppendPath("/rules/", false);
            uri.AppendPath(ruleName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes an existing delivery rule within a rule set. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/> or <paramref name="ruleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/> or <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, profileName, ruleSetName, ruleName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes an existing delivery rule within a rule set. </summary>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="ruleName"> Name of the delivery rule which is unique within the endpoint. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/> or <paramref name="ruleName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/>, <paramref name="ruleSetName"/> or <paramref name="ruleName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, string ruleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));
            Argument.AssertNotNullOrEmpty(ruleName, nameof(ruleName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, profileName, ruleSetName, ruleName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListByRuleSetNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string profileName, string ruleSetName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Lists all of the existing delivery rules within a rule set. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="ruleSetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<RuleListResult>> ListByRuleSetNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var message = CreateListByRuleSetNextPageRequest(nextLink, subscriptionId, resourceGroupName, profileName, ruleSetName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RuleListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = RuleListResult.DeserializeRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Lists all of the existing delivery rules within a rule set. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> Azure Subscription ID. </param>
        /// <param name="resourceGroupName"> Name of the Resource group within the Azure subscription. </param>
        /// <param name="profileName"> Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group. </param>
        /// <param name="ruleSetName"> Name of the rule set under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="ruleSetName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="profileName"/> or <paramref name="ruleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<RuleListResult> ListByRuleSetNextPage(string nextLink, string subscriptionId, string resourceGroupName, string profileName, string ruleSetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(profileName, nameof(profileName));
            Argument.AssertNotNullOrEmpty(ruleSetName, nameof(ruleSetName));

            using var message = CreateListByRuleSetNextPageRequest(nextLink, subscriptionId, resourceGroupName, profileName, ruleSetName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        RuleListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = RuleListResult.DeserializeRuleListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
