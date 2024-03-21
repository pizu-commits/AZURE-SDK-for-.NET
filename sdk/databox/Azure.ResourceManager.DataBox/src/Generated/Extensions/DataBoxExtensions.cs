// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.DataBox.Mocking;
using Azure.ResourceManager.DataBox.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataBox
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DataBox. </summary>
    public static partial class DataBoxExtensions
    {
        private static MockableDataBoxArmClient GetMockableDataBoxArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableDataBoxArmClient(client0));
        }

        private static MockableDataBoxResourceGroupResource GetMockableDataBoxResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDataBoxResourceGroupResource(client, resource.Id));
        }

        private static MockableDataBoxSubscriptionResource GetMockableDataBoxSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableDataBoxSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataBoxJobResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxJobResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxJobResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxArmClient.GetDataBoxJobResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DataBoxJobResource"/> object. </returns>
        public static DataBoxJobResource GetDataBoxJobResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableDataBoxArmClient(client).GetDataBoxJobResource(id);
        }

        /// <summary>
        /// Gets a collection of DataBoxJobResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxResourceGroupResource.GetDataBoxJobs()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of DataBoxJobResources and their operations over a DataBoxJobResource. </returns>
        public static DataBoxJobCollection GetDataBoxJobs(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDataBoxResourceGroupResource(resourceGroupResource).GetDataBoxJobs();
        }

        /// <summary>
        /// Gets information about the specified job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxJobResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxResourceGroupResource.GetDataBoxJobAsync(string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="jobName"> The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="expand"> $expand is supported on details parameter for job, which provides details on the job stages. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="jobName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DataBoxJobResource>> GetDataBoxJobAsync(this ResourceGroupResource resourceGroupResource, string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableDataBoxResourceGroupResource(resourceGroupResource).GetDataBoxJobAsync(jobName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified job.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/jobs/{jobName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxJobResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxResourceGroupResource.GetDataBoxJob(string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="jobName"> The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="expand"> $expand is supported on details parameter for job, which provides details on the job stages. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="jobName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<DataBoxJobResource> GetDataBoxJob(this ResourceGroupResource resourceGroupResource, string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDataBoxResourceGroupResource(resourceGroupResource).GetDataBoxJob(jobName, expand, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of available skus for the given subscription, resource group and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/availableSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_ListAvailableSkusByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxResourceGroupResource.GetAvailableSkus(AzureLocation,AvailableSkusContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Filters for showing the available skus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="content"/> is null. </exception>
        /// <returns> An async collection of <see cref="DataBoxSkuInformation"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DataBoxSkuInformation> GetAvailableSkusAsync(this ResourceGroupResource resourceGroupResource, AzureLocation location, AvailableSkusContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDataBoxResourceGroupResource(resourceGroupResource).GetAvailableSkusAsync(location, content, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of available skus for the given subscription, resource group and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/availableSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_ListAvailableSkusByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxResourceGroupResource.GetAvailableSkus(AzureLocation,AvailableSkusContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Filters for showing the available skus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="content"/> is null. </exception>
        /// <returns> A collection of <see cref="DataBoxSkuInformation"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DataBoxSkuInformation> GetAvailableSkus(this ResourceGroupResource resourceGroupResource, AzureLocation location, AvailableSkusContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDataBoxResourceGroupResource(resourceGroupResource).GetAvailableSkus(location, content, cancellationToken);
        }

        /// <summary>
        /// This method does all necessary pre-job creation validation under resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/validateInputs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_ValidateInputsByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxResourceGroupResource.ValidateInputs(AzureLocation,DataBoxValidationContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<DataBoxValidationResult>> ValidateInputsAsync(this ResourceGroupResource resourceGroupResource, AzureLocation location, DataBoxValidationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableDataBoxResourceGroupResource(resourceGroupResource).ValidateInputsAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This method does all necessary pre-job creation validation under resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/validateInputs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_ValidateInputsByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxResourceGroupResource.ValidateInputs(AzureLocation,DataBoxValidationContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<DataBoxValidationResult> ValidateInputs(this ResourceGroupResource resourceGroupResource, AzureLocation location, DataBoxValidationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDataBoxResourceGroupResource(resourceGroupResource).ValidateInputs(location, content, cancellationToken);
        }

        /// <summary>
        /// This API provides configuration details specific to given region/location at Resource group level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/regionConfiguration</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_RegionConfigurationByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxResourceGroupResource.GetRegionConfiguration(AzureLocation,RegionConfigurationContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Request body to get the configuration for the region at resource group level. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<RegionConfigurationResult>> GetRegionConfigurationAsync(this ResourceGroupResource resourceGroupResource, AzureLocation location, RegionConfigurationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableDataBoxResourceGroupResource(resourceGroupResource).GetRegionConfigurationAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This API provides configuration details specific to given region/location at Resource group level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/regionConfiguration</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_RegionConfigurationByResourceGroup</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxResourceGroupResource.GetRegionConfiguration(AzureLocation,RegionConfigurationContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Request body to get the configuration for the region at resource group level. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<RegionConfigurationResult> GetRegionConfiguration(this ResourceGroupResource resourceGroupResource, AzureLocation location, RegionConfigurationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableDataBoxResourceGroupResource(resourceGroupResource).GetRegionConfiguration(location, content, cancellationToken);
        }

        /// <summary>
        /// Lists all the jobs available under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/jobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxJobResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxSubscriptionResource.GetDataBoxJobs(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of jobs, which provides the next page in the list of jobs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="DataBoxJobResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DataBoxJobResource> GetDataBoxJobsAsync(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDataBoxSubscriptionResource(subscriptionResource).GetDataBoxJobsAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists all the jobs available under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/jobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Jobs_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DataBoxJobResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxSubscriptionResource.GetDataBoxJobs(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of jobs, which provides the next page in the list of jobs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="DataBoxJobResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DataBoxJobResource> GetDataBoxJobs(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDataBoxSubscriptionResource(subscriptionResource).GetDataBoxJobs(skipToken, cancellationToken);
        }

        /// <summary>
        /// [DEPRECATED NOTICE: This operation will soon be removed]. This method validates the customer shipping address and provide alternate addresses if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/validateAddress</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_ValidateAddress</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxSubscriptionResource.ValidateAddress(AzureLocation,DataBoxValidateAddressContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Shipping address of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<AddressValidationOutput>> ValidateAddressAsync(this SubscriptionResource subscriptionResource, AzureLocation location, DataBoxValidateAddressContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableDataBoxSubscriptionResource(subscriptionResource).ValidateAddressAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// [DEPRECATED NOTICE: This operation will soon be removed]. This method validates the customer shipping address and provide alternate addresses if any.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/validateAddress</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_ValidateAddress</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxSubscriptionResource.ValidateAddress(AzureLocation,DataBoxValidateAddressContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Shipping address of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<AddressValidationOutput> ValidateAddress(this SubscriptionResource subscriptionResource, AzureLocation location, DataBoxValidateAddressContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDataBoxSubscriptionResource(subscriptionResource).ValidateAddress(location, content, cancellationToken);
        }

        /// <summary>
        /// This method does all necessary pre-job creation validation under subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/validateInputs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_ValidateInputs</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxSubscriptionResource.ValidateInputs(AzureLocation,DataBoxValidationContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<DataBoxValidationResult>> ValidateInputsAsync(this SubscriptionResource subscriptionResource, AzureLocation location, DataBoxValidationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableDataBoxSubscriptionResource(subscriptionResource).ValidateInputsAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This method does all necessary pre-job creation validation under subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/validateInputs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_ValidateInputs</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxSubscriptionResource.ValidateInputs(AzureLocation,DataBoxValidationContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<DataBoxValidationResult> ValidateInputs(this SubscriptionResource subscriptionResource, AzureLocation location, DataBoxValidationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDataBoxSubscriptionResource(subscriptionResource).ValidateInputs(location, content, cancellationToken);
        }

        /// <summary>
        /// This API provides configuration details specific to given region/location at Subscription level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/regionConfiguration</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_RegionConfiguration</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxSubscriptionResource.GetRegionConfiguration(AzureLocation,RegionConfigurationContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Request body to get the configuration for the region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<RegionConfigurationResult>> GetRegionConfigurationAsync(this SubscriptionResource subscriptionResource, AzureLocation location, RegionConfigurationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableDataBoxSubscriptionResource(subscriptionResource).GetRegionConfigurationAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This API provides configuration details specific to given region/location at Subscription level.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/regionConfiguration</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Service_RegionConfiguration</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableDataBoxSubscriptionResource.GetRegionConfiguration(AzureLocation,RegionConfigurationContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Request body to get the configuration for the region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<RegionConfigurationResult> GetRegionConfiguration(this SubscriptionResource subscriptionResource, AzureLocation location, RegionConfigurationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableDataBoxSubscriptionResource(subscriptionResource).GetRegionConfiguration(location, content, cancellationToken);
        }
    }
}
