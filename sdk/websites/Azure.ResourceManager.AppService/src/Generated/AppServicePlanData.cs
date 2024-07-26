// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the AppServicePlan data model.
    /// App Service plan.
    /// </summary>
    public partial class AppServicePlanData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppServicePlanData"/>. </summary>
        /// <param name="location"> The location. </param>
        public AppServicePlanData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServicePlanData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Description of a SKU for a scalable resource. </param>
        /// <param name="extendedLocation"> Extended Location. </param>
        /// <param name="workerTierName"> Target worker tier assigned to the App Service plan. </param>
        /// <param name="status"> App Service plan status. </param>
        /// <param name="subscription"> App Service plan subscription. </param>
        /// <param name="hostingEnvironmentProfile"> Specification for the App Service Environment to use for the App Service plan. </param>
        /// <param name="maximumNumberOfWorkers"> Maximum number of instances that can be assigned to this App Service plan. </param>
        /// <param name="numberOfWorkers"> The number of instances that are assigned to this App Service plan. </param>
        /// <param name="geoRegion"> Geographical location for the App Service plan. </param>
        /// <param name="isPerSiteScaling">
        /// If &lt;code&gt;true&lt;/code&gt;, apps assigned to this App Service plan can be scaled independently.
        /// If &lt;code&gt;false&lt;/code&gt;, apps assigned to this App Service plan will scale to all instances of the plan.
        /// </param>
        /// <param name="isElasticScaleEnabled"> ServerFarm supports ElasticScale. Apps in this plan will scale as if the ServerFarm was ElasticPremium sku. </param>
        /// <param name="maximumElasticWorkerCount"> Maximum number of total workers allowed for this ElasticScaleEnabled App Service Plan. </param>
        /// <param name="numberOfSites"> Number of apps assigned to this App Service plan. </param>
        /// <param name="isSpot"> If &lt;code&gt;true&lt;/code&gt;, this App Service Plan owns spot instances. </param>
        /// <param name="spotExpireOn"> The time when the server farm expires. Valid only if it is a spot server farm. </param>
        /// <param name="freeOfferExpireOn"> The time when the server farm free offer expires. </param>
        /// <param name="resourceGroup"> Resource group of the App Service plan. </param>
        /// <param name="isReserved"> If Linux app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise. </param>
        /// <param name="isXenon"> Obsolete: If Hyper-V container app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise. </param>
        /// <param name="isHyperV"> If Hyper-V container app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise. </param>
        /// <param name="targetWorkerCount"> Scaling worker count. </param>
        /// <param name="targetWorkerSizeId"> Scaling worker size ID. </param>
        /// <param name="provisioningState"> Provisioning state of the App Service Plan. </param>
        /// <param name="kubeEnvironmentProfile"> Specification for the Kubernetes Environment to use for the App Service plan. </param>
        /// <param name="isZoneRedundant">
        /// If &lt;code&gt;true&lt;/code&gt;, this App Service Plan will perform availability zone balancing.
        /// If &lt;code&gt;false&lt;/code&gt;, this App Service Plan will not perform availability zone balancing.
        /// </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServicePlanData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, AppServiceSkuDescription sku, ExtendedLocation extendedLocation, string workerTierName, AppServicePlanStatus? status, string subscription, HostingEnvironmentProfile hostingEnvironmentProfile, int? maximumNumberOfWorkers, int? numberOfWorkers, string geoRegion, bool? isPerSiteScaling, bool? isElasticScaleEnabled, int? maximumElasticWorkerCount, int? numberOfSites, bool? isSpot, DateTimeOffset? spotExpireOn, DateTimeOffset? freeOfferExpireOn, string resourceGroup, bool? isReserved, bool? isXenon, bool? isHyperV, int? targetWorkerCount, int? targetWorkerSizeId, ProvisioningState? provisioningState, KubeEnvironmentProfile kubeEnvironmentProfile, bool? isZoneRedundant, string kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            ExtendedLocation = extendedLocation;
            WorkerTierName = workerTierName;
            Status = status;
            Subscription = subscription;
            HostingEnvironmentProfile = hostingEnvironmentProfile;
            MaximumNumberOfWorkers = maximumNumberOfWorkers;
            NumberOfWorkers = numberOfWorkers;
            GeoRegion = geoRegion;
            IsPerSiteScaling = isPerSiteScaling;
            IsElasticScaleEnabled = isElasticScaleEnabled;
            MaximumElasticWorkerCount = maximumElasticWorkerCount;
            NumberOfSites = numberOfSites;
            IsSpot = isSpot;
            SpotExpireOn = spotExpireOn;
            FreeOfferExpireOn = freeOfferExpireOn;
            ResourceGroup = resourceGroup;
            IsReserved = isReserved;
            IsXenon = isXenon;
            IsHyperV = isHyperV;
            TargetWorkerCount = targetWorkerCount;
            TargetWorkerSizeId = targetWorkerSizeId;
            ProvisioningState = provisioningState;
            KubeEnvironmentProfile = kubeEnvironmentProfile;
            IsZoneRedundant = isZoneRedundant;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AppServicePlanData"/> for deserialization. </summary>
        internal AppServicePlanData()
        {
        }

        /// <summary> Description of a SKU for a scalable resource. </summary>
        [WirePath("sku")]
        public AppServiceSkuDescription Sku { get; set; }
        /// <summary> Extended Location. </summary>
        [WirePath("extendedLocation")]
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Target worker tier assigned to the App Service plan. </summary>
        [WirePath("properties.workerTierName")]
        public string WorkerTierName { get; set; }
        /// <summary> App Service plan status. </summary>
        [WirePath("properties.status")]
        public AppServicePlanStatus? Status { get; }
        /// <summary> App Service plan subscription. </summary>
        [WirePath("properties.subscription")]
        public string Subscription { get; }
        /// <summary> Specification for the App Service Environment to use for the App Service plan. </summary>
        [WirePath("properties.hostingEnvironmentProfile")]
        public HostingEnvironmentProfile HostingEnvironmentProfile { get; set; }
        /// <summary> Maximum number of instances that can be assigned to this App Service plan. </summary>
        [WirePath("properties.maximumNumberOfWorkers")]
        public int? MaximumNumberOfWorkers { get; }
        /// <summary> The number of instances that are assigned to this App Service plan. </summary>
        [WirePath("properties.numberOfWorkers")]
        public int? NumberOfWorkers { get; }
        /// <summary> Geographical location for the App Service plan. </summary>
        [WirePath("properties.geoRegion")]
        public string GeoRegion { get; }
        /// <summary>
        /// If &lt;code&gt;true&lt;/code&gt;, apps assigned to this App Service plan can be scaled independently.
        /// If &lt;code&gt;false&lt;/code&gt;, apps assigned to this App Service plan will scale to all instances of the plan.
        /// </summary>
        [WirePath("properties.perSiteScaling")]
        public bool? IsPerSiteScaling { get; set; }
        /// <summary> ServerFarm supports ElasticScale. Apps in this plan will scale as if the ServerFarm was ElasticPremium sku. </summary>
        [WirePath("properties.elasticScaleEnabled")]
        public bool? IsElasticScaleEnabled { get; set; }
        /// <summary> Maximum number of total workers allowed for this ElasticScaleEnabled App Service Plan. </summary>
        [WirePath("properties.maximumElasticWorkerCount")]
        public int? MaximumElasticWorkerCount { get; set; }
        /// <summary> Number of apps assigned to this App Service plan. </summary>
        [WirePath("properties.numberOfSites")]
        public int? NumberOfSites { get; }
        /// <summary> If &lt;code&gt;true&lt;/code&gt;, this App Service Plan owns spot instances. </summary>
        [WirePath("properties.isSpot")]
        public bool? IsSpot { get; set; }
        /// <summary> The time when the server farm expires. Valid only if it is a spot server farm. </summary>
        [WirePath("properties.spotExpirationTime")]
        public DateTimeOffset? SpotExpireOn { get; set; }
        /// <summary> The time when the server farm free offer expires. </summary>
        [WirePath("properties.freeOfferExpirationTime")]
        public DateTimeOffset? FreeOfferExpireOn { get; set; }
        /// <summary> Resource group of the App Service plan. </summary>
        [WirePath("properties.resourceGroup")]
        public string ResourceGroup { get; }
        /// <summary> If Linux app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise. </summary>
        [WirePath("properties.reserved")]
        public bool? IsReserved { get; set; }
        /// <summary> Obsolete: If Hyper-V container app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise. </summary>
        [WirePath("properties.isXenon")]
        public bool? IsXenon { get; set; }
        /// <summary> If Hyper-V container app service plan &lt;code&gt;true&lt;/code&gt;, &lt;code&gt;false&lt;/code&gt; otherwise. </summary>
        [WirePath("properties.hyperV")]
        public bool? IsHyperV { get; set; }
        /// <summary> Scaling worker count. </summary>
        [WirePath("properties.targetWorkerCount")]
        public int? TargetWorkerCount { get; set; }
        /// <summary> Scaling worker size ID. </summary>
        [WirePath("properties.targetWorkerSizeId")]
        public int? TargetWorkerSizeId { get; set; }
        /// <summary> Provisioning state of the App Service Plan. </summary>
        [WirePath("properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Specification for the Kubernetes Environment to use for the App Service plan. </summary>
        [WirePath("properties.kubeEnvironmentProfile")]
        public KubeEnvironmentProfile KubeEnvironmentProfile { get; set; }
        /// <summary>
        /// If &lt;code&gt;true&lt;/code&gt;, this App Service Plan will perform availability zone balancing.
        /// If &lt;code&gt;false&lt;/code&gt;, this App Service Plan will not perform availability zone balancing.
        /// </summary>
        [WirePath("properties.zoneRedundant")]
        public bool? IsZoneRedundant { get; set; }
        /// <summary> Kind of resource. </summary>
        [WirePath("kind")]
        public string Kind { get; set; }
    }
}
