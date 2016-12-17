// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.AppService.Fluent
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for WebSiteManagementClient.
    /// </summary>
    public static partial class WebSiteManagementClientExtensions
    {
            /// <summary>
            /// Gets the source controls available for Azure websites.
            /// </summary>
            /// <remarks>
            /// Gets the source controls available for Azure websites.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<SourceControlInner> ListSourceControls(this IWebSiteManagementClient operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebSiteManagementClient)s).ListSourceControlsAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the source controls available for Azure websites.
            /// </summary>
            /// <remarks>
            /// Gets the source controls available for Azure websites.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<SourceControlInner>> ListSourceControlsAsync(this IWebSiteManagementClient operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListSourceControlsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates source control token
            /// </summary>
            /// <remarks>
            /// Updates source control token
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sourceControlType'>
            /// Type of source control
            /// </param>
            /// <param name='requestMessage'>
            /// Source control token information
            /// </param>
            public static SourceControlInner UpdateSourceControl(this IWebSiteManagementClient operations, string sourceControlType, SourceControlInner requestMessage)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebSiteManagementClient)s).UpdateSourceControlAsync(sourceControlType, requestMessage), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates source control token
            /// </summary>
            /// <remarks>
            /// Updates source control token
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sourceControlType'>
            /// Type of source control
            /// </param>
            /// <param name='requestMessage'>
            /// Source control token information
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<SourceControlInner> UpdateSourceControlAsync(this IWebSiteManagementClient operations, string sourceControlType, SourceControlInner requestMessage, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.UpdateSourceControlWithHttpMessagesAsync(sourceControlType, requestMessage, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Check if a resource name is available.
            /// </summary>
            /// <remarks>
            /// Check if a resource name is available.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Resource name to verify.
            /// </param>
            /// <param name='type'>
            /// Resource type used for verification. Possible values include: 'Site',
            /// 'Slot', 'HostingEnvironment'
            /// </param>
            /// <param name='isFqdn'>
            /// Is fully qualified domain name.
            /// </param>
            public static ResourceNameAvailabilityInner CheckNameAvailability(this IWebSiteManagementClient operations, string name, string type, bool? isFqdn = default(bool?))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebSiteManagementClient)s).CheckNameAvailabilityAsync(name, type, isFqdn), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check if a resource name is available.
            /// </summary>
            /// <remarks>
            /// Check if a resource name is available.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Resource name to verify.
            /// </param>
            /// <param name='type'>
            /// Resource type used for verification. Possible values include: 'Site',
            /// 'Slot', 'HostingEnvironment'
            /// </param>
            /// <param name='isFqdn'>
            /// Is fully qualified domain name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ResourceNameAvailabilityInner> CheckNameAvailabilityAsync(this IWebSiteManagementClient operations, string name, string type, bool? isFqdn = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(name, type, isFqdn, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of available geographical regions.
            /// </summary>
            /// <remarks>
            /// Get a list of available geographical regions.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sku'>
            /// Name of SKU used to filter the regions. Possible values include: 'Free',
            /// 'Shared', 'Basic', 'Standard', 'Premium', 'Dynamic'
            /// </param>
            public static Microsoft.Rest.Azure.IPage<GeoRegionInner> ListGeoRegions(this IWebSiteManagementClient operations, string sku = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebSiteManagementClient)s).ListGeoRegionsAsync(sku), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of available geographical regions.
            /// </summary>
            /// <remarks>
            /// Get a list of available geographical regions.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sku'>
            /// Name of SKU used to filter the regions. Possible values include: 'Free',
            /// 'Shared', 'Basic', 'Standard', 'Premium', 'Dynamic'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<GeoRegionInner>> ListGeoRegionsAsync(this IWebSiteManagementClient operations, string sku = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListGeoRegionsWithHttpMessagesAsync(sku, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all premier add-on offers.
            /// </summary>
            /// <remarks>
            /// List all premier add-on offers.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<PremierAddOnOfferInner> ListPremierAddOnOffers(this IWebSiteManagementClient operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebSiteManagementClient)s).ListPremierAddOnOffersAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all premier add-on offers.
            /// </summary>
            /// <remarks>
            /// List all premier add-on offers.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<PremierAddOnOfferInner>> ListPremierAddOnOffersAsync(this IWebSiteManagementClient operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListPremierAddOnOffersWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the publishing credentials for the subscription owner.
            /// </summary>
            /// <remarks>
            /// Get the publishing credentials for the subscription owner.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static UserInner GetPublishingCredentials(this IWebSiteManagementClient operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebSiteManagementClient)s).GetPublishingCredentialsAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the publishing credentials for the subscription owner.
            /// </summary>
            /// <remarks>
            /// Get the publishing credentials for the subscription owner.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<UserInner> GetPublishingCredentialsAsync(this IWebSiteManagementClient operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetPublishingCredentialsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the publishing credentials for the subscription owner.
            /// </summary>
            /// <remarks>
            /// Update the publishing credentials for the subscription owner.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestMessage'>
            /// A request message with the new publishing credentials.
            /// </param>
            public static UserInner UpdatePublishingCredentials(this IWebSiteManagementClient operations, UserInner requestMessage)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebSiteManagementClient)s).UpdatePublishingCredentialsAsync(requestMessage), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the publishing credentials for the subscription owner.
            /// </summary>
            /// <remarks>
            /// Update the publishing credentials for the subscription owner.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestMessage'>
            /// A request message with the new publishing credentials.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<UserInner> UpdatePublishingCredentialsAsync(this IWebSiteManagementClient operations, UserInner requestMessage, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.UpdatePublishingCredentialsWithHttpMessagesAsync(requestMessage, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all SKUs.
            /// </summary>
            /// <remarks>
            /// List all SKUs.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static SkuInfosInner ListSkus(this IWebSiteManagementClient operations)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebSiteManagementClient)s).ListSkusAsync(), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all SKUs.
            /// </summary>
            /// <remarks>
            /// List all SKUs.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<SkuInfosInner> ListSkusAsync(this IWebSiteManagementClient operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListSkusWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Move resources between resource groups.
            /// </summary>
            /// <remarks>
            /// Move resources between resource groups.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='moveResourceEnvelope'>
            /// Object that represents the resource to move.
            /// </param>
            public static void Move(this IWebSiteManagementClient operations, string resourceGroupName, CsmMoveResourceEnvelopeInner moveResourceEnvelope)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebSiteManagementClient)s).MoveAsync(resourceGroupName, moveResourceEnvelope), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Move resources between resource groups.
            /// </summary>
            /// <remarks>
            /// Move resources between resource groups.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='moveResourceEnvelope'>
            /// Object that represents the resource to move.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task MoveAsync(this IWebSiteManagementClient operations, string resourceGroupName, CsmMoveResourceEnvelopeInner moveResourceEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.MoveWithHttpMessagesAsync(resourceGroupName, moveResourceEnvelope, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Validate if a resource can be created.
            /// </summary>
            /// <remarks>
            /// Validate if a resource can be created.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='validateRequest'>
            /// Request with the resources to validate.
            /// </param>
            public static ValidateResponseInner Validate(this IWebSiteManagementClient operations, string resourceGroupName, ValidateRequestInner validateRequest)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebSiteManagementClient)s).ValidateAsync(resourceGroupName, validateRequest), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Validate if a resource can be created.
            /// </summary>
            /// <remarks>
            /// Validate if a resource can be created.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='validateRequest'>
            /// Request with the resources to validate.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ValidateResponseInner> ValidateAsync(this IWebSiteManagementClient operations, string resourceGroupName, ValidateRequestInner validateRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ValidateWithHttpMessagesAsync(resourceGroupName, validateRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Validate whether a resource can be moved.
            /// </summary>
            /// <remarks>
            /// Validate whether a resource can be moved.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='moveResourceEnvelope'>
            /// Object that represents the resource to move.
            /// </param>
            public static void ValidateMove(this IWebSiteManagementClient operations, string resourceGroupName, CsmMoveResourceEnvelopeInner moveResourceEnvelope)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebSiteManagementClient)s).ValidateMoveAsync(resourceGroupName, moveResourceEnvelope), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Validate whether a resource can be moved.
            /// </summary>
            /// <remarks>
            /// Validate whether a resource can be moved.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group to which the resource belongs.
            /// </param>
            /// <param name='moveResourceEnvelope'>
            /// Object that represents the resource to move.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task ValidateMoveAsync(this IWebSiteManagementClient operations, string resourceGroupName, CsmMoveResourceEnvelopeInner moveResourceEnvelope, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.ValidateMoveWithHttpMessagesAsync(resourceGroupName, moveResourceEnvelope, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the source controls available for Azure websites.
            /// </summary>
            /// <remarks>
            /// Gets the source controls available for Azure websites.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<SourceControlInner> ListSourceControlsNext(this IWebSiteManagementClient operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebSiteManagementClient)s).ListSourceControlsNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the source controls available for Azure websites.
            /// </summary>
            /// <remarks>
            /// Gets the source controls available for Azure websites.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<SourceControlInner>> ListSourceControlsNextAsync(this IWebSiteManagementClient operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListSourceControlsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a list of available geographical regions.
            /// </summary>
            /// <remarks>
            /// Get a list of available geographical regions.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<GeoRegionInner> ListGeoRegionsNext(this IWebSiteManagementClient operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebSiteManagementClient)s).ListGeoRegionsNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a list of available geographical regions.
            /// </summary>
            /// <remarks>
            /// Get a list of available geographical regions.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<GeoRegionInner>> ListGeoRegionsNextAsync(this IWebSiteManagementClient operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListGeoRegionsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all premier add-on offers.
            /// </summary>
            /// <remarks>
            /// List all premier add-on offers.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<PremierAddOnOfferInner> ListPremierAddOnOffersNext(this IWebSiteManagementClient operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IWebSiteManagementClient)s).ListPremierAddOnOffersNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all premier add-on offers.
            /// </summary>
            /// <remarks>
            /// List all premier add-on offers.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<PremierAddOnOfferInner>> ListPremierAddOnOffersNextAsync(this IWebSiteManagementClient operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListPremierAddOnOffersNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
