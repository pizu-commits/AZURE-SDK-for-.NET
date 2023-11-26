namespace Azure.ResourceManager.ContainerService
{
    public partial class AgentPoolSnapshotCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource>, System.Collections.IEnumerable
    {
        protected AgentPoolSnapshotCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string resourceName, Azure.ResourceManager.ContainerService.AgentPoolSnapshotData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string resourceName, Azure.ResourceManager.ContainerService.AgentPoolSnapshotData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> Get(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource>> GetAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> GetIfExists(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource>> GetIfExistsAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class AgentPoolSnapshotData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.AgentPoolSnapshotData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.AgentPoolSnapshotData>
    {
        public AgentPoolSnapshotData(Azure.Core.AzureLocation location) { }
        public Azure.Core.ResourceIdentifier CreationDataSourceResourceId { get { throw null; } set { } }
        public bool? EnableFips { get { throw null; } }
        public string KubernetesVersion { get { throw null; } }
        public string NodeImageVersion { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku? OSSku { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType? OSType { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.SnapshotType? SnapshotType { get { throw null; } set { } }
        public string VmSize { get { throw null; } }
        Azure.ResourceManager.ContainerService.AgentPoolSnapshotData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.AgentPoolSnapshotData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.AgentPoolSnapshotData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.AgentPoolSnapshotData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.AgentPoolSnapshotData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.AgentPoolSnapshotData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.AgentPoolSnapshotData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AgentPoolSnapshotResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AgentPoolSnapshotResource() { }
        public virtual Azure.ResourceManager.ContainerService.AgentPoolSnapshotData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> Update(Azure.ResourceManager.ContainerService.Models.ContainerServiceTagsObject containerServiceTagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource>> UpdateAsync(Azure.ResourceManager.ContainerService.Models.ContainerServiceTagsObject containerServiceTagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AgentPoolUpgradeProfileData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.AgentPoolUpgradeProfileData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.AgentPoolUpgradeProfileData>
    {
        internal AgentPoolUpgradeProfileData() { }
        public string KubernetesVersion { get { throw null; } }
        public string LatestNodeImageVersion { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType OSType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerService.Models.AgentPoolUpgradeProfilePropertiesUpgradesItem> Upgrades { get { throw null; } }
        Azure.ResourceManager.ContainerService.AgentPoolUpgradeProfileData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.AgentPoolUpgradeProfileData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.AgentPoolUpgradeProfileData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.AgentPoolUpgradeProfileData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.AgentPoolUpgradeProfileData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.AgentPoolUpgradeProfileData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.AgentPoolUpgradeProfileData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AgentPoolUpgradeProfileResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected AgentPoolUpgradeProfileResource() { }
        public virtual Azure.ResourceManager.ContainerService.AgentPoolUpgradeProfileData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string agentPoolName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolUpgradeProfileResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolUpgradeProfileResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ContainerServiceAgentPoolCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource>, System.Collections.IEnumerable
    {
        protected ContainerServiceAgentPoolCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string agentPoolName, Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string agentPoolName, Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string agentPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string agentPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource> Get(string agentPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource>> GetAsync(string agentPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource> GetIfExists(string agentPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource>> GetIfExistsAsync(string agentPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ContainerServiceAgentPoolData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolData>
    {
        public ContainerServiceAgentPoolData() { }
        public System.Collections.Generic.IList<string> AvailabilityZones { get { throw null; } }
        public Azure.Core.ResourceIdentifier CapacityReservationGroupId { get { throw null; } set { } }
        public int? Count { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier CreationDataSourceResourceId { get { throw null; } set { } }
        public string CurrentOrchestratorVersion { get { throw null; } }
        public bool? DisableOutboundNat { get { throw null; } set { } }
        public bool? EnableAutoScaling { get { throw null; } set { } }
        public bool? EnableCustomCATrust { get { throw null; } set { } }
        public bool? EnableEncryptionAtHost { get { throw null; } set { } }
        public bool? EnableFips { get { throw null; } set { } }
        public bool? EnableNodePublicIP { get { throw null; } set { } }
        public bool? EnableUltraSsd { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile? GpuInstanceProfile { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier HostGroupId { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.KubeletConfig KubeletConfig { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.KubeletDiskType? KubeletDiskType { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.LinuxOSConfig LinuxOSConfig { get { throw null; } set { } }
        public int? MaxCount { get { throw null; } set { } }
        public int? MaxPods { get { throw null; } set { } }
        public string MessageOfTheDay { get { throw null; } set { } }
        public int? MinCount { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.AgentPoolMode? Mode { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkProfile NetworkProfile { get { throw null; } set { } }
        public string NodeImageVersion { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> NodeLabels { get { throw null; } }
        public Azure.Core.ResourceIdentifier NodePublicIPPrefixId { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> NodeTaints { get { throw null; } }
        public string OrchestratorVersion { get { throw null; } set { } }
        public int? OSDiskSizeInGB { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType? OSDiskType { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku? OSSku { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType? OSType { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier PodSubnetId { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode? PowerStateCode { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public Azure.Core.ResourceIdentifier ProximityPlacementGroupId { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ScaleDownMode? ScaleDownMode { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy? ScaleSetEvictionPolicy { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ScaleSetPriority? ScaleSetPriority { get { throw null; } set { } }
        public float? SpotMaxPrice { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.AgentPoolType? TypePropertiesType { get { throw null; } set { } }
        public string UpgradeMaxSurge { get { throw null; } set { } }
        public string VmSize { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier VnetSubnetId { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.WorkloadRuntime? WorkloadRuntime { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceAgentPoolResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ContainerServiceAgentPoolResource() { }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation AbortLatestOperation(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> AbortLatestOperationAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string agentPoolName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, bool? ignorePodDisruptionBudget = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future release", false)]
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, bool? ignorePodDisruptionBudget = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future release", false)]
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.AgentPoolUpgradeProfileResource GetAgentPoolUpgradeProfile() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation UpgradeNodeImageVersion(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> UpgradeNodeImageVersionAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class ContainerServiceExtensions
    {
        public static Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> GetAgentPoolSnapshot(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource>> GetAgentPoolSnapshotAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource GetAgentPoolSnapshotResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ContainerService.AgentPoolSnapshotCollection GetAgentPoolSnapshots(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> GetAgentPoolSnapshots(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> GetAgentPoolSnapshotsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ContainerService.AgentPoolUpgradeProfileResource GetAgentPoolUpgradeProfileResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource GetContainerServiceAgentPoolResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> GetContainerServiceFleet(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource>> GetContainerServiceFleetAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource GetContainerServiceFleetMemberResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ContainerService.ContainerServiceFleetResource GetContainerServiceFleetResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ContainerService.ContainerServiceFleetCollection GetContainerServiceFleets(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> GetContainerServiceFleets(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> GetContainerServiceFleetsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource GetContainerServiceMaintenanceConfigurationResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> GetContainerServiceManagedCluster(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource>> GetContainerServiceManagedClusterAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource GetContainerServiceManagedClusterResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterCollection GetContainerServiceManagedClusters(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> GetContainerServiceManagedClusters(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> GetContainerServiceManagedClustersAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource GetContainerServicePrivateEndpointConnectionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource GetContainerServiceTrustedAccessRoleBindingResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> GetManagedClusterSnapshot(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource>> GetManagedClusterSnapshotAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource GetManagedClusterSnapshotResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ContainerService.ManagedClusterSnapshotCollection GetManagedClusterSnapshots(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> GetManagedClusterSnapshots(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> GetManagedClusterSnapshotsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ContainerService.ManagedClusterUpgradeProfileResource GetManagedClusterUpgradeProfileResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ContainerService.OSOptionProfileResource GetOSOptionProfile(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location) { throw null; }
        public static Azure.ResourceManager.ContainerService.OSOptionProfileResource GetOSOptionProfileResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRole> GetTrustedAccessRoles(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRole> GetTrustedAccessRolesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, Azure.Core.AzureLocation location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ContainerServiceFleetCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource>, System.Collections.IEnumerable
    {
        protected ContainerServiceFleetCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string fleetName, Azure.ResourceManager.ContainerService.ContainerServiceFleetData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string fleetName, Azure.ResourceManager.ContainerService.ContainerServiceFleetData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> Get(string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource>> GetAsync(string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> GetIfExists(string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource>> GetIfExistsAsync(string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ContainerServiceFleetData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceFleetData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceFleetData>
    {
        public ContainerServiceFleetData(Azure.Core.AzureLocation location) { }
        public Azure.ETag? ETag { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetHubProfile HubProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetProvisioningState? ProvisioningState { get { throw null; } }
        Azure.ResourceManager.ContainerService.ContainerServiceFleetData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceFleetData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceFleetData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.ContainerServiceFleetData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceFleetData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceFleetData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceFleetData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceFleetMemberCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource>, System.Collections.IEnumerable
    {
        protected ContainerServiceFleetMemberCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string fleetMemberName, Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string fleetMemberName, Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string fleetMemberName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string fleetMemberName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource> Get(string fleetMemberName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource>> GetAsync(string fleetMemberName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource> GetIfExists(string fleetMemberName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource>> GetIfExistsAsync(string fleetMemberName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ContainerServiceFleetMemberData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberData>
    {
        public ContainerServiceFleetMemberData() { }
        public Azure.Core.ResourceIdentifier ClusterResourceId { get { throw null; } set { } }
        public Azure.ETag? ETag { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetMemberProvisioningState? ProvisioningState { get { throw null; } }
        Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceFleetMemberResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ContainerServiceFleetMemberResource() { }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string fleetName, string fleetMemberName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberData data, string ifMatch = null, string ifNoneMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ContainerServiceFleetResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ContainerServiceFleetResource() { }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceFleetData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string fleetName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource> GetContainerServiceFleetMember(string fleetMemberName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource>> GetContainerServiceFleetMemberAsync(string fleetMemberName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberCollection GetContainerServiceFleetMembers() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResults> GetCredentials(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResults>> GetCredentialsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> Update(Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetPatch patch, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource>> UpdateAsync(Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetPatch patch, string ifMatch = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ContainerServiceMaintenanceConfigurationCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource>, System.Collections.IEnumerable
    {
        protected ContainerServiceMaintenanceConfigurationCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string configName, Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string configName, Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string configName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string configName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource> Get(string configName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource>> GetAsync(string configName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource> GetIfExists(string configName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource>> GetIfExistsAsync(string configName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ContainerServiceMaintenanceConfigurationData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationData>
    {
        public ContainerServiceMaintenanceConfigurationData() { }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWindow MaintenanceWindow { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeSpan> NotAllowedTimes { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeInWeek> TimesInWeek { get { throw null; } }
        Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceMaintenanceConfigurationResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ContainerServiceMaintenanceConfigurationResource() { }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string configName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ContainerServiceManagedClusterCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource>, System.Collections.IEnumerable
    {
        protected ContainerServiceManagedClusterCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string resourceName, Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string resourceName, Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> Get(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource>> GetAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> GetIfExists(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource>> GetIfExistsAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ContainerServiceManagedClusterData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterData>
    {
        public ContainerServiceManagedClusterData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterAadProfile AadProfile { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfile> AddonProfiles { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfile> AgentPoolProfiles { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterApiServerAccessProfile ApiServerAccessProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoScalerProfile AutoScalerProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoUpgradeProfile AutoUpgradeProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileMetrics AzureMonitorMetrics { get { throw null; } set { } }
        public string AzurePortalFqdn { get { throw null; } }
        public Azure.Core.ResourceIdentifier CreationDataSourceResourceId { get { throw null; } set { } }
        public string CurrentKubernetesVersion { get { throw null; } }
        public bool? DisableLocalAccounts { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier DiskEncryptionSetId { get { throw null; } set { } }
        public string DnsPrefix { get { throw null; } set { } }
        public bool? EnableNamespaceResources { get { throw null; } set { } }
        public bool? EnablePodSecurityPolicy { get { throw null; } set { } }
        public bool? EnableRbac { get { throw null; } set { } }
        public Azure.ResourceManager.Resources.Models.ExtendedLocation ExtendedLocation { get { throw null; } set { } }
        public string Fqdn { get { throw null; } }
        public string FqdnSubdomain { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfile GuardrailsProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterHttpProxyConfig HttpProxyConfig { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.ContainerService.Models.ContainerServiceUserAssignedIdentity> IdentityProfile { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterIngressProfileWebAppRouting IngressWebAppRouting { get { throw null; } set { } }
        public string KubernetesVersion { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceLinuxProfile LinuxProfile { get { throw null; } set { } }
        public int? MaxAgentPools { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfile NetworkProfile { get { throw null; } set { } }
        public string NodeResourceGroup { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeResourceGroupRestrictionLevel? NodeResourceGroupRestrictionLevel { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterOidcIssuerProfile OidcIssuerProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProfile PodIdentityProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode? PowerStateCode { get { throw null; } }
        public string PrivateFqdn { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData> PrivateLinkResources { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServicePublicNetworkAccess? PublicNetworkAccess { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This property is obsolete and will be removed in a future release", false)]
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileAzureDefender SecurityAzureDefender { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfile SecurityProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterServicePrincipalProfile ServicePrincipalProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterSku Sku { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfile StorageProfile { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This property is obsolete and will be removed in a future release", false)]
        public Azure.ResourceManager.ContainerService.Models.UpgradeChannel? UpgradeChannel { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterWindowsProfile WindowsProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerProfile WorkloadAutoScalerProfile { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceManagedClusterResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ContainerServiceManagedClusterResource() { }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.ResourceManager.ArmOperation AbortLatestOperation(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> AbortLatestOperationAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, bool? ignorePodDisruptionBudget = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future release", false)]
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, bool? ignorePodDisruptionBudget = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This method is obsolete and will be removed in a future release", false)]
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.Models.ManagedClusterAccessProfile> GetAccessProfile(string roleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.Models.ManagedClusterAccessProfile>> GetAccessProfileAsync(string roleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersions> GetAvailableAgentPoolVersions(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersions>> GetAvailableAgentPoolVersionsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredentials> GetClusterAdminCredentials(string serverFqdn = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredentials>> GetClusterAdminCredentialsAsync(string serverFqdn = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredentials> GetClusterMonitoringUserCredentials(string serverFqdn = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredentials>> GetClusterMonitoringUserCredentialsAsync(string serverFqdn = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredentials> GetClusterUserCredentials(string serverFqdn = null, Azure.ResourceManager.ContainerService.Models.KubeConfigFormat? format = default(Azure.ResourceManager.ContainerService.Models.KubeConfigFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredentials>> GetClusterUserCredentialsAsync(string serverFqdn = null, Azure.ResourceManager.ContainerService.Models.KubeConfigFormat? format = default(Azure.ResourceManager.ContainerService.Models.KubeConfigFormat?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandResult> GetCommandResult(string commandId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandResult>> GetCommandResultAsync(string commandId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource> GetContainerServiceAgentPool(string agentPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource>> GetContainerServiceAgentPoolAsync(string agentPoolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolCollection GetContainerServiceAgentPools() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource> GetContainerServiceMaintenanceConfiguration(string configName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource>> GetContainerServiceMaintenanceConfigurationAsync(string configName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationCollection GetContainerServiceMaintenanceConfigurations() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource> GetContainerServicePrivateEndpointConnection(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource>> GetContainerServicePrivateEndpointConnectionAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionCollection GetContainerServicePrivateEndpointConnections() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource> GetContainerServiceTrustedAccessRoleBinding(string trustedAccessRoleBindingName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource>> GetContainerServiceTrustedAccessRoleBindingAsync(string trustedAccessRoleBindingName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingCollection GetContainerServiceTrustedAccessRoleBindings() { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ManagedClusterUpgradeProfileResource GetManagedClusterUpgradeProfile() { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundEnvironmentEndpoint> GetOutboundNetworkDependenciesEndpoints(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundEnvironmentEndpoint> GetOutboundNetworkDependenciesEndpointsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData> GetPrivateLinkResources(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData> GetPrivateLinkResourcesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation ResetAadProfile(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.Models.ManagedClusterAadProfile managedClusterAadProfile, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> ResetAadProfileAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.Models.ManagedClusterAadProfile managedClusterAadProfile, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation ResetServicePrincipalProfile(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.Models.ManagedClusterServicePrincipalProfile managedClusterServicePrincipalProfile, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> ResetServicePrincipalProfileAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.Models.ManagedClusterServicePrincipalProfile managedClusterServicePrincipalProfile, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData> ResolvePrivateLinkServiceId(Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData>> ResolvePrivateLinkServiceIdAsync(Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation RotateClusterCertificates(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> RotateClusterCertificatesAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation RotateServiceAccountSigningKeys(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> RotateServiceAccountSigningKeysAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandResult> RunCommand(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandResult>> RunCommandAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Start(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> StartAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Stop(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> StopAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.Models.ContainerServiceTagsObject containerServiceTagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.Models.ContainerServiceTagsObject containerServiceTagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ContainerServicePrivateEndpointConnectionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource>, System.Collections.IEnumerable
    {
        protected ContainerServicePrivateEndpointConnectionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string privateEndpointConnectionName, Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource> GetIfExists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource>> GetIfExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ContainerServicePrivateEndpointConnectionData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionData>
    {
        public ContainerServicePrivateEndpointConnectionData() { }
        public Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionState ConnectionState { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier PrivateEndpointId { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateEndpointConnectionProvisioningState? ProvisioningState { get { throw null; } }
        Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServicePrivateEndpointConnectionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ContainerServicePrivateEndpointConnectionResource() { }
        public virtual Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string privateEndpointConnectionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ContainerServiceTrustedAccessRoleBindingCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource>, System.Collections.IEnumerable
    {
        protected ContainerServiceTrustedAccessRoleBindingCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string trustedAccessRoleBindingName, Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string trustedAccessRoleBindingName, Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string trustedAccessRoleBindingName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string trustedAccessRoleBindingName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource> Get(string trustedAccessRoleBindingName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource>> GetAsync(string trustedAccessRoleBindingName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource> GetIfExists(string trustedAccessRoleBindingName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource>> GetIfExistsAsync(string trustedAccessRoleBindingName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ContainerServiceTrustedAccessRoleBindingData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingData>
    {
        public ContainerServiceTrustedAccessRoleBindingData(Azure.Core.ResourceIdentifier sourceResourceId, System.Collections.Generic.IEnumerable<string> roles) { }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleBindingProvisioningState? ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IList<string> Roles { get { throw null; } }
        public Azure.Core.ResourceIdentifier SourceResourceId { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceTrustedAccessRoleBindingResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ContainerServiceTrustedAccessRoleBindingResource() { }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName, string trustedAccessRoleBindingName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ManagedClusterSnapshotCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource>, System.Collections.IEnumerable
    {
        protected ManagedClusterSnapshotCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string resourceName, Azure.ResourceManager.ContainerService.ManagedClusterSnapshotData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string resourceName, Azure.ResourceManager.ContainerService.ManagedClusterSnapshotData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> Get(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource>> GetAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> GetIfExists(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource>> GetIfExistsAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ManagedClusterSnapshotData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotData>
    {
        public ManagedClusterSnapshotData(Azure.Core.AzureLocation location) { }
        public Azure.Core.ResourceIdentifier CreationDataSourceResourceId { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterPropertiesForSnapshot ManagedClusterPropertiesReadOnly { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.SnapshotType? SnapshotType { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.ManagedClusterSnapshotData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.ManagedClusterSnapshotData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterSnapshotResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ManagedClusterSnapshotResource() { }
        public virtual Azure.ResourceManager.ContainerService.ManagedClusterSnapshotData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> Update(Azure.ResourceManager.ContainerService.Models.ContainerServiceTagsObject containerServiceTagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource>> UpdateAsync(Azure.ResourceManager.ContainerService.Models.ContainerServiceTagsObject containerServiceTagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ManagedClusterUpgradeProfileData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ManagedClusterUpgradeProfileData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ManagedClusterUpgradeProfileData>
    {
        internal ManagedClusterUpgradeProfileData() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfile> AgentPoolProfiles { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfile ControlPlaneProfile { get { throw null; } }
        Azure.ResourceManager.ContainerService.ManagedClusterUpgradeProfileData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ManagedClusterUpgradeProfileData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.ManagedClusterUpgradeProfileData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.ManagedClusterUpgradeProfileData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ManagedClusterUpgradeProfileData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ManagedClusterUpgradeProfileData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.ManagedClusterUpgradeProfileData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterUpgradeProfileResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ManagedClusterUpgradeProfileResource() { }
        public virtual Azure.ResourceManager.ContainerService.ManagedClusterUpgradeProfileData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resourceName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterUpgradeProfileResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterUpgradeProfileResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class OSOptionProfileData : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.OSOptionProfileData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.OSOptionProfileData>
    {
        internal OSOptionProfileData() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerService.Models.ContainerServiceOSOptionProperty> OSOptionPropertyList { get { throw null; } }
        Azure.ResourceManager.ContainerService.OSOptionProfileData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.OSOptionProfileData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.OSOptionProfileData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.OSOptionProfileData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.OSOptionProfileData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.OSOptionProfileData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.OSOptionProfileData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class OSOptionProfileResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected OSOptionProfileResource() { }
        public virtual Azure.ResourceManager.ContainerService.OSOptionProfileData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, Azure.Core.AzureLocation location) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.OSOptionProfileResource> Get(Azure.Core.ResourceType? resourceType = default(Azure.Core.ResourceType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.OSOptionProfileResource>> GetAsync(Azure.Core.ResourceType? resourceType = default(Azure.Core.ResourceType?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.ContainerService.Mocking
{
    public partial class MockableContainerServiceArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableContainerServiceArmClient() { }
        public virtual Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource GetAgentPoolSnapshotResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.AgentPoolUpgradeProfileResource GetAgentPoolUpgradeProfileResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolResource GetContainerServiceAgentPoolResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberResource GetContainerServiceFleetMemberResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceFleetResource GetContainerServiceFleetResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationResource GetContainerServiceMaintenanceConfigurationResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource GetContainerServiceManagedClusterResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionResource GetContainerServicePrivateEndpointConnectionResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingResource GetContainerServiceTrustedAccessRoleBindingResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource GetManagedClusterSnapshotResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ManagedClusterUpgradeProfileResource GetManagedClusterUpgradeProfileResource(Azure.Core.ResourceIdentifier id) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.OSOptionProfileResource GetOSOptionProfileResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableContainerServiceResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableContainerServiceResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> GetAgentPoolSnapshot(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource>> GetAgentPoolSnapshotAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.AgentPoolSnapshotCollection GetAgentPoolSnapshots() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> GetContainerServiceFleet(string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource>> GetContainerServiceFleetAsync(string fleetName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceFleetCollection GetContainerServiceFleets() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> GetContainerServiceManagedCluster(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource>> GetContainerServiceManagedClusterAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterCollection GetContainerServiceManagedClusters() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> GetManagedClusterSnapshot(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource>> GetManagedClusterSnapshotAsync(string resourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.ManagedClusterSnapshotCollection GetManagedClusterSnapshots() { throw null; }
    }
    public partial class MockableContainerServiceSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableContainerServiceSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> GetAgentPoolSnapshots(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerService.AgentPoolSnapshotResource> GetAgentPoolSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> GetContainerServiceFleets(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerService.ContainerServiceFleetResource> GetContainerServiceFleetsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> GetContainerServiceManagedClusters(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterResource> GetContainerServiceManagedClustersAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> GetManagedClusterSnapshots(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerService.ManagedClusterSnapshotResource> GetManagedClusterSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ContainerService.OSOptionProfileResource GetOSOptionProfile(Azure.Core.AzureLocation location) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRole> GetTrustedAccessRoles(Azure.Core.AzureLocation location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRole> GetTrustedAccessRolesAsync(Azure.Core.AzureLocation location, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class AgentPoolAvailableVersion : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersion>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersion>
    {
        internal AgentPoolAvailableVersion() { }
        public bool? IsDefault { get { throw null; } }
        public bool? IsPreview { get { throw null; } }
        public string KubernetesVersion { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersion System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersion>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersion>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersion System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersion>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersion>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersion>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AgentPoolAvailableVersions : Azure.ResourceManager.Models.ResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersions>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersions>
    {
        internal AgentPoolAvailableVersions() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersion> AgentPoolVersions { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersions System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersions>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersions>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersions System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersions>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersions>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersions>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AgentPoolMode : System.IEquatable<Azure.ResourceManager.ContainerService.Models.AgentPoolMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AgentPoolMode(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.AgentPoolMode System { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.AgentPoolMode User { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.AgentPoolMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.AgentPoolMode left, Azure.ResourceManager.ContainerService.Models.AgentPoolMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.AgentPoolMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.AgentPoolMode left, Azure.ResourceManager.ContainerService.Models.AgentPoolMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AgentPoolNetworkPortProtocol : System.IEquatable<Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortProtocol>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AgentPoolNetworkPortProtocol(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortProtocol Tcp { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortProtocol Udp { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortProtocol other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortProtocol left, Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortProtocol right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortProtocol (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortProtocol left, Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortProtocol right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AgentPoolNetworkPortRange : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortRange>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortRange>
    {
        public AgentPoolNetworkPortRange() { }
        public int? PortEnd { get { throw null; } set { } }
        public int? PortStart { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortProtocol? Protocol { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortRange System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortRange>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortRange>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortRange System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortRange>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortRange>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortRange>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class AgentPoolNetworkProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkProfile>
    {
        public AgentPoolNetworkProfile() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkPortRange> AllowedHostPorts { get { throw null; } }
        public System.Collections.Generic.IList<Azure.Core.ResourceIdentifier> ApplicationSecurityGroups { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerService.Models.ContainerServiceIPTag> NodePublicIPTags { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AgentPoolType : System.IEquatable<Azure.ResourceManager.ContainerService.Models.AgentPoolType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AgentPoolType(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.AgentPoolType AvailabilitySet { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.AgentPoolType VirtualMachineScaleSets { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.AgentPoolType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.AgentPoolType left, Azure.ResourceManager.ContainerService.Models.AgentPoolType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.AgentPoolType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.AgentPoolType left, Azure.ResourceManager.ContainerService.Models.AgentPoolType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AgentPoolUpgradeProfilePropertiesUpgradesItem : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.AgentPoolUpgradeProfilePropertiesUpgradesItem>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolUpgradeProfilePropertiesUpgradesItem>
    {
        internal AgentPoolUpgradeProfilePropertiesUpgradesItem() { }
        public bool? IsPreview { get { throw null; } }
        public string KubernetesVersion { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.AgentPoolUpgradeProfilePropertiesUpgradesItem System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.AgentPoolUpgradeProfilePropertiesUpgradesItem>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.AgentPoolUpgradeProfilePropertiesUpgradesItem>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.AgentPoolUpgradeProfilePropertiesUpgradesItem System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolUpgradeProfilePropertiesUpgradesItem>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolUpgradeProfilePropertiesUpgradesItem>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.AgentPoolUpgradeProfilePropertiesUpgradesItem>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public static partial class ArmContainerServiceModelFactory
    {
        public static Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersion AgentPoolAvailableVersion(bool? isDefault = default(bool?), string kubernetesVersion = null, bool? isPreview = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersions AgentPoolAvailableVersions(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.Models.AgentPoolAvailableVersion> agentPoolVersions = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.AgentPoolSnapshotData AgentPoolSnapshotData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.Core.ResourceIdentifier creationDataSourceResourceId = null, Azure.ResourceManager.ContainerService.Models.SnapshotType? snapshotType = default(Azure.ResourceManager.ContainerService.Models.SnapshotType?), string kubernetesVersion = null, string nodeImageVersion = null, Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType? osType = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType?), Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku? osSku = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku?), string vmSize = null, bool? enableFips = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ContainerService.AgentPoolUpgradeProfileData AgentPoolUpgradeProfileData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string kubernetesVersion = null, Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType osType = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.Models.AgentPoolUpgradeProfilePropertiesUpgradesItem> upgrades = null, string latestNodeImageVersion = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.AgentPoolUpgradeProfilePropertiesUpgradesItem AgentPoolUpgradeProfilePropertiesUpgradesItem(string kubernetesVersion = null, bool? isPreview = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ContainerService.ContainerServiceAgentPoolData ContainerServiceAgentPoolData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, int? count = default(int?), string vmSize = null, int? osDiskSizeInGB = default(int?), Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType? osDiskType = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType?), Azure.ResourceManager.ContainerService.Models.KubeletDiskType? kubeletDiskType = default(Azure.ResourceManager.ContainerService.Models.KubeletDiskType?), Azure.ResourceManager.ContainerService.Models.WorkloadRuntime? workloadRuntime = default(Azure.ResourceManager.ContainerService.Models.WorkloadRuntime?), string messageOfTheDay = null, Azure.Core.ResourceIdentifier vnetSubnetId = null, Azure.Core.ResourceIdentifier podSubnetId = null, int? maxPods = default(int?), Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType? osType = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType?), Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku? osSku = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku?), int? maxCount = default(int?), int? minCount = default(int?), bool? enableAutoScaling = default(bool?), Azure.ResourceManager.ContainerService.Models.ScaleDownMode? scaleDownMode = default(Azure.ResourceManager.ContainerService.Models.ScaleDownMode?), Azure.ResourceManager.ContainerService.Models.AgentPoolType? typePropertiesType = default(Azure.ResourceManager.ContainerService.Models.AgentPoolType?), Azure.ResourceManager.ContainerService.Models.AgentPoolMode? mode = default(Azure.ResourceManager.ContainerService.Models.AgentPoolMode?), string orchestratorVersion = null, string currentOrchestratorVersion = null, string nodeImageVersion = null, string upgradeMaxSurge = null, string provisioningState = null, Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode? powerStateCode = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode?), System.Collections.Generic.IEnumerable<string> availabilityZones = null, bool? enableNodePublicIP = default(bool?), bool? enableCustomCATrust = default(bool?), Azure.Core.ResourceIdentifier nodePublicIPPrefixId = null, Azure.ResourceManager.ContainerService.Models.ScaleSetPriority? scaleSetPriority = default(Azure.ResourceManager.ContainerService.Models.ScaleSetPriority?), Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy? scaleSetEvictionPolicy = default(Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy?), float? spotMaxPrice = default(float?), System.Collections.Generic.IDictionary<string, string> tags = null, System.Collections.Generic.IDictionary<string, string> nodeLabels = null, System.Collections.Generic.IEnumerable<string> nodeTaints = null, Azure.Core.ResourceIdentifier proximityPlacementGroupId = null, Azure.ResourceManager.ContainerService.Models.KubeletConfig kubeletConfig = null, Azure.ResourceManager.ContainerService.Models.LinuxOSConfig linuxOSConfig = null, bool? enableEncryptionAtHost = default(bool?), bool? enableUltraSsd = default(bool?), bool? enableFips = default(bool?), Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile? gpuInstanceProfile = default(Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile?), Azure.Core.ResourceIdentifier creationDataSourceResourceId = null, Azure.Core.ResourceIdentifier capacityReservationGroupId = null, Azure.Core.ResourceIdentifier hostGroupId = null, bool? disableOutboundNat = default(bool?), Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkProfile networkProfile = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDependency ContainerServiceEndpointDependency(string domainName = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDetail> endpointDetails = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDetail ContainerServiceEndpointDetail(System.Net.IPAddress ipAddress = null, int? port = default(int?), string protocol = null, string description = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResult ContainerServiceFleetCredentialResult(string name = null, byte[] value = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResults ContainerServiceFleetCredentialResults(System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResult> kubeconfigs = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.ContainerServiceFleetData ContainerServiceFleetData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ETag? etag = default(Azure.ETag?), Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetHubProfile hubProfile = null, Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetProvisioningState? provisioningState = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetHubProfile ContainerServiceFleetHubProfile(string dnsPrefix = null, string fqdn = null, string kubernetesVersion = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.ContainerServiceFleetMemberData ContainerServiceFleetMemberData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.Core.ResourceIdentifier clusterResourceId = null, Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetMemberProvisioningState? provisioningState = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetMemberProvisioningState?), Azure.ETag? etag = default(Azure.ETag?)) { throw null; }
        public static Azure.ResourceManager.ContainerService.ContainerServiceMaintenanceConfigurationData ContainerServiceMaintenanceConfigurationData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeInWeek> timesInWeek = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeSpan> notAllowedTimes = null, Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWindow maintenanceWindow = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.ContainerServiceManagedClusterData ContainerServiceManagedClusterData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.ContainerService.Models.ManagedClusterSku sku = null, Azure.ResourceManager.Resources.Models.ExtendedLocation extendedLocation = null, Azure.ResourceManager.Models.ManagedServiceIdentity identity = null, string provisioningState = null, Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode? powerStateCode = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode?), Azure.Core.ResourceIdentifier creationDataSourceResourceId = null, int? maxAgentPools = default(int?), string kubernetesVersion = null, string currentKubernetesVersion = null, string dnsPrefix = null, string fqdnSubdomain = null, string fqdn = null, string privateFqdn = null, string azurePortalFqdn = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfile> agentPoolProfiles = null, Azure.ResourceManager.ContainerService.Models.ContainerServiceLinuxProfile linuxProfile = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterWindowsProfile windowsProfile = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterServicePrincipalProfile servicePrincipalProfile = null, System.Collections.Generic.IDictionary<string, Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfile> addonProfiles = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProfile podIdentityProfile = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterOidcIssuerProfile oidcIssuerProfile = null, string nodeResourceGroup = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeResourceGroupRestrictionLevel? nodeResourceGroupRestrictionLevel = default(Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeResourceGroupRestrictionLevel?), bool? enableRbac = default(bool?), bool? enablePodSecurityPolicy = default(bool?), bool? enableNamespaceResources = default(bool?), Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfile networkProfile = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterAadProfile aadProfile = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoUpgradeProfile autoUpgradeProfile = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoScalerProfile autoScalerProfile = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterApiServerAccessProfile apiServerAccessProfile = null, Azure.Core.ResourceIdentifier diskEncryptionSetId = null, System.Collections.Generic.IDictionary<string, Azure.ResourceManager.ContainerService.Models.ContainerServiceUserAssignedIdentity> identityProfile = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData> privateLinkResources = null, bool? disableLocalAccounts = default(bool?), Azure.ResourceManager.ContainerService.Models.ManagedClusterHttpProxyConfig httpProxyConfig = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfile securityProfile = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfile storageProfile = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterIngressProfileWebAppRouting ingressWebAppRouting = null, Azure.ResourceManager.ContainerService.Models.ContainerServicePublicNetworkAccess? publicNetworkAccess = default(Azure.ResourceManager.ContainerService.Models.ContainerServicePublicNetworkAccess?), Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerProfile workloadAutoScalerProfile = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileMetrics azureMonitorMetrics = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfile guardrailsProfile = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileForSnapshot ContainerServiceNetworkProfileForSnapshot(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPlugin? networkPlugin = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPlugin?), Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPluginMode? networkPluginMode = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPluginMode?), Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPolicy? networkPolicy = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPolicy?), Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkMode? networkMode = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkMode?), Azure.ResourceManager.ContainerService.Models.ContainerServiceLoadBalancerSku? loadBalancerSku = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceLoadBalancerSku?)) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceOSOptionProperty ContainerServiceOSOptionProperty(string osType = null, bool enableFipsImage = false) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundEnvironmentEndpoint ContainerServiceOutboundEnvironmentEndpoint(string category = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDependency> endpoints = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.ContainerServicePrivateEndpointConnectionData ContainerServicePrivateEndpointConnectionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateEndpointConnectionProvisioningState? provisioningState = default(Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateEndpointConnectionProvisioningState?), Azure.Core.ResourceIdentifier privateEndpointId = null, Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionState connectionState = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData ContainerServicePrivateLinkResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType? resourceType = default(Azure.Core.ResourceType?), string groupId = null, System.Collections.Generic.IEnumerable<string> requiredMembers = null, Azure.Core.ResourceIdentifier privateLinkServiceId = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRole ContainerServiceTrustedAccessRole(string sourceResourceType = null, string name = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleRule> rules = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.ContainerServiceTrustedAccessRoleBindingData ContainerServiceTrustedAccessRoleBindingData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleBindingProvisioningState? provisioningState = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleBindingProvisioningState?), Azure.Core.ResourceIdentifier sourceResourceId = null, System.Collections.Generic.IEnumerable<string> roles = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleRule ContainerServiceTrustedAccessRoleRule(System.Collections.Generic.IEnumerable<string> verbs = null, System.Collections.Generic.IEnumerable<string> apiGroups = null, System.Collections.Generic.IEnumerable<string> resources = null, System.Collections.Generic.IEnumerable<string> resourceNames = null, System.Collections.Generic.IEnumerable<string> nonResourceUrls = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterAccessProfile ManagedClusterAccessProfile(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), byte[] kubeConfig = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfile ManagedClusterAddonProfile(bool isEnabled = false, System.Collections.Generic.IDictionary<string, string> config = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfileIdentity identity = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfile ManagedClusterAgentPoolProfile(int? count = default(int?), string vmSize = null, int? osDiskSizeInGB = default(int?), Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType? osDiskType = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType?), Azure.ResourceManager.ContainerService.Models.KubeletDiskType? kubeletDiskType = default(Azure.ResourceManager.ContainerService.Models.KubeletDiskType?), Azure.ResourceManager.ContainerService.Models.WorkloadRuntime? workloadRuntime = default(Azure.ResourceManager.ContainerService.Models.WorkloadRuntime?), string messageOfTheDay = null, Azure.Core.ResourceIdentifier vnetSubnetId = null, Azure.Core.ResourceIdentifier podSubnetId = null, int? maxPods = default(int?), Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType? osType = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType?), Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku? osSku = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku?), int? maxCount = default(int?), int? minCount = default(int?), bool? enableAutoScaling = default(bool?), Azure.ResourceManager.ContainerService.Models.ScaleDownMode? scaleDownMode = default(Azure.ResourceManager.ContainerService.Models.ScaleDownMode?), Azure.ResourceManager.ContainerService.Models.AgentPoolType? agentPoolType = default(Azure.ResourceManager.ContainerService.Models.AgentPoolType?), Azure.ResourceManager.ContainerService.Models.AgentPoolMode? mode = default(Azure.ResourceManager.ContainerService.Models.AgentPoolMode?), string orchestratorVersion = null, string currentOrchestratorVersion = null, string nodeImageVersion = null, string upgradeMaxSurge = null, string provisioningState = null, Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode? powerStateCode = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode?), System.Collections.Generic.IEnumerable<string> availabilityZones = null, bool? enableNodePublicIP = default(bool?), bool? enableCustomCATrust = default(bool?), Azure.Core.ResourceIdentifier nodePublicIPPrefixId = null, Azure.ResourceManager.ContainerService.Models.ScaleSetPriority? scaleSetPriority = default(Azure.ResourceManager.ContainerService.Models.ScaleSetPriority?), Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy? scaleSetEvictionPolicy = default(Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy?), float? spotMaxPrice = default(float?), System.Collections.Generic.IDictionary<string, string> tags = null, System.Collections.Generic.IDictionary<string, string> nodeLabels = null, System.Collections.Generic.IEnumerable<string> nodeTaints = null, Azure.Core.ResourceIdentifier proximityPlacementGroupId = null, Azure.ResourceManager.ContainerService.Models.KubeletConfig kubeletConfig = null, Azure.ResourceManager.ContainerService.Models.LinuxOSConfig linuxOSConfig = null, bool? enableEncryptionAtHost = default(bool?), bool? enableUltraSsd = default(bool?), bool? enableFips = default(bool?), Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile? gpuInstanceProfile = default(Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile?), Azure.Core.ResourceIdentifier creationDataSourceResourceId = null, Azure.Core.ResourceIdentifier capacityReservationGroupId = null, Azure.Core.ResourceIdentifier hostGroupId = null, bool? disableOutboundNat = default(bool?), Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkProfile networkProfile = null, string name = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfileProperties ManagedClusterAgentPoolProfileProperties(int? count = default(int?), string vmSize = null, int? osDiskSizeInGB = default(int?), Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType? osDiskType = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType?), Azure.ResourceManager.ContainerService.Models.KubeletDiskType? kubeletDiskType = default(Azure.ResourceManager.ContainerService.Models.KubeletDiskType?), Azure.ResourceManager.ContainerService.Models.WorkloadRuntime? workloadRuntime = default(Azure.ResourceManager.ContainerService.Models.WorkloadRuntime?), string messageOfTheDay = null, Azure.Core.ResourceIdentifier vnetSubnetId = null, Azure.Core.ResourceIdentifier podSubnetId = null, int? maxPods = default(int?), Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType? osType = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType?), Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku? osSku = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku?), int? maxCount = default(int?), int? minCount = default(int?), bool? enableAutoScaling = default(bool?), Azure.ResourceManager.ContainerService.Models.ScaleDownMode? scaleDownMode = default(Azure.ResourceManager.ContainerService.Models.ScaleDownMode?), Azure.ResourceManager.ContainerService.Models.AgentPoolType? agentPoolType = default(Azure.ResourceManager.ContainerService.Models.AgentPoolType?), Azure.ResourceManager.ContainerService.Models.AgentPoolMode? mode = default(Azure.ResourceManager.ContainerService.Models.AgentPoolMode?), string orchestratorVersion = null, string currentOrchestratorVersion = null, string nodeImageVersion = null, string upgradeMaxSurge = null, string provisioningState = null, Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode? powerStateCode = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode?), System.Collections.Generic.IEnumerable<string> availabilityZones = null, bool? enableNodePublicIP = default(bool?), bool? enableCustomCATrust = default(bool?), Azure.Core.ResourceIdentifier nodePublicIPPrefixId = null, Azure.ResourceManager.ContainerService.Models.ScaleSetPriority? scaleSetPriority = default(Azure.ResourceManager.ContainerService.Models.ScaleSetPriority?), Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy? scaleSetEvictionPolicy = default(Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy?), float? spotMaxPrice = default(float?), System.Collections.Generic.IDictionary<string, string> tags = null, System.Collections.Generic.IDictionary<string, string> nodeLabels = null, System.Collections.Generic.IEnumerable<string> nodeTaints = null, Azure.Core.ResourceIdentifier proximityPlacementGroupId = null, Azure.ResourceManager.ContainerService.Models.KubeletConfig kubeletConfig = null, Azure.ResourceManager.ContainerService.Models.LinuxOSConfig linuxOSConfig = null, bool? enableEncryptionAtHost = default(bool?), bool? enableUltraSsd = default(bool?), bool? enableFips = default(bool?), Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile? gpuInstanceProfile = default(Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile?), Azure.Core.ResourceIdentifier creationDataSourceResourceId = null, Azure.Core.ResourceIdentifier capacityReservationGroupId = null, Azure.Core.ResourceIdentifier hostGroupId = null, bool? disableOutboundNat = default(bool?), Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkProfile networkProfile = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterCredential ManagedClusterCredential(string name = null, byte[] value = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterCredentials ManagedClusterCredentials(System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredential> kubeconfigs = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfile ManagedClusterGuardrailsProfile(System.Collections.Generic.IEnumerable<string> systemExcludedNamespaces = null, string version = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfileLevel level = default(Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfileLevel), System.Collections.Generic.IEnumerable<string> excludedNamespaces = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterHttpProxyConfig ManagedClusterHttpProxyConfig(string httpProxy = null, string httpsProxy = null, System.Collections.Generic.IEnumerable<string> noProxy = null, System.Collections.Generic.IEnumerable<string> effectiveNoProxy = null, string trustedCA = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterOidcIssuerProfile ManagedClusterOidcIssuerProfile(string issuerUriInfo = null, bool? isEnabled = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentity ManagedClusterPodIdentity(string name = null, string @namespace = null, string bindingSelector = null, Azure.ResourceManager.ContainerService.Models.ContainerServiceUserAssignedIdentity identity = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProvisioningState? provisioningState = default(Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProvisioningState?), Azure.ResponseError errorDetail = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfile ManagedClusterPoolUpgradeProfile(string kubernetesVersion = null, string name = null, Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType osType = default(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType), System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfileUpgradesItem> upgrades = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfileUpgradesItem ManagedClusterPoolUpgradeProfileUpgradesItem(string kubernetesVersion = null, bool? isPreview = default(bool?)) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterPropertiesForSnapshot ManagedClusterPropertiesForSnapshot(string kubernetesVersion = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterSku sku = null, bool? enableRbac = default(bool?), Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileForSnapshot networkProfile = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandContent ManagedClusterRunCommandContent(string command = null, string context = null, string clusterToken = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandResult ManagedClusterRunCommandResult(string id = null, string provisioningState = null, int? exitCode = default(int?), System.DateTimeOffset? startedOn = default(System.DateTimeOffset?), System.DateTimeOffset? finishedOn = default(System.DateTimeOffset?), string logs = null, string reason = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.ManagedClusterSnapshotData ManagedClusterSnapshotData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.Core.ResourceIdentifier creationDataSourceResourceId = null, Azure.ResourceManager.ContainerService.Models.SnapshotType? snapshotType = default(Azure.ResourceManager.ContainerService.Models.SnapshotType?), Azure.ResourceManager.ContainerService.Models.ManagedClusterPropertiesForSnapshot managedClusterPropertiesReadOnly = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.ManagedClusterUpgradeProfileData ManagedClusterUpgradeProfileData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfile controlPlaneProfile = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfile> agentPoolProfiles = null) { throw null; }
        public static Azure.ResourceManager.ContainerService.OSOptionProfileData OSOptionProfileData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.Models.ContainerServiceOSOptionProperty> osOptionPropertyList = null) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AutoScaleExpander : System.IEquatable<Azure.ResourceManager.ContainerService.Models.AutoScaleExpander>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AutoScaleExpander(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.AutoScaleExpander LeastWaste { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.AutoScaleExpander MostPods { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.AutoScaleExpander Priority { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.AutoScaleExpander Random { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.AutoScaleExpander other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.AutoScaleExpander left, Azure.ResourceManager.ContainerService.Models.AutoScaleExpander right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.AutoScaleExpander (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.AutoScaleExpander left, Azure.ResourceManager.ContainerService.Models.AutoScaleExpander right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerServiceDateSpan : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceDateSpan>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceDateSpan>
    {
        public ContainerServiceDateSpan(System.DateTimeOffset start, System.DateTimeOffset end) { }
        public System.DateTimeOffset End { get { throw null; } set { } }
        public System.DateTimeOffset Start { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceDateSpan System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceDateSpan>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceDateSpan>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceDateSpan System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceDateSpan>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceDateSpan>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceDateSpan>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceEndpointDependency : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDependency>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDependency>
    {
        internal ContainerServiceEndpointDependency() { }
        public string DomainName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDetail> EndpointDetails { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDependency System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDependency>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDependency>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDependency System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDependency>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDependency>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDependency>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceEndpointDetail : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDetail>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDetail>
    {
        internal ContainerServiceEndpointDetail() { }
        public string Description { get { throw null; } }
        public System.Net.IPAddress IPAddress { get { throw null; } }
        public int? Port { get { throw null; } }
        public string Protocol { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDetail System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDetail>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDetail>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDetail System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDetail>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDetail>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDetail>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceFleetCredentialResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResult>
    {
        internal ContainerServiceFleetCredentialResult() { }
        public string Name { get { throw null; } }
        public byte[] Value { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResult>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResult>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResult>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceFleetCredentialResults : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResults>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResults>
    {
        internal ContainerServiceFleetCredentialResults() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResult> Kubeconfigs { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResults System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResults>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResults>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResults System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResults>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResults>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetCredentialResults>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceFleetHubProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetHubProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetHubProfile>
    {
        public ContainerServiceFleetHubProfile() { }
        public string DnsPrefix { get { throw null; } set { } }
        public string Fqdn { get { throw null; } }
        public string KubernetesVersion { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetHubProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetHubProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetHubProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetHubProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetHubProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetHubProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetHubProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceFleetMemberProvisioningState : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetMemberProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceFleetMemberProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetMemberProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetMemberProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetMemberProvisioningState Joining { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetMemberProvisioningState Leaving { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetMemberProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetMemberProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetMemberProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetMemberProvisioningState left, Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetMemberProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetMemberProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetMemberProvisioningState left, Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetMemberProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerServiceFleetPatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetPatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetPatch>
    {
        public ContainerServiceFleetPatch() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetPatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetPatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetPatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetPatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetPatch>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetPatch>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetPatch>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceFleetProvisioningState : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceFleetProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetProvisioningState left, Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetProvisioningState left, Azure.ResourceManager.ContainerService.Models.ContainerServiceFleetProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerServiceIPTag : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceIPTag>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceIPTag>
    {
        public ContainerServiceIPTag() { }
        public string IPTagType { get { throw null; } set { } }
        public string Tag { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceIPTag System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceIPTag>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceIPTag>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceIPTag System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceIPTag>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceIPTag>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceIPTag>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceLinuxProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceLinuxProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceLinuxProfile>
    {
        public ContainerServiceLinuxProfile(string adminUsername, Azure.ResourceManager.ContainerService.Models.ContainerServiceSshConfiguration ssh) { }
        public string AdminUsername { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshPublicKey> SshPublicKeys { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceLinuxProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceLinuxProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceLinuxProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceLinuxProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceLinuxProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceLinuxProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceLinuxProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceLoadBalancerSku : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceLoadBalancerSku>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceLoadBalancerSku(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceLoadBalancerSku Basic { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceLoadBalancerSku Standard { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceLoadBalancerSku other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceLoadBalancerSku left, Azure.ResourceManager.ContainerService.Models.ContainerServiceLoadBalancerSku right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceLoadBalancerSku (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceLoadBalancerSku left, Azure.ResourceManager.ContainerService.Models.ContainerServiceLoadBalancerSku right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerServiceMaintenanceAbsoluteMonthlySchedule : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceAbsoluteMonthlySchedule>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceAbsoluteMonthlySchedule>
    {
        public ContainerServiceMaintenanceAbsoluteMonthlySchedule(int intervalMonths, int dayOfMonth) { }
        public int DayOfMonth { get { throw null; } set { } }
        public int IntervalMonths { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceAbsoluteMonthlySchedule System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceAbsoluteMonthlySchedule>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceAbsoluteMonthlySchedule>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceAbsoluteMonthlySchedule System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceAbsoluteMonthlySchedule>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceAbsoluteMonthlySchedule>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceAbsoluteMonthlySchedule>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceMaintenanceRelativeMonthlySchedule : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlySchedule>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlySchedule>
    {
        public ContainerServiceMaintenanceRelativeMonthlySchedule(int intervalMonths, Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex weekIndex, Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay dayOfWeek) { }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay DayOfWeek { get { throw null; } set { } }
        public int IntervalMonths { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex WeekIndex { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlySchedule System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlySchedule>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlySchedule>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlySchedule System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlySchedule>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlySchedule>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlySchedule>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex First { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex Fourth { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex Last { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex Second { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex Third { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex left, Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex left, Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlyScheduleWeekIndex right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerServiceMaintenanceSchedule : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceSchedule>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceSchedule>
    {
        public ContainerServiceMaintenanceSchedule() { }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceAbsoluteMonthlySchedule AbsoluteMonthly { get { throw null; } set { } }
        public int? DailyIntervalDays { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceRelativeMonthlySchedule RelativeMonthly { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWeeklySchedule Weekly { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceSchedule System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceSchedule>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceSchedule>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceSchedule System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceSchedule>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceSchedule>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceSchedule>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceMaintenanceWeeklySchedule : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWeeklySchedule>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWeeklySchedule>
    {
        public ContainerServiceMaintenanceWeeklySchedule(int intervalWeeks, Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay dayOfWeek) { }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay DayOfWeek { get { throw null; } set { } }
        public int IntervalWeeks { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWeeklySchedule System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWeeklySchedule>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWeeklySchedule>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWeeklySchedule System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWeeklySchedule>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWeeklySchedule>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWeeklySchedule>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceMaintenanceWindow : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWindow>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWindow>
    {
        public ContainerServiceMaintenanceWindow(Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceSchedule schedule, int durationHours, string startTime) { }
        public int DurationHours { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerService.Models.ContainerServiceDateSpan> NotAllowedDates { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceSchedule Schedule { get { throw null; } set { } }
        public string StartDate { get { throw null; } set { } }
        public string StartTime { get { throw null; } set { } }
        public string UtcOffset { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWindow System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWindow>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWindow>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWindow System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWindow>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWindow>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceMaintenanceWindow>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceNetworkMode : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceNetworkMode(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkMode Bridge { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkMode Transparent { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkMode left, Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkMode left, Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceNetworkPlugin : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPlugin>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceNetworkPlugin(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPlugin Azure { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPlugin Kubenet { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPlugin None { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPlugin other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPlugin left, Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPlugin right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPlugin (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPlugin left, Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPlugin right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceNetworkPluginMode : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPluginMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceNetworkPluginMode(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPluginMode Overlay { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPluginMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPluginMode left, Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPluginMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPluginMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPluginMode left, Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPluginMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceNetworkPolicy : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPolicy>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceNetworkPolicy(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPolicy Azure { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPolicy Calico { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPolicy other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPolicy left, Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPolicy right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPolicy (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPolicy left, Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPolicy right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerServiceNetworkProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfile>
    {
        public ContainerServiceNetworkProfile() { }
        public string DnsServiceIP { get { throw null; } set { } }
        public string DockerBridgeCidr { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.EbpfDataplane? EbpfDataplane { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerService.Models.IPFamily> IPFamilies { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyConfig KubeProxyConfig { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfile LoadBalancerProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceLoadBalancerSku? LoadBalancerSku { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterNatGatewayProfile NatGatewayProfile { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkMode? NetworkMode { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPlugin? NetworkPlugin { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPluginMode? NetworkPluginMode { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPolicy? NetworkPolicy { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundType? OutboundType { get { throw null; } set { } }
        public string PodCidr { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> PodCidrs { get { throw null; } }
        public string ServiceCidr { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> ServiceCidrs { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceNetworkProfileForSnapshot : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileForSnapshot>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileForSnapshot>
    {
        internal ContainerServiceNetworkProfileForSnapshot() { }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceLoadBalancerSku? LoadBalancerSku { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkMode? NetworkMode { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPlugin? NetworkPlugin { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPluginMode? NetworkPluginMode { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkPolicy? NetworkPolicy { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileForSnapshot System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileForSnapshot>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileForSnapshot>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileForSnapshot System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileForSnapshot>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileForSnapshot>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileForSnapshot>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceNetworkProfileKubeProxyConfig : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyConfig>
    {
        public ContainerServiceNetworkProfileKubeProxyConfig() { }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSConfig IPVSConfig { get { throw null; } set { } }
        public bool? IsEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyMode? Mode { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyConfig System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyConfig System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyConfig>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyConfig>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyConfig>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceNetworkProfileKubeProxyIPVSConfig : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSConfig>
    {
        public ContainerServiceNetworkProfileKubeProxyIPVSConfig() { }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSScheduler? Scheduler { get { throw null; } set { } }
        public int? TcpFinTimeoutSeconds { get { throw null; } set { } }
        public int? TcpTimeoutSeconds { get { throw null; } set { } }
        public int? UdpTimeoutSeconds { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSConfig System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSConfig System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSConfig>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSConfig>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSConfig>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceNetworkProfileKubeProxyIPVSScheduler : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSScheduler>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceNetworkProfileKubeProxyIPVSScheduler(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSScheduler LeastConnection { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSScheduler RoundRobin { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSScheduler other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSScheduler left, Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSScheduler right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSScheduler (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSScheduler left, Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyIPVSScheduler right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceNetworkProfileKubeProxyMode : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceNetworkProfileKubeProxyMode(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyMode IPTables { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyMode IPVS { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyMode left, Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyMode left, Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileKubeProxyMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceOSDiskType : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceOSDiskType(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType Ephemeral { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType Managed { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType left, Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType left, Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerServiceOSOptionProperty : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceOSOptionProperty>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceOSOptionProperty>
    {
        internal ContainerServiceOSOptionProperty() { }
        public bool EnableFipsImage { get { throw null; } }
        public string OSType { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceOSOptionProperty System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceOSOptionProperty>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceOSOptionProperty>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceOSOptionProperty System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceOSOptionProperty>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceOSOptionProperty>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceOSOptionProperty>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceOSSku : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceOSSku(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku CblMariner { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku Mariner { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku Ubuntu { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku Windows2019 { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku Windows2022 { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku left, Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku left, Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceOSType : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceOSType(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType Linux { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType Windows { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType left, Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType left, Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerServiceOutboundEnvironmentEndpoint : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundEnvironmentEndpoint>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundEnvironmentEndpoint>
    {
        internal ContainerServiceOutboundEnvironmentEndpoint() { }
        public string Category { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerService.Models.ContainerServiceEndpointDependency> Endpoints { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundEnvironmentEndpoint System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundEnvironmentEndpoint>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundEnvironmentEndpoint>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundEnvironmentEndpoint System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundEnvironmentEndpoint>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundEnvironmentEndpoint>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundEnvironmentEndpoint>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceOutboundType : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceOutboundType(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundType LoadBalancer { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundType ManagedNatGateway { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundType UserAssignedNatGateway { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundType UserDefinedRouting { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundType left, Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundType left, Azure.ResourceManager.ContainerService.Models.ContainerServiceOutboundType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServicePrivateEndpointConnectionProvisioningState : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateEndpointConnectionProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServicePrivateEndpointConnectionProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateEndpointConnectionProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateEndpointConnectionProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateEndpointConnectionProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateEndpointConnectionProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateEndpointConnectionProvisioningState Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateEndpointConnectionProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateEndpointConnectionProvisioningState left, Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateEndpointConnectionProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateEndpointConnectionProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateEndpointConnectionProvisioningState left, Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateEndpointConnectionProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerServicePrivateLinkResourceData : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData>
    {
        public ContainerServicePrivateLinkResourceData() { }
        public string GroupId { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier Id { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier PrivateLinkServiceId { get { throw null; } }
        public System.Collections.Generic.IList<string> RequiredMembers { get { throw null; } }
        public Azure.Core.ResourceType? ResourceType { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkResourceData>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServicePrivateLinkServiceConnectionState : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionState>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionState>
    {
        public ContainerServicePrivateLinkServiceConnectionState() { }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionStatus? Status { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionState System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionState>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionState>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionState System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionState>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionState>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionState>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServicePrivateLinkServiceConnectionStatus : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServicePrivateLinkServiceConnectionStatus(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionStatus Approved { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionStatus Disconnected { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionStatus Rejected { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionStatus left, Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionStatus left, Azure.ResourceManager.ContainerService.Models.ContainerServicePrivateLinkServiceConnectionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServicePublicNetworkAccess : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServicePublicNetworkAccess>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServicePublicNetworkAccess(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServicePublicNetworkAccess Disabled { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServicePublicNetworkAccess Enabled { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServicePublicNetworkAccess SecuredByPerimeter { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServicePublicNetworkAccess other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServicePublicNetworkAccess left, Azure.ResourceManager.ContainerService.Models.ContainerServicePublicNetworkAccess right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServicePublicNetworkAccess (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServicePublicNetworkAccess left, Azure.ResourceManager.ContainerService.Models.ContainerServicePublicNetworkAccess right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerServiceSshConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshConfiguration>
    {
        public ContainerServiceSshConfiguration(System.Collections.Generic.IEnumerable<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshPublicKey> publicKeys) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshPublicKey> PublicKeys { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceSshConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceSshConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshConfiguration>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshConfiguration>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshConfiguration>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceSshPublicKey : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshPublicKey>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshPublicKey>
    {
        public ContainerServiceSshPublicKey(string keyData) { }
        public string KeyData { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceSshPublicKey System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshPublicKey>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshPublicKey>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceSshPublicKey System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshPublicKey>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshPublicKey>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceSshPublicKey>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceStateCode : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceStateCode(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode Running { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode Stopped { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode left, Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode left, Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerServiceTagsObject : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTagsObject>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTagsObject>
    {
        public ContainerServiceTagsObject() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceTagsObject System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTagsObject>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTagsObject>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceTagsObject System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTagsObject>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTagsObject>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTagsObject>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceTimeInWeek : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeInWeek>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeInWeek>
    {
        public ContainerServiceTimeInWeek() { }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay? Day { get { throw null; } set { } }
        public System.Collections.Generic.IList<int> HourSlots { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeInWeek System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeInWeek>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeInWeek>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeInWeek System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeInWeek>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeInWeek>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeInWeek>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceTimeSpan : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeSpan>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeSpan>
    {
        public ContainerServiceTimeSpan() { }
        public System.DateTimeOffset? EndOn { get { throw null; } set { } }
        public System.DateTimeOffset? StartOn { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeSpan System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeSpan>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeSpan>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeSpan System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeSpan>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeSpan>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTimeSpan>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceTrustedAccessRole : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRole>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRole>
    {
        internal ContainerServiceTrustedAccessRole() { }
        public string Name { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleRule> Rules { get { throw null; } }
        public string SourceResourceType { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRole System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRole>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRole>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRole System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRole>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRole>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRole>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceTrustedAccessRoleBindingProvisioningState : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleBindingProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceTrustedAccessRoleBindingProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleBindingProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleBindingProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleBindingProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleBindingProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleBindingProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleBindingProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleBindingProvisioningState left, Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleBindingProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleBindingProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleBindingProvisioningState left, Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleBindingProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ContainerServiceTrustedAccessRoleRule : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleRule>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleRule>
    {
        internal ContainerServiceTrustedAccessRoleRule() { }
        public System.Collections.Generic.IReadOnlyList<string> ApiGroups { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> NonResourceUrls { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> ResourceNames { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Resources { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Verbs { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleRule System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleRule>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleRule>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleRule System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleRule>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleRule>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceTrustedAccessRoleRule>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ContainerServiceUserAssignedIdentity : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceUserAssignedIdentity>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceUserAssignedIdentity>
    {
        public ContainerServiceUserAssignedIdentity() { }
        public System.Guid? ClientId { get { throw null; } set { } }
        public System.Guid? ObjectId { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ResourceId { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceUserAssignedIdentity System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceUserAssignedIdentity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceUserAssignedIdentity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ContainerServiceUserAssignedIdentity System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceUserAssignedIdentity>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceUserAssignedIdentity>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ContainerServiceUserAssignedIdentity>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContainerServiceWeekDay : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContainerServiceWeekDay(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay Friday { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay Monday { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay Saturday { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay Sunday { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay Thursday { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay Tuesday { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay Wednesday { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay left, Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay left, Azure.ResourceManager.ContainerService.Models.ContainerServiceWeekDay right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EbpfDataplane : System.IEquatable<Azure.ResourceManager.ContainerService.Models.EbpfDataplane>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EbpfDataplane(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.EbpfDataplane Cilium { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.EbpfDataplane other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.EbpfDataplane left, Azure.ResourceManager.ContainerService.Models.EbpfDataplane right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.EbpfDataplane (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.EbpfDataplane left, Azure.ResourceManager.ContainerService.Models.EbpfDataplane right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct GpuInstanceProfile : System.IEquatable<Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public GpuInstanceProfile(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile Mig1G { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile Mig2G { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile Mig3G { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile Mig4G { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile Mig7G { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile left, Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile left, Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IPFamily : System.IEquatable<Azure.ResourceManager.ContainerService.Models.IPFamily>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IPFamily(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.IPFamily IPv4 { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.IPFamily IPv6 { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.IPFamily other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.IPFamily left, Azure.ResourceManager.ContainerService.Models.IPFamily right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.IPFamily (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.IPFamily left, Azure.ResourceManager.ContainerService.Models.IPFamily right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct KubeConfigFormat : System.IEquatable<Azure.ResourceManager.ContainerService.Models.KubeConfigFormat>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public KubeConfigFormat(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.KubeConfigFormat Azure { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.KubeConfigFormat Exec { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.KubeConfigFormat other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.KubeConfigFormat left, Azure.ResourceManager.ContainerService.Models.KubeConfigFormat right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.KubeConfigFormat (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.KubeConfigFormat left, Azure.ResourceManager.ContainerService.Models.KubeConfigFormat right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class KubeletConfig : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.KubeletConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.KubeletConfig>
    {
        public KubeletConfig() { }
        public System.Collections.Generic.IList<string> AllowedUnsafeSysctls { get { throw null; } }
        public int? ContainerLogMaxFiles { get { throw null; } set { } }
        public int? ContainerLogMaxSizeInMB { get { throw null; } set { } }
        public string CpuCfsQuotaPeriod { get { throw null; } set { } }
        public string CpuManagerPolicy { get { throw null; } set { } }
        public bool? FailStartWithSwapOn { get { throw null; } set { } }
        public int? ImageGcHighThreshold { get { throw null; } set { } }
        public int? ImageGcLowThreshold { get { throw null; } set { } }
        public bool? IsCpuCfsQuotaEnabled { get { throw null; } set { } }
        public int? PodMaxPids { get { throw null; } set { } }
        public string TopologyManagerPolicy { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.KubeletConfig System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.KubeletConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.KubeletConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.KubeletConfig System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.KubeletConfig>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.KubeletConfig>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.KubeletConfig>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct KubeletDiskType : System.IEquatable<Azure.ResourceManager.ContainerService.Models.KubeletDiskType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public KubeletDiskType(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.KubeletDiskType OS { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.KubeletDiskType Temporary { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.KubeletDiskType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.KubeletDiskType left, Azure.ResourceManager.ContainerService.Models.KubeletDiskType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.KubeletDiskType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.KubeletDiskType left, Azure.ResourceManager.ContainerService.Models.KubeletDiskType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LinuxOSConfig : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.LinuxOSConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.LinuxOSConfig>
    {
        public LinuxOSConfig() { }
        public int? SwapFileSizeInMB { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.SysctlConfig Sysctls { get { throw null; } set { } }
        public string TransparentHugePageDefrag { get { throw null; } set { } }
        public string TransparentHugePageEnabled { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.LinuxOSConfig System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.LinuxOSConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.LinuxOSConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.LinuxOSConfig System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.LinuxOSConfig>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.LinuxOSConfig>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.LinuxOSConfig>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterAadProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAadProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAadProfile>
    {
        public ManagedClusterAadProfile() { }
        public System.Collections.Generic.IList<System.Guid> AdminGroupObjectIds { get { throw null; } }
        public System.Guid? ClientAppId { get { throw null; } set { } }
        public bool? IsAzureRbacEnabled { get { throw null; } set { } }
        public bool? IsManagedAadEnabled { get { throw null; } set { } }
        public System.Guid? ServerAppId { get { throw null; } set { } }
        public string ServerAppSecret { get { throw null; } set { } }
        public System.Guid? TenantId { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterAadProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAadProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAadProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterAadProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAadProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAadProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAadProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterAccessProfile : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAccessProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAccessProfile>
    {
        public ManagedClusterAccessProfile(Azure.Core.AzureLocation location) { }
        public byte[] KubeConfig { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterAccessProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAccessProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAccessProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterAccessProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAccessProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAccessProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAccessProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterAddonProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfile>
    {
        public ManagedClusterAddonProfile(bool isEnabled) { }
        public System.Collections.Generic.IDictionary<string, string> Config { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfileIdentity Identity { get { throw null; } }
        public bool IsEnabled { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterAddonProfileIdentity : Azure.ResourceManager.ContainerService.Models.ContainerServiceUserAssignedIdentity, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfileIdentity>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfileIdentity>
    {
        public ManagedClusterAddonProfileIdentity() { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfileIdentity System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfileIdentity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfileIdentity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfileIdentity System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfileIdentity>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfileIdentity>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAddonProfileIdentity>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterAgentPoolProfile : Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfileProperties, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfile>
    {
        public ManagedClusterAgentPoolProfile(string name) { }
        public string Name { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterAgentPoolProfileProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfileProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfileProperties>
    {
        public ManagedClusterAgentPoolProfileProperties() { }
        public Azure.ResourceManager.ContainerService.Models.AgentPoolType? AgentPoolType { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> AvailabilityZones { get { throw null; } }
        public Azure.Core.ResourceIdentifier CapacityReservationGroupId { get { throw null; } set { } }
        public int? Count { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier CreationDataSourceResourceId { get { throw null; } set { } }
        public string CurrentOrchestratorVersion { get { throw null; } }
        public bool? DisableOutboundNat { get { throw null; } set { } }
        public bool? EnableAutoScaling { get { throw null; } set { } }
        public bool? EnableCustomCATrust { get { throw null; } set { } }
        public bool? EnableEncryptionAtHost { get { throw null; } set { } }
        public bool? EnableFips { get { throw null; } set { } }
        public bool? EnableNodePublicIP { get { throw null; } set { } }
        public bool? EnableUltraSsd { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.GpuInstanceProfile? GpuInstanceProfile { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier HostGroupId { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.KubeletConfig KubeletConfig { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.KubeletDiskType? KubeletDiskType { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.LinuxOSConfig LinuxOSConfig { get { throw null; } set { } }
        public int? MaxCount { get { throw null; } set { } }
        public int? MaxPods { get { throw null; } set { } }
        public string MessageOfTheDay { get { throw null; } set { } }
        public int? MinCount { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.AgentPoolMode? Mode { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.AgentPoolNetworkProfile NetworkProfile { get { throw null; } set { } }
        public string NodeImageVersion { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> NodeLabels { get { throw null; } }
        public Azure.Core.ResourceIdentifier NodePublicIPPrefixId { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> NodeTaints { get { throw null; } }
        public string OrchestratorVersion { get { throw null; } set { } }
        public int? OSDiskSizeInGB { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceOSDiskType? OSDiskType { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceOSSku? OSSku { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType? OSType { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier PodSubnetId { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceStateCode? PowerStateCode { get { throw null; } set { } }
        public string ProvisioningState { get { throw null; } }
        public Azure.Core.ResourceIdentifier ProximityPlacementGroupId { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ScaleDownMode? ScaleDownMode { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy? ScaleSetEvictionPolicy { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ScaleSetPriority? ScaleSetPriority { get { throw null; } set { } }
        public float? SpotMaxPrice { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        public string UpgradeMaxSurge { get { throw null; } set { } }
        public string VmSize { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier VnetSubnetId { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.WorkloadRuntime? WorkloadRuntime { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfileProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfileProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfileProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfileProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfileProperties>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfileProperties>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAgentPoolProfileProperties>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterApiServerAccessProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterApiServerAccessProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterApiServerAccessProfile>
    {
        public ManagedClusterApiServerAccessProfile() { }
        public System.Collections.Generic.IList<string> AuthorizedIPRanges { get { throw null; } }
        public bool? DisableRunCommand { get { throw null; } set { } }
        public bool? EnablePrivateCluster { get { throw null; } set { } }
        public bool? EnablePrivateClusterPublicFqdn { get { throw null; } set { } }
        public bool? EnableVnetIntegration { get { throw null; } set { } }
        public string PrivateDnsZone { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier SubnetId { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterApiServerAccessProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterApiServerAccessProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterApiServerAccessProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterApiServerAccessProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterApiServerAccessProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterApiServerAccessProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterApiServerAccessProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterAutoScalerProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoScalerProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoScalerProfile>
    {
        public ManagedClusterAutoScalerProfile() { }
        public string BalanceSimilarNodeGroups { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.AutoScaleExpander? Expander { get { throw null; } set { } }
        public string MaxEmptyBulkDelete { get { throw null; } set { } }
        public string MaxGracefulTerminationSec { get { throw null; } set { } }
        public string MaxNodeProvisionTime { get { throw null; } set { } }
        public string MaxTotalUnreadyPercentage { get { throw null; } set { } }
        public string NewPodScaleUpDelay { get { throw null; } set { } }
        public string OkTotalUnreadyCount { get { throw null; } set { } }
        public string ScaleDownDelayAfterAdd { get { throw null; } set { } }
        public string ScaleDownDelayAfterDelete { get { throw null; } set { } }
        public string ScaleDownDelayAfterFailure { get { throw null; } set { } }
        public string ScaleDownUnneededTime { get { throw null; } set { } }
        public string ScaleDownUnreadyTime { get { throw null; } set { } }
        public string ScaleDownUtilizationThreshold { get { throw null; } set { } }
        public string ScanIntervalInSeconds { get { throw null; } set { } }
        public string SkipNodesWithLocalStorage { get { throw null; } set { } }
        public string SkipNodesWithSystemPods { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoScalerProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoScalerProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoScalerProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoScalerProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoScalerProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoScalerProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoScalerProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterAutoUpgradeProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoUpgradeProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoUpgradeProfile>
    {
        public ManagedClusterAutoUpgradeProfile() { }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeOSUpgradeChannel? NodeOSUpgradeChannel { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.UpgradeChannel? UpgradeChannel { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoUpgradeProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoUpgradeProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoUpgradeProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoUpgradeProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoUpgradeProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoUpgradeProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterAutoUpgradeProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterCredential : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredential>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredential>
    {
        internal ManagedClusterCredential() { }
        public string Name { get { throw null; } }
        public byte[] Value { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterCredential System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredential>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredential>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterCredential System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredential>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredential>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredential>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterCredentials : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredentials>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredentials>
    {
        internal ManagedClusterCredentials() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredential> Kubeconfigs { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterCredentials System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredentials>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredentials>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterCredentials System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredentials>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredentials>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterCredentials>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterGuardrailsProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfile>
    {
        public ManagedClusterGuardrailsProfile(string version, Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfileLevel level) { }
        public System.Collections.Generic.IList<string> ExcludedNamespaces { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfileLevel Level { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> SystemExcludedNamespaces { get { throw null; } }
        public string Version { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagedClusterGuardrailsProfileLevel : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfileLevel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagedClusterGuardrailsProfileLevel(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfileLevel Enforcement { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfileLevel Off { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfileLevel Warning { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfileLevel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfileLevel left, Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfileLevel right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfileLevel (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfileLevel left, Azure.ResourceManager.ContainerService.Models.ManagedClusterGuardrailsProfileLevel right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagedClusterHttpProxyConfig : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterHttpProxyConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterHttpProxyConfig>
    {
        public ManagedClusterHttpProxyConfig() { }
        public System.Collections.Generic.IReadOnlyList<string> EffectiveNoProxy { get { throw null; } }
        public string HttpProxy { get { throw null; } set { } }
        public string HttpsProxy { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> NoProxy { get { throw null; } }
        public string TrustedCA { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterHttpProxyConfig System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterHttpProxyConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterHttpProxyConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterHttpProxyConfig System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterHttpProxyConfig>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterHttpProxyConfig>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterHttpProxyConfig>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterIngressProfileWebAppRouting : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterIngressProfileWebAppRouting>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterIngressProfileWebAppRouting>
    {
        public ManagedClusterIngressProfileWebAppRouting() { }
        public Azure.Core.ResourceIdentifier DnsZoneResourceId { get { throw null; } set { } }
        public bool? IsEnabled { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterIngressProfileWebAppRouting System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterIngressProfileWebAppRouting>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterIngressProfileWebAppRouting>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterIngressProfileWebAppRouting System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterIngressProfileWebAppRouting>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterIngressProfileWebAppRouting>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterIngressProfileWebAppRouting>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagedClusterKeyVaultNetworkAccessType : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ManagedClusterKeyVaultNetworkAccessType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagedClusterKeyVaultNetworkAccessType(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterKeyVaultNetworkAccessType Private { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterKeyVaultNetworkAccessType Public { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ManagedClusterKeyVaultNetworkAccessType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ManagedClusterKeyVaultNetworkAccessType left, Azure.ResourceManager.ContainerService.Models.ManagedClusterKeyVaultNetworkAccessType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ManagedClusterKeyVaultNetworkAccessType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ManagedClusterKeyVaultNetworkAccessType left, Azure.ResourceManager.ContainerService.Models.ManagedClusterKeyVaultNetworkAccessType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagedClusterLoadBalancerBackendPoolType : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerBackendPoolType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagedClusterLoadBalancerBackendPoolType(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerBackendPoolType NodeIP { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerBackendPoolType NodeIPConfiguration { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerBackendPoolType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerBackendPoolType left, Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerBackendPoolType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerBackendPoolType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerBackendPoolType left, Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerBackendPoolType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagedClusterLoadBalancerProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfile>
    {
        public ManagedClusterLoadBalancerProfile() { }
        public int? AllocatedOutboundPorts { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerBackendPoolType? BackendPoolType { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.WritableSubResource> EffectiveOutboundIPs { get { throw null; } }
        public bool? EnableMultipleStandardLoadBalancers { get { throw null; } set { } }
        public int? IdleTimeoutInMinutes { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfileManagedOutboundIPs ManagedOutboundIPs { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.WritableSubResource> OutboundPublicIPPrefixes { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.WritableSubResource> OutboundPublicIPs { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterLoadBalancerProfileManagedOutboundIPs : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfileManagedOutboundIPs>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfileManagedOutboundIPs>
    {
        public ManagedClusterLoadBalancerProfileManagedOutboundIPs() { }
        public int? Count { get { throw null; } set { } }
        public int? CountIPv6 { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfileManagedOutboundIPs System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfileManagedOutboundIPs>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfileManagedOutboundIPs>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfileManagedOutboundIPs System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfileManagedOutboundIPs>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfileManagedOutboundIPs>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterLoadBalancerProfileManagedOutboundIPs>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterMonitorProfileKubeStateMetrics : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileKubeStateMetrics>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileKubeStateMetrics>
    {
        public ManagedClusterMonitorProfileKubeStateMetrics() { }
        public string MetricAnnotationsAllowList { get { throw null; } set { } }
        public string MetricLabelsAllowlist { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileKubeStateMetrics System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileKubeStateMetrics>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileKubeStateMetrics>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileKubeStateMetrics System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileKubeStateMetrics>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileKubeStateMetrics>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileKubeStateMetrics>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterMonitorProfileMetrics : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileMetrics>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileMetrics>
    {
        public ManagedClusterMonitorProfileMetrics(bool isEnabled) { }
        public bool IsEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileKubeStateMetrics KubeStateMetrics { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileMetrics System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileMetrics>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileMetrics>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileMetrics System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileMetrics>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileMetrics>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterMonitorProfileMetrics>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterNatGatewayProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterNatGatewayProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterNatGatewayProfile>
    {
        public ManagedClusterNatGatewayProfile() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.Resources.Models.WritableSubResource> EffectiveOutboundIPs { get { throw null; } }
        public int? IdleTimeoutInMinutes { get { throw null; } set { } }
        public int? ManagedOutboundIPCount { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterNatGatewayProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterNatGatewayProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterNatGatewayProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterNatGatewayProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterNatGatewayProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterNatGatewayProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterNatGatewayProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagedClusterNodeOSUpgradeChannel : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeOSUpgradeChannel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagedClusterNodeOSUpgradeChannel(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeOSUpgradeChannel NodeImage { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeOSUpgradeChannel None { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeOSUpgradeChannel SecurityPatch { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeOSUpgradeChannel Unmanaged { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeOSUpgradeChannel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeOSUpgradeChannel left, Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeOSUpgradeChannel right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeOSUpgradeChannel (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeOSUpgradeChannel left, Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeOSUpgradeChannel right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagedClusterNodeResourceGroupRestrictionLevel : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeResourceGroupRestrictionLevel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagedClusterNodeResourceGroupRestrictionLevel(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeResourceGroupRestrictionLevel ReadOnly { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeResourceGroupRestrictionLevel Unrestricted { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeResourceGroupRestrictionLevel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeResourceGroupRestrictionLevel left, Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeResourceGroupRestrictionLevel right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeResourceGroupRestrictionLevel (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeResourceGroupRestrictionLevel left, Azure.ResourceManager.ContainerService.Models.ManagedClusterNodeResourceGroupRestrictionLevel right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagedClusterOidcIssuerProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterOidcIssuerProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterOidcIssuerProfile>
    {
        public ManagedClusterOidcIssuerProfile() { }
        public bool? IsEnabled { get { throw null; } set { } }
        public string IssuerUriInfo { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterOidcIssuerProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterOidcIssuerProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterOidcIssuerProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterOidcIssuerProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterOidcIssuerProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterOidcIssuerProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterOidcIssuerProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterPodIdentity : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentity>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentity>
    {
        public ManagedClusterPodIdentity(string name, string @namespace, Azure.ResourceManager.ContainerService.Models.ContainerServiceUserAssignedIdentity identity) { }
        public string BindingSelector { get { throw null; } set { } }
        public Azure.ResponseError ErrorDetail { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceUserAssignedIdentity Identity { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProvisioningState? ProvisioningState { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentity System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentity>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentity>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentity System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentity>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentity>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentity>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterPodIdentityException : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityException>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityException>
    {
        public ManagedClusterPodIdentityException(string name, string @namespace, System.Collections.Generic.IDictionary<string, string> podLabels) { }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> PodLabels { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityException System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityException>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityException>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityException System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityException>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityException>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityException>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterPodIdentityProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProfile>
    {
        public ManagedClusterPodIdentityProfile() { }
        public bool? AllowNetworkPluginKubenet { get { throw null; } set { } }
        public bool? IsEnabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentity> UserAssignedIdentities { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityException> UserAssignedIdentityExceptions { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagedClusterPodIdentityProvisioningState : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagedClusterPodIdentityProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProvisioningState Assigned { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProvisioningState left, Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProvisioningState left, Azure.ResourceManager.ContainerService.Models.ManagedClusterPodIdentityProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagedClusterPoolUpgradeProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfile>
    {
        internal ManagedClusterPoolUpgradeProfile() { }
        public string KubernetesVersion { get { throw null; } }
        public string Name { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceOSType OSType { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfileUpgradesItem> Upgrades { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterPoolUpgradeProfileUpgradesItem : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfileUpgradesItem>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfileUpgradesItem>
    {
        internal ManagedClusterPoolUpgradeProfileUpgradesItem() { }
        public bool? IsPreview { get { throw null; } }
        public string KubernetesVersion { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfileUpgradesItem System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfileUpgradesItem>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfileUpgradesItem>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfileUpgradesItem System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfileUpgradesItem>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfileUpgradesItem>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPoolUpgradeProfileUpgradesItem>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterPropertiesForSnapshot : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPropertiesForSnapshot>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPropertiesForSnapshot>
    {
        internal ManagedClusterPropertiesForSnapshot() { }
        public bool? EnableRbac { get { throw null; } }
        public string KubernetesVersion { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ContainerServiceNetworkProfileForSnapshot NetworkProfile { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterSku Sku { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterPropertiesForSnapshot System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPropertiesForSnapshot>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPropertiesForSnapshot>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterPropertiesForSnapshot System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPropertiesForSnapshot>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPropertiesForSnapshot>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterPropertiesForSnapshot>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterRunCommandContent : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandContent>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandContent>
    {
        public ManagedClusterRunCommandContent(string command) { }
        public string ClusterToken { get { throw null; } set { } }
        public string Command { get { throw null; } }
        public string Context { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandContent System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandContent>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandContent>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandContent System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandContent>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandContent>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandContent>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterRunCommandResult : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandResult>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandResult>
    {
        internal ManagedClusterRunCommandResult() { }
        public int? ExitCode { get { throw null; } }
        public System.DateTimeOffset? FinishedOn { get { throw null; } }
        public string Id { get { throw null; } }
        public string Logs { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public string Reason { get { throw null; } }
        public System.DateTimeOffset? StartedOn { get { throw null; } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandResult System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandResult>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandResult>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandResult System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandResult>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandResult>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterRunCommandResult>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterSecurityProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfile>
    {
        public ManagedClusterSecurityProfile() { }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileKeyVaultKms AzureKeyVaultKms { get { throw null; } set { } }
        public System.Collections.Generic.IList<byte[]> CustomCATrustCertificates { get { throw null; } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileDefender Defender { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileImageCleaner ImageCleaner { get { throw null; } set { } }
        public bool? IsNodeRestrictionEnabled { get { throw null; } set { } }
        public bool? IsWorkloadIdentityEnabled { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterSecurityProfileAzureDefender
    {
        public ManagedClusterSecurityProfileAzureDefender() { }
        public bool? IsEnabled { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier LogAnalyticsWorkspaceResourceId { get { throw null; } set { } }
    }
    public partial class ManagedClusterSecurityProfileDefender : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileDefender>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileDefender>
    {
        public ManagedClusterSecurityProfileDefender() { }
        public bool? IsSecurityMonitoringEnabled { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier LogAnalyticsWorkspaceResourceId { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileDefender System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileDefender>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileDefender>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileDefender System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileDefender>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileDefender>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileDefender>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterSecurityProfileImageCleaner : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileImageCleaner>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileImageCleaner>
    {
        public ManagedClusterSecurityProfileImageCleaner() { }
        public int? IntervalHours { get { throw null; } set { } }
        public bool? IsEnabled { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileImageCleaner System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileImageCleaner>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileImageCleaner>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileImageCleaner System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileImageCleaner>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileImageCleaner>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileImageCleaner>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterSecurityProfileKeyVaultKms : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileKeyVaultKms>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileKeyVaultKms>
    {
        public ManagedClusterSecurityProfileKeyVaultKms() { }
        public bool? IsEnabled { get { throw null; } set { } }
        public string KeyId { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterKeyVaultNetworkAccessType? KeyVaultNetworkAccess { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier KeyVaultResourceId { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileKeyVaultKms System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileKeyVaultKms>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileKeyVaultKms>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileKeyVaultKms System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileKeyVaultKms>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileKeyVaultKms>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSecurityProfileKeyVaultKms>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterServicePrincipalProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterServicePrincipalProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterServicePrincipalProfile>
    {
        public ManagedClusterServicePrincipalProfile(string clientId) { }
        public string ClientId { get { throw null; } set { } }
        public string Secret { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterServicePrincipalProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterServicePrincipalProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterServicePrincipalProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterServicePrincipalProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterServicePrincipalProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterServicePrincipalProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterServicePrincipalProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterSku : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSku>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSku>
    {
        public ManagedClusterSku() { }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuName? Name { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuTier? Tier { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterSku System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSku>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSku>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterSku System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSku>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSku>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterSku>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagedClusterSkuName : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagedClusterSkuName(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuName Basic { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuName left, Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuName right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuName left, Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuName right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagedClusterSkuTier : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuTier>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagedClusterSkuTier(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuTier Free { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuTier Paid { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuTier other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuTier left, Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuTier right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuTier (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuTier left, Azure.ResourceManager.ContainerService.Models.ManagedClusterSkuTier right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagedClusterStorageProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfile>
    {
        public ManagedClusterStorageProfile() { }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfileDiskCsiDriver DiskCsiDriver { get { throw null; } set { } }
        public bool? IsBlobCsiDriverEnabled { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("This property is obsolete and will be removed in a future release", false)]
        public bool? IsDiskCsiDriverEnabled { get { throw null; } set { } }
        public bool? IsFileCsiDriverEnabled { get { throw null; } set { } }
        public bool? IsSnapshotControllerEnabled { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterStorageProfileDiskCsiDriver : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfileDiskCsiDriver>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfileDiskCsiDriver>
    {
        public ManagedClusterStorageProfileDiskCsiDriver() { }
        public bool? IsEnabled { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfileDiskCsiDriver System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfileDiskCsiDriver>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfileDiskCsiDriver>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfileDiskCsiDriver System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfileDiskCsiDriver>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfileDiskCsiDriver>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterStorageProfileDiskCsiDriver>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedClusterVerticalPodAutoscaler : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscaler>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscaler>
    {
        public ManagedClusterVerticalPodAutoscaler(bool isEnabled, Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerControlledValue controlledValues, Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscalerUpdateMode updateMode) { }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerControlledValue ControlledValues { get { throw null; } set { } }
        public bool IsEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscalerUpdateMode UpdateMode { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscaler System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscaler>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscaler>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscaler System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscaler>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscaler>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscaler>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagedClusterVerticalPodAutoscalerUpdateMode : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscalerUpdateMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagedClusterVerticalPodAutoscalerUpdateMode(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscalerUpdateMode Auto { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscalerUpdateMode Initial { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscalerUpdateMode Off { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscalerUpdateMode Recreate { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscalerUpdateMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscalerUpdateMode left, Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscalerUpdateMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscalerUpdateMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscalerUpdateMode left, Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscalerUpdateMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagedClusterWindowsProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterWindowsProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterWindowsProfile>
    {
        public ManagedClusterWindowsProfile(string adminUsername) { }
        public string AdminPassword { get { throw null; } set { } }
        public string AdminUsername { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.WindowsGmsaProfile GmsaProfile { get { throw null; } set { } }
        public bool? IsCsiProxyEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.WindowsVmLicenseType? LicenseType { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterWindowsProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterWindowsProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterWindowsProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterWindowsProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterWindowsProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterWindowsProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterWindowsProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ManagedClusterWorkloadAutoScalerControlledValue : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerControlledValue>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ManagedClusterWorkloadAutoScalerControlledValue(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerControlledValue RequestsAndLimits { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerControlledValue RequestsOnly { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerControlledValue other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerControlledValue left, Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerControlledValue right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerControlledValue (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerControlledValue left, Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerControlledValue right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagedClusterWorkloadAutoScalerProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerProfile>
    {
        public ManagedClusterWorkloadAutoScalerProfile() { }
        public bool? IsKedaEnabled { get { throw null; } set { } }
        public Azure.ResourceManager.ContainerService.Models.ManagedClusterVerticalPodAutoscaler VerticalPodAutoscaler { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.ManagedClusterWorkloadAutoScalerProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ScaleDownMode : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ScaleDownMode>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ScaleDownMode(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ScaleDownMode Deallocate { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ScaleDownMode Delete { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ScaleDownMode other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ScaleDownMode left, Azure.ResourceManager.ContainerService.Models.ScaleDownMode right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ScaleDownMode (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ScaleDownMode left, Azure.ResourceManager.ContainerService.Models.ScaleDownMode right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ScaleSetEvictionPolicy : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ScaleSetEvictionPolicy(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy Deallocate { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy Delete { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy left, Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy left, Azure.ResourceManager.ContainerService.Models.ScaleSetEvictionPolicy right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ScaleSetPriority : System.IEquatable<Azure.ResourceManager.ContainerService.Models.ScaleSetPriority>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ScaleSetPriority(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.ScaleSetPriority Regular { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.ScaleSetPriority Spot { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.ScaleSetPriority other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.ScaleSetPriority left, Azure.ResourceManager.ContainerService.Models.ScaleSetPriority right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.ScaleSetPriority (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.ScaleSetPriority left, Azure.ResourceManager.ContainerService.Models.ScaleSetPriority right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SnapshotType : System.IEquatable<Azure.ResourceManager.ContainerService.Models.SnapshotType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SnapshotType(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.SnapshotType ManagedCluster { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.SnapshotType NodePool { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.SnapshotType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.SnapshotType left, Azure.ResourceManager.ContainerService.Models.SnapshotType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.SnapshotType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.SnapshotType left, Azure.ResourceManager.ContainerService.Models.SnapshotType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SysctlConfig : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.SysctlConfig>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.SysctlConfig>
    {
        public SysctlConfig() { }
        public int? FsAioMaxNr { get { throw null; } set { } }
        public int? FsFileMax { get { throw null; } set { } }
        public int? FsInotifyMaxUserWatches { get { throw null; } set { } }
        public int? FsNrOpen { get { throw null; } set { } }
        public int? KernelThreadsMax { get { throw null; } set { } }
        public int? NetCoreNetdevMaxBacklog { get { throw null; } set { } }
        public int? NetCoreOptmemMax { get { throw null; } set { } }
        public int? NetCoreRmemDefault { get { throw null; } set { } }
        public int? NetCoreRmemMax { get { throw null; } set { } }
        public int? NetCoreSomaxconn { get { throw null; } set { } }
        public int? NetCoreWmemDefault { get { throw null; } set { } }
        public int? NetCoreWmemMax { get { throw null; } set { } }
        public string NetIPv4IPLocalPortRange { get { throw null; } set { } }
        public int? NetIPv4NeighDefaultGcThresh1 { get { throw null; } set { } }
        public int? NetIPv4NeighDefaultGcThresh2 { get { throw null; } set { } }
        public int? NetIPv4NeighDefaultGcThresh3 { get { throw null; } set { } }
        public int? NetIPv4TcpFinTimeout { get { throw null; } set { } }
        public int? NetIPv4TcpKeepaliveIntvl { get { throw null; } set { } }
        public int? NetIPv4TcpKeepaliveProbes { get { throw null; } set { } }
        public int? NetIPv4TcpKeepaliveTime { get { throw null; } set { } }
        public int? NetIPv4TcpMaxSynBacklog { get { throw null; } set { } }
        public int? NetIPv4TcpMaxTwBuckets { get { throw null; } set { } }
        public bool? NetIPv4TcpTwReuse { get { throw null; } set { } }
        public int? NetNetfilterNfConntrackBuckets { get { throw null; } set { } }
        public int? NetNetfilterNfConntrackMax { get { throw null; } set { } }
        public int? VmMaxMapCount { get { throw null; } set { } }
        public int? VmSwappiness { get { throw null; } set { } }
        public int? VmVfsCachePressure { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.SysctlConfig System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.SysctlConfig>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.SysctlConfig>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.SysctlConfig System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.SysctlConfig>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.SysctlConfig>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.SysctlConfig>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UpgradeChannel : System.IEquatable<Azure.ResourceManager.ContainerService.Models.UpgradeChannel>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UpgradeChannel(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.UpgradeChannel NodeImage { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.UpgradeChannel None { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.UpgradeChannel Patch { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.UpgradeChannel Rapid { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.UpgradeChannel Stable { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.UpgradeChannel other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.UpgradeChannel left, Azure.ResourceManager.ContainerService.Models.UpgradeChannel right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.UpgradeChannel (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.UpgradeChannel left, Azure.ResourceManager.ContainerService.Models.UpgradeChannel right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class WindowsGmsaProfile : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.WindowsGmsaProfile>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.WindowsGmsaProfile>
    {
        public WindowsGmsaProfile() { }
        public string DnsServer { get { throw null; } set { } }
        public bool? IsEnabled { get { throw null; } set { } }
        public string RootDomainName { get { throw null; } set { } }
        Azure.ResourceManager.ContainerService.Models.WindowsGmsaProfile System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.WindowsGmsaProfile>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.ContainerService.Models.WindowsGmsaProfile>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.ContainerService.Models.WindowsGmsaProfile System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.WindowsGmsaProfile>.Create(System.BinaryData data, System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.WindowsGmsaProfile>.GetFormatFromOptions(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.ContainerService.Models.WindowsGmsaProfile>.Write(System.ClientModel.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WindowsVmLicenseType : System.IEquatable<Azure.ResourceManager.ContainerService.Models.WindowsVmLicenseType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WindowsVmLicenseType(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.WindowsVmLicenseType None { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.WindowsVmLicenseType WindowsServer { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.WindowsVmLicenseType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.WindowsVmLicenseType left, Azure.ResourceManager.ContainerService.Models.WindowsVmLicenseType right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.WindowsVmLicenseType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.WindowsVmLicenseType left, Azure.ResourceManager.ContainerService.Models.WindowsVmLicenseType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WorkloadRuntime : System.IEquatable<Azure.ResourceManager.ContainerService.Models.WorkloadRuntime>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WorkloadRuntime(string value) { throw null; }
        public static Azure.ResourceManager.ContainerService.Models.WorkloadRuntime KataMshvVmIsolation { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.WorkloadRuntime OciContainer { get { throw null; } }
        public static Azure.ResourceManager.ContainerService.Models.WorkloadRuntime WasmWasi { get { throw null; } }
        public bool Equals(Azure.ResourceManager.ContainerService.Models.WorkloadRuntime other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.ContainerService.Models.WorkloadRuntime left, Azure.ResourceManager.ContainerService.Models.WorkloadRuntime right) { throw null; }
        public static implicit operator Azure.ResourceManager.ContainerService.Models.WorkloadRuntime (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.ContainerService.Models.WorkloadRuntime left, Azure.ResourceManager.ContainerService.Models.WorkloadRuntime right) { throw null; }
        public override string ToString() { throw null; }
    }
}
