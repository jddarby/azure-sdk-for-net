namespace Azure.ResourceManager.HybridNetwork
{
    public partial class ArtifactManifestCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource>, System.Collections.IEnumerable
    {
        protected ArtifactManifestCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string artifactManifestName, Azure.ResourceManager.HybridNetwork.ArtifactManifestData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string artifactManifestName, Azure.ResourceManager.HybridNetwork.ArtifactManifestData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string artifactManifestName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string artifactManifestName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource> Get(string artifactManifestName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource>> GetAsync(string artifactManifestName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ArtifactManifestData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public ArtifactManifestData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState? ArtifactManifestState { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.HybridNetwork.Models.ManifestArtifactFormat> Artifacts { get { throw null; } }
        public Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? ProvisioningState { get { throw null; } }
    }
    public partial class ArtifactManifestResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ArtifactManifestResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.ArtifactManifestData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string publisherName, string artifactStoreName, string artifactManifestName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.Models.ArtifactAccessCredential> GetCredential(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.Models.ArtifactAccessCredential>> GetCredentialAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource> Update(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource>> UpdateAsync(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestUpdateState> UpdateState(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestUpdateState artifactManifestUpdateState, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestUpdateState>> UpdateStateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestUpdateState artifactManifestUpdateState, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ArtifactStoreCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource>, System.Collections.IEnumerable
    {
        protected ArtifactStoreCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string artifactStoreName, Azure.ResourceManager.HybridNetwork.ArtifactStoreData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string artifactStoreName, Azure.ResourceManager.HybridNetwork.ArtifactStoreData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string artifactStoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string artifactStoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource> Get(string artifactStoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource>> GetAsync(string artifactStoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ArtifactStoreData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public ArtifactStoreData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public Azure.ResourceManager.HybridNetwork.Models.ArtifactStorePropertiesFormatManagedResourceGroupConfiguration ManagedResourceGroupConfiguration { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.HybridNetwork.Models.ArtifactReplicationStrategy? ReplicationStrategy { get { throw null; } set { } }
        public string StorageResourceId { get { throw null; } }
        public Azure.ResourceManager.HybridNetwork.Models.ArtifactStoreType? StoreType { get { throw null; } set { } }
    }
    public partial class ArtifactStoreResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ArtifactStoreResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.ArtifactStoreData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.Models.ProxyArtifactVersionsListOverview> ChangeArtifactState(Azure.WaitUntil waitUntil, string artifactVersionName, string artifactName, Azure.ResourceManager.HybridNetwork.Models.ArtifactChangeState artifactChangeState, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.Models.ProxyArtifactVersionsListOverview>> ChangeArtifactStateAsync(Azure.WaitUntil waitUntil, string artifactVersionName, string artifactName, Azure.ResourceManager.HybridNetwork.Models.ArtifactChangeState artifactChangeState, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string publisherName, string artifactStoreName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource> GetArtifactManifest(string artifactManifestName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactManifestResource>> GetArtifactManifestAsync(string artifactManifestName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridNetwork.ArtifactManifestCollection GetArtifactManifests() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.Models.ProxyArtifactVersionsListOverview> GetProxyArtifacts(string artifactName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.Models.ProxyArtifactListOverview> GetProxyArtifacts(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.Models.ProxyArtifactVersionsListOverview> GetProxyArtifactsAsync(string artifactName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.Models.ProxyArtifactListOverview> GetProxyArtifactsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource> Update(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource>> UpdateAsync(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ComponentCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.ComponentResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.ComponentResource>, System.Collections.IEnumerable
    {
        protected ComponentCollection() { }
        public virtual Azure.Response<bool> Exists(string componentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string componentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ComponentResource> Get(string componentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.ComponentResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.ComponentResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ComponentResource>> GetAsync(string componentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridNetwork.ComponentResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.ComponentResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridNetwork.ComponentResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.ComponentResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ComponentData : Azure.ResourceManager.Models.ResourceData
    {
        public ComponentData() { }
        public string DeploymentProfile { get { throw null; } }
        public Azure.ResourceManager.HybridNetwork.Models.DeploymentStatusProperties DeploymentStatus { get { throw null; } }
        public Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? ProvisioningState { get { throw null; } }
    }
    public partial class ComponentResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ComponentResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.ComponentData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string networkFunctionName, string componentName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ComponentResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ComponentResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ConfigurationGroupSchemaCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource>, System.Collections.IEnumerable
    {
        protected ConfigurationGroupSchemaCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string configurationGroupSchemaName, Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string configurationGroupSchemaName, Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string configurationGroupSchemaName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string configurationGroupSchemaName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource> Get(string configurationGroupSchemaName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource>> GetAsync(string configurationGroupSchemaName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ConfigurationGroupSchemaData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public ConfigurationGroupSchemaData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string SchemaDefinition { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.VersionState? VersionState { get { throw null; } }
    }
    public partial class ConfigurationGroupSchemaResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ConfigurationGroupSchemaResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string publisherName, string configurationGroupSchemaName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource> Update(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource>> UpdateAsync(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.Models.ConfigurationGroupSchemaVersionUpdateState> UpdateState(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridNetwork.Models.ConfigurationGroupSchemaVersionUpdateState configurationGroupSchemaVersionUpdateState, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.Models.ConfigurationGroupSchemaVersionUpdateState>> UpdateStateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridNetwork.Models.ConfigurationGroupSchemaVersionUpdateState configurationGroupSchemaVersionUpdateState, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ConfigurationGroupValueCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource>, System.Collections.IEnumerable
    {
        protected ConfigurationGroupValueCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string configurationGroupValueName, Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string configurationGroupValueName, Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string configurationGroupValueName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string configurationGroupValueName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource> Get(string configurationGroupValueName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource>> GetAsync(string configurationGroupValueName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ConfigurationGroupValueData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public ConfigurationGroupValueData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string ConfigurationGroupSchemaName { get { throw null; } set { } }
        public string ConfigurationGroupSchemaOfferingLocation { get { throw null; } set { } }
        public string ConfigurationValue { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string PublisherName { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.PublisherScope? PublisherScope { get { throw null; } set { } }
    }
    public partial class ConfigurationGroupValueResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ConfigurationGroupValueResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string configurationGroupValueName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource> Update(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource>> UpdateAsync(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public static partial class HybridNetworkExtensions
    {
        public static Azure.ResourceManager.HybridNetwork.ArtifactManifestResource GetArtifactManifestResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.ArtifactStoreResource GetArtifactStoreResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.ComponentResource GetComponentResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource GetConfigurationGroupSchemaResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource> GetConfigurationGroupValue(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string configurationGroupValueName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource>> GetConfigurationGroupValueAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string configurationGroupValueName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource GetConfigurationGroupValueResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueCollection GetConfigurationGroupValues(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource> GetConfigurationGroupValues(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueResource> GetConfigurationGroupValuesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource> GetNetworkFunction(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string networkFunctionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource>> GetNetworkFunctionAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string networkFunctionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupOverviewResource GetNetworkFunctionDefinitionGroupOverviewResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource GetNetworkFunctionDefinitionGroupResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionOverviewResource GetNetworkFunctionDefinitionVersionOverviewResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource GetNetworkFunctionDefinitionVersionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkFunctionResource GetNetworkFunctionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkFunctionCollection GetNetworkFunctions(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource> GetNetworkFunctions(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource> GetNetworkFunctionsAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupOverviewResource GetNetworkServiceDesignGroupOverviewResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource GetNetworkServiceDesignGroupResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionOverviewResource GetNetworkServiceDesignVersionOverviewResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource GetNetworkServiceDesignVersionResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.HybridNetwork.ProxyPublisherOverviewResource> GetProxyPublisherOverview(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string proxyPublisherName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ProxyPublisherOverviewResource>> GetProxyPublisherOverviewAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, string proxyPublisherName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.ProxyPublisherOverviewResource GetProxyPublisherOverviewResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.ProxyPublisherOverviewCollection GetProxyPublisherOverviews(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource) { throw null; }
        public static Azure.Response<Azure.ResourceManager.HybridNetwork.PublisherResource> GetPublisher(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string publisherName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.PublisherResource>> GetPublisherAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string publisherName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.PublisherResource GetPublisherResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.PublisherCollection GetPublishers(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.HybridNetwork.PublisherResource> GetPublishers(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.PublisherResource> GetPublishersAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.HybridNetwork.SiteResource> GetSite(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.SiteResource>> GetSiteAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource> GetSiteNetworkService(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string siteNetworkServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource>> GetSiteNetworkServiceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string siteNetworkServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource GetSiteNetworkServiceResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.SiteNetworkServiceCollection GetSiteNetworkServices(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource> GetSiteNetworkServices(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource> GetSiteNetworkServicesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.SiteResource GetSiteResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.SiteCollection GetSites(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.HybridNetwork.SiteResource> GetSites(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.SiteResource> GetSitesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NetworkFunctionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource>, System.Collections.IEnumerable
    {
        protected NetworkFunctionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string networkFunctionName, Azure.ResourceManager.HybridNetwork.NetworkFunctionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string networkFunctionName, Azure.ResourceManager.HybridNetwork.NetworkFunctionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string networkFunctionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string networkFunctionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource> Get(string networkFunctionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource>> GetAsync(string networkFunctionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class NetworkFunctionData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public NetworkFunctionData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public bool? AllowSoftwareUpdate { get { throw null; } set { } }
        public string DeploymentValues { get { throw null; } set { } }
        public Azure.ETag? ETag { get { throw null; } set { } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public string NetworkFunctionDefinitionGroupName { get { throw null; } set { } }
        public string NetworkFunctionDefinitionOfferingLocation { get { throw null; } set { } }
        public string NetworkFunctionDefinitionVersion { get { throw null; } set { } }
        public string NfviId { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.NfviType? NfviType { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string PublisherName { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.PublisherScope? PublisherScope { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> RoleOverrideValues { get { throw null; } }
    }
    public partial class NetworkFunctionDefinitionGroupCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource>, System.Collections.IEnumerable
    {
        protected NetworkFunctionDefinitionGroupCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string networkFunctionDefinitionGroupName, Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string networkFunctionDefinitionGroupName, Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string networkFunctionDefinitionGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string networkFunctionDefinitionGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource> Get(string networkFunctionDefinitionGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource>> GetAsync(string networkFunctionDefinitionGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class NetworkFunctionDefinitionGroupData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public NetworkFunctionDefinitionGroupData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? ProvisioningState { get { throw null; } }
    }
    public partial class NetworkFunctionDefinitionGroupOverviewCollection : Azure.ResourceManager.ArmCollection
    {
        protected NetworkFunctionDefinitionGroupOverviewCollection() { }
        public virtual Azure.Response<bool> Exists(string networkFunctionDefinitionGroupName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string networkFunctionDefinitionGroupName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupOverviewResource> Get(string networkFunctionDefinitionGroupName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupOverviewResource> GetAll(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupOverviewResource> GetAllAsync(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupOverviewResource>> GetAsync(string networkFunctionDefinitionGroupName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NetworkFunctionDefinitionGroupOverviewData : Azure.ResourceManager.Models.ResourceData
    {
        public NetworkFunctionDefinitionGroupOverviewData() { }
        public string Description { get { throw null; } }
    }
    public partial class NetworkFunctionDefinitionGroupOverviewResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected NetworkFunctionDefinitionGroupOverviewResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupOverviewData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string proxyPublisherName, string networkFunctionDefinitionGroupName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupOverviewResource> Get(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupOverviewResource>> GetAsync(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionOverviewResource> GetNetworkFunctionDefinitionVersionOverview(string networkFunctionDefinitionVersionName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionOverviewResource>> GetNetworkFunctionDefinitionVersionOverviewAsync(string networkFunctionDefinitionVersionName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionOverviewCollection GetNetworkFunctionDefinitionVersionOverviews() { throw null; }
    }
    public partial class NetworkFunctionDefinitionGroupResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected NetworkFunctionDefinitionGroupResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string publisherName, string networkFunctionDefinitionGroupName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource> GetNetworkFunctionDefinitionVersion(string networkFunctionDefinitionVersionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource>> GetNetworkFunctionDefinitionVersionAsync(string networkFunctionDefinitionVersionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionCollection GetNetworkFunctionDefinitionVersions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource> Update(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource>> UpdateAsync(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NetworkFunctionDefinitionVersionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource>, System.Collections.IEnumerable
    {
        protected NetworkFunctionDefinitionVersionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string networkFunctionDefinitionVersionName, Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string networkFunctionDefinitionVersionName, Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string networkFunctionDefinitionVersionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string networkFunctionDefinitionVersionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource> Get(string networkFunctionDefinitionVersionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource>> GetAsync(string networkFunctionDefinitionVersionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class NetworkFunctionDefinitionVersionData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public NetworkFunctionDefinitionVersionData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string DeployParameters { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.HybridNetwork.Models.VersionState? VersionState { get { throw null; } }
    }
    public partial class NetworkFunctionDefinitionVersionOverviewCollection : Azure.ResourceManager.ArmCollection
    {
        protected NetworkFunctionDefinitionVersionOverviewCollection() { }
        public virtual Azure.Response<bool> Exists(string networkFunctionDefinitionVersionName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string networkFunctionDefinitionVersionName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionOverviewResource> Get(string networkFunctionDefinitionVersionName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionOverviewResource> GetAll(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionOverviewResource> GetAllAsync(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionOverviewResource>> GetAsync(string networkFunctionDefinitionVersionName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NetworkFunctionDefinitionVersionOverviewData : Azure.ResourceManager.Models.ResourceData
    {
        public NetworkFunctionDefinitionVersionOverviewData() { }
        public string DeployParameters { get { throw null; } }
        public string Description { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionDefinitionApplicationOverview> NetworkFunctionApplications { get { throw null; } }
        public Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionType? NetworkFunctionType { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.NfviType? NfviType { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.VersionState? VersionState { get { throw null; } set { } }
    }
    public partial class NetworkFunctionDefinitionVersionOverviewResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected NetworkFunctionDefinitionVersionOverviewResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionOverviewData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string proxyPublisherName, string networkFunctionDefinitionGroupName, string networkFunctionDefinitionVersionName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionOverviewResource> Get(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionOverviewResource>> GetAsync(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NetworkFunctionDefinitionVersionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected NetworkFunctionDefinitionVersionResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string publisherName, string networkFunctionDefinitionGroupName, string networkFunctionDefinitionVersionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource> Update(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionResource>> UpdateAsync(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionDefinitionVersionUpdateState> UpdateState(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionDefinitionVersionUpdateState networkFunctionDefinitionVersionUpdateState, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionDefinitionVersionUpdateState>> UpdateStateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionDefinitionVersionUpdateState networkFunctionDefinitionVersionUpdateState, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NetworkFunctionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected NetworkFunctionResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkFunctionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string networkFunctionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation ExecuteRequest(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridNetwork.Models.ExecuteRequestContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> ExecuteRequestAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridNetwork.Models.ExecuteRequestContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ComponentResource> GetComponent(string componentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ComponentResource>> GetComponentAsync(string componentName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridNetwork.ComponentCollection GetComponents() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource> Update(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionResource>> UpdateAsync(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NetworkServiceDesignGroupCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource>, System.Collections.IEnumerable
    {
        protected NetworkServiceDesignGroupCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string networkServiceDesignGroupName, Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string networkServiceDesignGroupName, Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string networkServiceDesignGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string networkServiceDesignGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource> Get(string networkServiceDesignGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource>> GetAsync(string networkServiceDesignGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class NetworkServiceDesignGroupData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public NetworkServiceDesignGroupData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? ProvisioningState { get { throw null; } }
    }
    public partial class NetworkServiceDesignGroupOverviewCollection : Azure.ResourceManager.ArmCollection
    {
        protected NetworkServiceDesignGroupOverviewCollection() { }
        public virtual Azure.Response<bool> Exists(string networkServiceDesignGroupName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string networkServiceDesignGroupName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupOverviewResource> Get(string networkServiceDesignGroupName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupOverviewResource> GetAll(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupOverviewResource> GetAllAsync(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupOverviewResource>> GetAsync(string networkServiceDesignGroupName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NetworkServiceDesignGroupOverviewData : Azure.ResourceManager.Models.ResourceData
    {
        public NetworkServiceDesignGroupOverviewData() { }
        public string Description { get { throw null; } }
    }
    public partial class NetworkServiceDesignGroupOverviewResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected NetworkServiceDesignGroupOverviewResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupOverviewData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string proxyPublisherName, string networkServiceDesignGroupName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupOverviewResource> Get(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupOverviewResource>> GetAsync(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionOverviewResource> GetNetworkServiceDesignVersionOverview(string networkServiceDesignVersionName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionOverviewResource>> GetNetworkServiceDesignVersionOverviewAsync(string networkServiceDesignVersionName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionOverviewCollection GetNetworkServiceDesignVersionOverviews() { throw null; }
    }
    public partial class NetworkServiceDesignGroupResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected NetworkServiceDesignGroupResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string publisherName, string networkServiceDesignGroupName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource> GetNetworkServiceDesignVersion(string networkServiceDesignVersionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource>> GetNetworkServiceDesignVersionAsync(string networkServiceDesignVersionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionCollection GetNetworkServiceDesignVersions() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource> Update(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource>> UpdateAsync(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NetworkServiceDesignVersionCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource>, System.Collections.IEnumerable
    {
        protected NetworkServiceDesignVersionCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string networkServiceDesignVersionName, Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string networkServiceDesignVersionName, Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string networkServiceDesignVersionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string networkServiceDesignVersionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource> Get(string networkServiceDesignVersionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource>> GetAsync(string networkServiceDesignVersionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class NetworkServiceDesignVersionData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public NetworkServiceDesignVersionData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Resources.Models.WritableSubResource> ConfigurationGroupSchemaReferences { get { throw null; } }
        public string Description { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.HybridNetwork.Models.NfviDetails> NfvisFromSite { get { throw null; } }
        public Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.HybridNetwork.Models.ResourceElementTemplate> ResourceElementTemplates { get { throw null; } }
        public Azure.ResourceManager.HybridNetwork.Models.VersionState? VersionState { get { throw null; } }
    }
    public partial class NetworkServiceDesignVersionOverviewCollection : Azure.ResourceManager.ArmCollection
    {
        protected NetworkServiceDesignVersionOverviewCollection() { }
        public virtual Azure.Response<bool> Exists(string networkServiceDesignVersionName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string networkServiceDesignVersionName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionOverviewResource> Get(string networkServiceDesignVersionName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionOverviewResource> GetAll(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionOverviewResource> GetAllAsync(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionOverviewResource>> GetAsync(string networkServiceDesignVersionName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NetworkServiceDesignVersionOverviewData : Azure.ResourceManager.Models.ResourceData
    {
        public NetworkServiceDesignVersionOverviewData() { }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.HybridNetwork.Models.ConfigurationGroupSchemaReferences> ConfigurationGroupSchemaReferences { get { throw null; } }
        public string Description { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.HybridNetwork.Models.NfviDetails> NfvisFromSite { get { throw null; } }
        public Azure.ResourceManager.HybridNetwork.Models.VersionState? VersionState { get { throw null; } set { } }
    }
    public partial class NetworkServiceDesignVersionOverviewResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected NetworkServiceDesignVersionOverviewResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionOverviewData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string proxyPublisherName, string networkServiceDesignGroupName, string networkServiceDesignVersionName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionOverviewResource> Get(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionOverviewResource>> GetAsync(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NetworkServiceDesignVersionResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected NetworkServiceDesignVersionResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string publisherName, string networkServiceDesignGroupName, string networkServiceDesignVersionName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource> Update(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionResource>> UpdateAsync(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.Models.NetworkServiceDesignVersionUpdateState> UpdateState(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridNetwork.Models.NetworkServiceDesignVersionUpdateState networkServiceDesignVersionUpdateState, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.Models.NetworkServiceDesignVersionUpdateState>> UpdateStateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.HybridNetwork.Models.NetworkServiceDesignVersionUpdateState networkServiceDesignVersionUpdateState, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ProxyPublisherOverviewCollection : Azure.ResourceManager.ArmCollection
    {
        protected ProxyPublisherOverviewCollection() { }
        public virtual Azure.Response<bool> Exists(string proxyPublisherName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string proxyPublisherName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ProxyPublisherOverviewResource> Get(string proxyPublisherName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.ProxyPublisherOverviewResource> GetAll(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.ProxyPublisherOverviewResource> GetAllAsync(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ProxyPublisherOverviewResource>> GetAsync(string proxyPublisherName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ProxyPublisherOverviewData : Azure.ResourceManager.Models.ResourceData
    {
        public ProxyPublisherOverviewData() { }
    }
    public partial class ProxyPublisherOverviewResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ProxyPublisherOverviewResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.ProxyPublisherOverviewData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string proxyPublisherName) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ProxyPublisherOverviewResource> Get(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ProxyPublisherOverviewResource>> GetAsync(string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupOverviewResource> GetNetworkFunctionDefinitionGroupOverview(string networkFunctionDefinitionGroupName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupOverviewResource>> GetNetworkFunctionDefinitionGroupOverviewAsync(string networkFunctionDefinitionGroupName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupOverviewCollection GetNetworkFunctionDefinitionGroupOverviews() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupOverviewResource> GetNetworkServiceDesignGroupOverview(string networkServiceDesignGroupName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupOverviewResource>> GetNetworkServiceDesignGroupOverviewAsync(string networkServiceDesignGroupName, string publisherScopeName, string publisherLocationName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupOverviewCollection GetNetworkServiceDesignGroupOverviews() { throw null; }
    }
    public partial class PublisherCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.PublisherResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.PublisherResource>, System.Collections.IEnumerable
    {
        protected PublisherCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.PublisherResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string publisherName, Azure.ResourceManager.HybridNetwork.PublisherData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.PublisherResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string publisherName, Azure.ResourceManager.HybridNetwork.PublisherData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string publisherName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string publisherName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.PublisherResource> Get(string publisherName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.PublisherResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.PublisherResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.PublisherResource>> GetAsync(string publisherName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridNetwork.PublisherResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.PublisherResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridNetwork.PublisherResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.PublisherResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class PublisherData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public PublisherData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.HybridNetwork.Models.PublisherScope? Scope { get { throw null; } set { } }
    }
    public partial class PublisherResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected PublisherResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.PublisherData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.PublisherResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.PublisherResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string publisherName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.PublisherResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource> GetArtifactStore(string artifactStoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ArtifactStoreResource>> GetArtifactStoreAsync(string artifactStoreName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridNetwork.ArtifactStoreCollection GetArtifactStores() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.PublisherResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource> GetConfigurationGroupSchema(string configurationGroupSchemaName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaResource>> GetConfigurationGroupSchemaAsync(string configurationGroupSchemaName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaCollection GetConfigurationGroupSchemas() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource> GetNetworkFunctionDefinitionGroup(string networkFunctionDefinitionGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupResource>> GetNetworkFunctionDefinitionGroupAsync(string networkFunctionDefinitionGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupCollection GetNetworkFunctionDefinitionGroups() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource> GetNetworkServiceDesignGroup(string networkServiceDesignGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupResource>> GetNetworkServiceDesignGroupAsync(string networkServiceDesignGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupCollection GetNetworkServiceDesignGroups() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.PublisherResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.PublisherResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.PublisherResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.PublisherResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.PublisherResource> Update(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.PublisherResource>> UpdateAsync(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.SiteResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.SiteResource>, System.Collections.IEnumerable
    {
        protected SiteCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.SiteResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string siteName, Azure.ResourceManager.HybridNetwork.SiteData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.SiteResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string siteName, Azure.ResourceManager.HybridNetwork.SiteData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.SiteResource> Get(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.SiteResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.SiteResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.SiteResource>> GetAsync(string siteName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridNetwork.SiteResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.SiteResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridNetwork.SiteResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.SiteResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public SiteData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public System.Collections.Generic.IList<Azure.ResourceManager.HybridNetwork.Models.NFVIs> Nfvis { get { throw null; } }
        public Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.WritableSubResource> SiteNetworkServiceReferences { get { throw null; } }
    }
    public partial class SiteNetworkServiceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource>, System.Collections.IEnumerable
    {
        protected SiteNetworkServiceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string siteNetworkServiceName, Azure.ResourceManager.HybridNetwork.SiteNetworkServiceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string siteNetworkServiceName, Azure.ResourceManager.HybridNetwork.SiteNetworkServiceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string siteNetworkServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string siteNetworkServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource> Get(string siteNetworkServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource>> GetAsync(string siteNetworkServiceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SiteNetworkServiceData : Azure.ResourceManager.Models.TrackedResourceData
    {
        public SiteNetworkServiceData(Azure.Core.AzureLocation location) : base (default(Azure.Core.AzureLocation)) { }
        public System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Resources.Models.WritableSubResource> DesiredStateConfigurationGroupValueReferences { get { throw null; } }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyDictionary<string, Azure.ResourceManager.Resources.Models.WritableSubResource> LastStateConfigurationGroupValueReferences { get { throw null; } }
        public string LastStateNetworkServiceDesignVersionName { get { throw null; } }
        public Azure.ResourceManager.HybridNetwork.Models.ManagedResourceGroupConfiguration ManagedResourceGroupConfiguration { get { throw null; } set { } }
        public string NetworkServiceDesignGroupName { get { throw null; } set { } }
        public string NetworkServiceDesignVersionName { get { throw null; } set { } }
        public string NetworkServiceDesignVersionOfferingLocation { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string PublisherName { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.PublisherScope? PublisherScope { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier SiteReferenceId { get { throw null; } set { } }
    }
    public partial class SiteNetworkServiceResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteNetworkServiceResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.SiteNetworkServiceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteNetworkServiceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource> Update(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.SiteNetworkServiceResource>> UpdateAsync(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SiteResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SiteResource() { }
        public virtual Azure.ResourceManager.HybridNetwork.SiteData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.SiteResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.SiteResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string siteName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.SiteResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.SiteResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.SiteResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.SiteResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.SiteResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.SiteResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.HybridNetwork.SiteResource> Update(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.HybridNetwork.SiteResource>> UpdateAsync(Azure.ResourceManager.HybridNetwork.Models.TagsObject tagsObject, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.HybridNetwork.Models
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ApplicationEnablement : System.IEquatable<Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ApplicationEnablement(string value) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement Disabled { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement Enabled { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement left, Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement left, Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement right) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class ArmHybridNetworkModelFactory
    {
        public static Azure.ResourceManager.HybridNetwork.Models.ArmTemplateApplicationOverview ArmTemplateApplicationOverview(string name = null, Azure.ResourceManager.HybridNetwork.Models.AzureCoreArmTemplateDeployMappingRuleProfile deployParametersMappingRuleProfile = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.ArtifactManifestData ArtifactManifestData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.HybridNetwork.Models.ProvisioningState?), Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState? artifactManifestState = default(Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.Models.ManifestArtifactFormat> artifacts = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.ArtifactStoreData ArtifactStoreData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.HybridNetwork.Models.ProvisioningState?), Azure.ResourceManager.HybridNetwork.Models.ArtifactStoreType? storeType = default(Azure.ResourceManager.HybridNetwork.Models.ArtifactStoreType?), Azure.ResourceManager.HybridNetwork.Models.ArtifactReplicationStrategy? replicationStrategy = default(Azure.ResourceManager.HybridNetwork.Models.ArtifactReplicationStrategy?), Azure.ResourceManager.HybridNetwork.Models.ArtifactStorePropertiesFormatManagedResourceGroupConfiguration managedResourceGroupConfiguration = null, string storageResourceId = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.AzureArcKubernetesDeployMappingRuleProfile AzureArcKubernetesDeployMappingRuleProfile(Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement? applicationEnablement = default(Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement?), Azure.ResourceManager.HybridNetwork.Models.HelmMappingRuleProfile helmMappingRuleProfile = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.AzureContainerRegistryScopedTokenCredential AzureContainerRegistryScopedTokenCredential(string username = null, string acrToken = null, System.Uri acrServerUri = null, System.Collections.Generic.IEnumerable<string> repositories = null, System.DateTimeOffset? expiry = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.AzureCoreArmTemplateDeployMappingRuleProfile AzureCoreArmTemplateDeployMappingRuleProfile(Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement? applicationEnablement = default(Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement?), string templateParameters = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.AzureCoreVhdImageDeployMappingRuleProfile AzureCoreVhdImageDeployMappingRuleProfile(Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement? applicationEnablement = default(Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement?), string vhdImageMappingRuleUserConfiguration = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.AzureStorageAccountContainerCredential AzureStorageAccountContainerCredential(string containerName = null, System.Uri containerSasUri = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.AzureStorageAccountCredential AzureStorageAccountCredential(string storageAccountId = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.Models.AzureStorageAccountContainerCredential> containerCredentials = null, System.DateTimeOffset? expiry = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.ComponentData ComponentData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.HybridNetwork.Models.ProvisioningState?), string deploymentProfile = null, Azure.ResourceManager.HybridNetwork.Models.DeploymentStatusProperties deploymentStatus = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.ConfigurationGroupSchemaData ConfigurationGroupSchemaData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.HybridNetwork.Models.ProvisioningState?), Azure.ResourceManager.HybridNetwork.Models.VersionState? versionState = default(Azure.ResourceManager.HybridNetwork.Models.VersionState?), string schemaDefinition = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.ConfigurationGroupValueData ConfigurationGroupValueData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.HybridNetwork.Models.ProvisioningState?), string publisherName = null, Azure.ResourceManager.HybridNetwork.Models.PublisherScope? publisherScope = default(Azure.ResourceManager.HybridNetwork.Models.PublisherScope?), string configurationGroupSchemaName = null, string configurationGroupSchemaOfferingLocation = null, string configurationValue = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.DaemonSet DaemonSet(string name = null, string @namespace = null, int? desired = default(int?), int? current = default(int?), int? ready = default(int?), int? upToDate = default(int?), int? available = default(int?), System.DateTimeOffset? createdOn = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.Deployment Deployment(string name = null, string @namespace = null, int? desired = default(int?), int? ready = default(int?), int? upToDate = default(int?), int? available = default(int?), System.DateTimeOffset? createdOn = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.DeploymentStatusProperties DeploymentStatusProperties(Azure.ResourceManager.HybridNetwork.Models.Status? status = default(Azure.ResourceManager.HybridNetwork.Models.Status?), Azure.ResourceManager.HybridNetwork.Models.Resources resources = null, System.DateTimeOffset? nextExpectedUpdateOn = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.HelmMappingRuleProfile HelmMappingRuleProfile(string releaseNamespace = null, string releaseName = null, string helmPackageVersion = null, string values = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.HelmPackageApplicationOverview HelmPackageApplicationOverview(string name = null, Azure.ResourceManager.HybridNetwork.Models.AzureArcKubernetesDeployMappingRuleProfile deployParametersMappingRuleProfile = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.MappingRuleProfile MappingRuleProfile(Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement? applicationEnablement = default(Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement?)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkFunctionData NetworkFunctionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ETag? etag = default(Azure.ETag?), Azure.ResourceManager.Models.ManagedServiceIdentity identity = null, Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.HybridNetwork.Models.ProvisioningState?), string publisherName = null, Azure.ResourceManager.HybridNetwork.Models.PublisherScope? publisherScope = default(Azure.ResourceManager.HybridNetwork.Models.PublisherScope?), string networkFunctionDefinitionGroupName = null, string networkFunctionDefinitionVersion = null, string networkFunctionDefinitionOfferingLocation = null, Azure.ResourceManager.HybridNetwork.Models.NfviType? nfviType = default(Azure.ResourceManager.HybridNetwork.Models.NfviType?), string nfviId = null, bool? allowSoftwareUpdate = default(bool?), string deploymentValues = null, System.Collections.Generic.IEnumerable<string> roleOverrideValues = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionDefinitionApplicationOverview NetworkFunctionDefinitionApplicationOverview(string name = null, string artifactType = "Unknown") { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupData NetworkFunctionDefinitionGroupData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.HybridNetwork.Models.ProvisioningState?), string description = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionGroupOverviewData NetworkFunctionDefinitionGroupOverviewData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string description = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkFunctionDefinitionVersionOverviewData NetworkFunctionDefinitionVersionOverviewData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string description = null, Azure.ResourceManager.HybridNetwork.Models.VersionState? versionState = default(Azure.ResourceManager.HybridNetwork.Models.VersionState?), Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionType? networkFunctionType = default(Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionType?), Azure.ResourceManager.HybridNetwork.Models.NfviType? nfviType = default(Azure.ResourceManager.HybridNetwork.Models.NfviType?), string deployParameters = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionDefinitionApplicationOverview> networkFunctionApplications = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupData NetworkServiceDesignGroupData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.HybridNetwork.Models.ProvisioningState?), string description = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkServiceDesignGroupOverviewData NetworkServiceDesignGroupOverviewData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string description = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionData NetworkServiceDesignVersionData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.HybridNetwork.Models.ProvisioningState?), Azure.ResourceManager.HybridNetwork.Models.VersionState? versionState = default(Azure.ResourceManager.HybridNetwork.Models.VersionState?), string description = null, System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Resources.Models.WritableSubResource> configurationGroupSchemaReferences = null, System.Collections.Generic.IDictionary<string, Azure.ResourceManager.HybridNetwork.Models.NfviDetails> nfvisFromSite = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.Models.ResourceElementTemplate> resourceElementTemplates = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.NetworkServiceDesignVersionOverviewData NetworkServiceDesignVersionOverviewData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, string description = null, Azure.ResourceManager.HybridNetwork.Models.VersionState? versionState = default(Azure.ResourceManager.HybridNetwork.Models.VersionState?), System.Collections.Generic.IDictionary<string, Azure.ResourceManager.HybridNetwork.Models.ConfigurationGroupSchemaReferences> configurationGroupSchemaReferences = null, System.Collections.Generic.IDictionary<string, Azure.ResourceManager.HybridNetwork.Models.NfviDetails> nfvisFromSite = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.Pod Pod(string name = null, string @namespace = null, int? desired = default(int?), int? ready = default(int?), Azure.ResourceManager.HybridNetwork.Models.PodStatus? status = default(Azure.ResourceManager.HybridNetwork.Models.PodStatus?), System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.Models.PodEvent> events = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.PodEvent PodEvent(Azure.ResourceManager.HybridNetwork.Models.PodEventType? eventType = default(Azure.ResourceManager.HybridNetwork.Models.PodEventType?), string reason = null, string message = null, System.DateTimeOffset? lastSeenOn = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.ProxyArtifactListOverview ProxyArtifactListOverview(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.ProxyArtifactVersionsListOverview ProxyArtifactVersionsListOverview(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.HybridNetwork.Models.ArtifactType? artifactType = default(Azure.ResourceManager.HybridNetwork.Models.ArtifactType?), string artifactVersion = null, Azure.ResourceManager.HybridNetwork.Models.ArtifactState? artifactState = default(Azure.ResourceManager.HybridNetwork.Models.ArtifactState?)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.ProxyPublisherOverviewData ProxyPublisherOverviewData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.PublisherData PublisherData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Models.ManagedServiceIdentity identity = null, Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.HybridNetwork.Models.ProvisioningState?), Azure.ResourceManager.HybridNetwork.Models.PublisherScope? scope = default(Azure.ResourceManager.HybridNetwork.Models.PublisherScope?)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.ReplicaSet ReplicaSet(string name = null, string @namespace = null, int? desired = default(int?), int? ready = default(int?), int? current = default(int?), System.DateTimeOffset? createdOn = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.Resources Resources(System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.Models.Deployment> deployments = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.Models.Pod> pods = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.Models.ReplicaSet> replicaSets = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.Models.StatefulSet> statefulSets = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.Models.DaemonSet> daemonSets = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.SiteData SiteData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.HybridNetwork.Models.ProvisioningState?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.HybridNetwork.Models.NFVIs> nfvis = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.WritableSubResource> siteNetworkServiceReferences = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.SiteNetworkServiceData SiteNetworkServiceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.Models.ManagedServiceIdentity identity = null, Azure.ResourceManager.HybridNetwork.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.HybridNetwork.Models.ProvisioningState?), Azure.ResourceManager.HybridNetwork.Models.ManagedResourceGroupConfiguration managedResourceGroupConfiguration = null, Azure.Core.ResourceIdentifier siteReferenceId = null, string publisherName = null, Azure.ResourceManager.HybridNetwork.Models.PublisherScope? publisherScope = default(Azure.ResourceManager.HybridNetwork.Models.PublisherScope?), string networkServiceDesignGroupName = null, string networkServiceDesignVersionName = null, string networkServiceDesignVersionOfferingLocation = null, System.Collections.Generic.IDictionary<string, Azure.ResourceManager.Resources.Models.WritableSubResource> desiredStateConfigurationGroupValueReferences = null, string lastStateNetworkServiceDesignVersionName = null, System.Collections.Generic.IReadOnlyDictionary<string, Azure.ResourceManager.Resources.Models.WritableSubResource> lastStateConfigurationGroupValueReferences = null) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.StatefulSet StatefulSet(string name = null, string @namespace = null, int? desired = default(int?), int? ready = default(int?), System.DateTimeOffset? createdOn = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.VhdImageFileApplicationOverview VhdImageFileApplicationOverview(string name = null, Azure.ResourceManager.HybridNetwork.Models.AzureCoreVhdImageDeployMappingRuleProfile deployParametersMappingRuleProfile = null) { throw null; }
    }
    public partial class ArmResourceDefinitionResourceElementTemplate
    {
        public ArmResourceDefinitionResourceElementTemplate() { }
        public Azure.ResourceManager.HybridNetwork.Models.NSDArtifactProfile ArtifactProfile { get { throw null; } set { } }
        public string ParameterValues { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.TemplateType? TemplateType { get { throw null; } set { } }
    }
    public partial class ArmResourceDefinitionResourceElementTemplateDetails : Azure.ResourceManager.HybridNetwork.Models.ResourceElementTemplate
    {
        public ArmResourceDefinitionResourceElementTemplateDetails() { }
        public Azure.ResourceManager.HybridNetwork.Models.ArmResourceDefinitionResourceElementTemplate Configuration { get { throw null; } set { } }
    }
    public partial class ArmTemplateApplicationOverview : Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionDefinitionApplicationOverview
    {
        public ArmTemplateApplicationOverview() { }
        public Azure.ResourceManager.HybridNetwork.Models.AzureCoreArmTemplateDeployMappingRuleProfile DeployParametersMappingRuleProfile { get { throw null; } }
    }
    public abstract partial class ArtifactAccessCredential
    {
        protected ArtifactAccessCredential() { }
    }
    public partial class ArtifactChangeState
    {
        public ArtifactChangeState() { }
        public Azure.ResourceManager.HybridNetwork.Models.ArtifactState? ArtifactState { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ArtifactManifestState : System.IEquatable<Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ArtifactManifestState(string value) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState Unknown { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState Uploaded { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState Uploading { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState Validating { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState ValidationFailed { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState left, Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState left, Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ArtifactManifestUpdateState
    {
        public ArtifactManifestUpdateState() { }
        public Azure.ResourceManager.HybridNetwork.Models.ArtifactManifestState? ArtifactManifestState { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ArtifactReplicationStrategy : System.IEquatable<Azure.ResourceManager.HybridNetwork.Models.ArtifactReplicationStrategy>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ArtifactReplicationStrategy(string value) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactReplicationStrategy SingleReplication { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactReplicationStrategy Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridNetwork.Models.ArtifactReplicationStrategy other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridNetwork.Models.ArtifactReplicationStrategy left, Azure.ResourceManager.HybridNetwork.Models.ArtifactReplicationStrategy right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridNetwork.Models.ArtifactReplicationStrategy (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridNetwork.Models.ArtifactReplicationStrategy left, Azure.ResourceManager.HybridNetwork.Models.ArtifactReplicationStrategy right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ArtifactState : System.IEquatable<Azure.ResourceManager.HybridNetwork.Models.ArtifactState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ArtifactState(string value) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactState Active { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactState Deprecated { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactState Preview { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactState Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridNetwork.Models.ArtifactState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridNetwork.Models.ArtifactState left, Azure.ResourceManager.HybridNetwork.Models.ArtifactState right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridNetwork.Models.ArtifactState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridNetwork.Models.ArtifactState left, Azure.ResourceManager.HybridNetwork.Models.ArtifactState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ArtifactStorePropertiesFormatManagedResourceGroupConfiguration
    {
        public ArtifactStorePropertiesFormatManagedResourceGroupConfiguration() { }
        public Azure.Core.AzureLocation? Location { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ArtifactStoreType : System.IEquatable<Azure.ResourceManager.HybridNetwork.Models.ArtifactStoreType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ArtifactStoreType(string value) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactStoreType AzureContainerRegistry { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactStoreType AzureStorageAccount { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactStoreType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridNetwork.Models.ArtifactStoreType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridNetwork.Models.ArtifactStoreType left, Azure.ResourceManager.HybridNetwork.Models.ArtifactStoreType right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridNetwork.Models.ArtifactStoreType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridNetwork.Models.ArtifactStoreType left, Azure.ResourceManager.HybridNetwork.Models.ArtifactStoreType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ArtifactType : System.IEquatable<Azure.ResourceManager.HybridNetwork.Models.ArtifactType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ArtifactType(string value) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactType ArmTemplate { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactType ImageFile { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactType OCIArtifact { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactType Unknown { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ArtifactType VhdImageFile { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridNetwork.Models.ArtifactType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridNetwork.Models.ArtifactType left, Azure.ResourceManager.HybridNetwork.Models.ArtifactType right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridNetwork.Models.ArtifactType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridNetwork.Models.ArtifactType left, Azure.ResourceManager.HybridNetwork.Models.ArtifactType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AzureArcK8SClusterNfviDetails : Azure.ResourceManager.HybridNetwork.Models.NFVIs
    {
        public AzureArcK8SClusterNfviDetails() { }
        public Azure.Core.ResourceIdentifier CustomLocationReferenceId { get { throw null; } set { } }
    }
    public partial class AzureArcKubernetesDeployMappingRuleProfile : Azure.ResourceManager.HybridNetwork.Models.MappingRuleProfile
    {
        internal AzureArcKubernetesDeployMappingRuleProfile() { }
        public Azure.ResourceManager.HybridNetwork.Models.HelmMappingRuleProfile HelmMappingRuleProfile { get { throw null; } }
    }
    public partial class AzureContainerRegistryScopedTokenCredential : Azure.ResourceManager.HybridNetwork.Models.ArtifactAccessCredential
    {
        internal AzureContainerRegistryScopedTokenCredential() { }
        public System.Uri AcrServerUri { get { throw null; } }
        public string AcrToken { get { throw null; } }
        public System.DateTimeOffset? Expiry { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> Repositories { get { throw null; } }
        public string Username { get { throw null; } }
    }
    public partial class AzureCoreArmTemplateDeployMappingRuleProfile : Azure.ResourceManager.HybridNetwork.Models.MappingRuleProfile
    {
        internal AzureCoreArmTemplateDeployMappingRuleProfile() { }
        public string TemplateParameters { get { throw null; } }
    }
    public partial class AzureCoreNfviDetails : Azure.ResourceManager.HybridNetwork.Models.NFVIs
    {
        public AzureCoreNfviDetails() { }
        public Azure.Core.AzureLocation? Location { get { throw null; } set { } }
    }
    public partial class AzureCoreVhdImageDeployMappingRuleProfile : Azure.ResourceManager.HybridNetwork.Models.MappingRuleProfile
    {
        internal AzureCoreVhdImageDeployMappingRuleProfile() { }
        public string VhdImageMappingRuleUserConfiguration { get { throw null; } }
    }
    public partial class AzureOperatorNexusClusterNfviDetails : Azure.ResourceManager.HybridNetwork.Models.NFVIs
    {
        public AzureOperatorNexusClusterNfviDetails() { }
        public Azure.Core.ResourceIdentifier CustomLocationReferenceId { get { throw null; } set { } }
    }
    public partial class AzureStorageAccountContainerCredential
    {
        internal AzureStorageAccountContainerCredential() { }
        public string ContainerName { get { throw null; } }
        public System.Uri ContainerSasUri { get { throw null; } }
    }
    public partial class AzureStorageAccountCredential : Azure.ResourceManager.HybridNetwork.Models.ArtifactAccessCredential
    {
        internal AzureStorageAccountCredential() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HybridNetwork.Models.AzureStorageAccountContainerCredential> ContainerCredentials { get { throw null; } }
        public System.DateTimeOffset? Expiry { get { throw null; } }
        public string StorageAccountId { get { throw null; } }
    }
    public partial class ConfigurationGroupSchemaReferences
    {
        public ConfigurationGroupSchemaReferences() { }
        public string ConfigurationGroupSchemaName { get { throw null; } set { } }
        public string ConfigurationGroupSchemaOfferingLocation { get { throw null; } set { } }
        public string PublisherName { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.PublisherScope? PublisherScope { get { throw null; } set { } }
    }
    public partial class ConfigurationGroupSchemaVersionUpdateState
    {
        public ConfigurationGroupSchemaVersionUpdateState() { }
        public Azure.ResourceManager.HybridNetwork.Models.VersionState? VersionState { get { throw null; } set { } }
    }
    public partial class DaemonSet
    {
        internal DaemonSet() { }
        public int? Available { get { throw null; } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public int? Current { get { throw null; } }
        public int? Desired { get { throw null; } }
        public string Name { get { throw null; } }
        public string Namespace { get { throw null; } }
        public int? Ready { get { throw null; } }
        public int? UpToDate { get { throw null; } }
    }
    public partial class DependsOnProfile
    {
        public DependsOnProfile() { }
        public System.Collections.Generic.IList<string> InstallDependsOn { get { throw null; } }
        public System.Collections.Generic.IList<string> UninstallDependsOn { get { throw null; } }
        public System.Collections.Generic.IList<string> UpdateDependsOn { get { throw null; } }
    }
    public partial class Deployment
    {
        internal Deployment() { }
        public int? Available { get { throw null; } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public int? Desired { get { throw null; } }
        public string Name { get { throw null; } }
        public string Namespace { get { throw null; } }
        public int? Ready { get { throw null; } }
        public int? UpToDate { get { throw null; } }
    }
    public partial class DeploymentStatusProperties
    {
        internal DeploymentStatusProperties() { }
        public System.DateTimeOffset? NextExpectedUpdateOn { get { throw null; } }
        public Azure.ResourceManager.HybridNetwork.Models.Resources Resources { get { throw null; } }
        public Azure.ResourceManager.HybridNetwork.Models.Status? Status { get { throw null; } }
    }
    public partial class ExecuteRequestContent
    {
        public ExecuteRequestContent(string serviceEndpoint, Azure.ResourceManager.HybridNetwork.Models.RequestMetadata requestMetadata) { }
        public Azure.ResourceManager.HybridNetwork.Models.RequestMetadata RequestMetadata { get { throw null; } }
        public string ServiceEndpoint { get { throw null; } }
    }
    public partial class HelmMappingRuleProfile
    {
        internal HelmMappingRuleProfile() { }
        public string HelmPackageVersion { get { throw null; } }
        public string ReleaseName { get { throw null; } }
        public string ReleaseNamespace { get { throw null; } }
        public string Values { get { throw null; } }
    }
    public partial class HelmPackageApplicationOverview : Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionDefinitionApplicationOverview
    {
        public HelmPackageApplicationOverview() { }
        public Azure.ResourceManager.HybridNetwork.Models.AzureArcKubernetesDeployMappingRuleProfile DeployParametersMappingRuleProfile { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct HttpMethod : System.IEquatable<Azure.ResourceManager.HybridNetwork.Models.HttpMethod>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public HttpMethod(string value) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.HttpMethod Delete { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.HttpMethod Get { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.HttpMethod Patch { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.HttpMethod Post { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.HttpMethod Put { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.HttpMethod Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridNetwork.Models.HttpMethod other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridNetwork.Models.HttpMethod left, Azure.ResourceManager.HybridNetwork.Models.HttpMethod right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridNetwork.Models.HttpMethod (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridNetwork.Models.HttpMethod left, Azure.ResourceManager.HybridNetwork.Models.HttpMethod right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ManagedResourceGroupConfiguration
    {
        public ManagedResourceGroupConfiguration() { }
        public Azure.Core.AzureLocation? Location { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
    }
    public partial class ManifestArtifactFormat
    {
        public ManifestArtifactFormat() { }
        public string ArtifactName { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.ArtifactType? ArtifactType { get { throw null; } set { } }
        public string ArtifactVersion { get { throw null; } set { } }
    }
    public partial class MappingRuleProfile
    {
        internal MappingRuleProfile() { }
        public Azure.ResourceManager.HybridNetwork.Models.ApplicationEnablement? ApplicationEnablement { get { throw null; } }
    }
    public abstract partial class NetworkFunctionDefinitionApplicationOverview
    {
        protected NetworkFunctionDefinitionApplicationOverview() { }
        public string Name { get { throw null; } }
    }
    public partial class NetworkFunctionDefinitionResourceElementTemplateDetails : Azure.ResourceManager.HybridNetwork.Models.ResourceElementTemplate
    {
        public NetworkFunctionDefinitionResourceElementTemplateDetails() { }
        public Azure.ResourceManager.HybridNetwork.Models.ArmResourceDefinitionResourceElementTemplate Configuration { get { throw null; } set { } }
    }
    public partial class NetworkFunctionDefinitionVersionUpdateState
    {
        public NetworkFunctionDefinitionVersionUpdateState() { }
        public Azure.ResourceManager.HybridNetwork.Models.VersionState? VersionState { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NetworkFunctionType : System.IEquatable<Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NetworkFunctionType(string value) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionType ContainerizedNetworkFunction { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionType Unknown { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionType VirtualNetworkFunction { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionType left, Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionType right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionType left, Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NetworkServiceDesignVersionUpdateState
    {
        public NetworkServiceDesignVersionUpdateState() { }
        public Azure.ResourceManager.HybridNetwork.Models.VersionState? VersionState { get { throw null; } set { } }
    }
    public partial class NfviDetails
    {
        public NfviDetails() { }
        public string Name { get { throw null; } set { } }
        public string NfviDetailsType { get { throw null; } set { } }
    }
    public abstract partial class NFVIs
    {
        protected NFVIs() { }
        public string Name { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NfviType : System.IEquatable<Azure.ResourceManager.HybridNetwork.Models.NfviType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NfviType(string value) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.NfviType AzureArcKubernetes { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.NfviType AzureCore { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.NfviType AzureOperatorNexus { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.NfviType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridNetwork.Models.NfviType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridNetwork.Models.NfviType left, Azure.ResourceManager.HybridNetwork.Models.NfviType right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridNetwork.Models.NfviType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridNetwork.Models.NfviType left, Azure.ResourceManager.HybridNetwork.Models.NfviType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NSDArtifactProfile
    {
        public NSDArtifactProfile() { }
        public string ArtifactName { get { throw null; } set { } }
        public Azure.Core.ResourceIdentifier ArtifactStoreReferenceId { get { throw null; } set { } }
        public string ArtifactVersion { get { throw null; } set { } }
    }
    public partial class Pod
    {
        internal Pod() { }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public int? Desired { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HybridNetwork.Models.PodEvent> Events { get { throw null; } }
        public string Name { get { throw null; } }
        public string Namespace { get { throw null; } }
        public int? Ready { get { throw null; } }
        public Azure.ResourceManager.HybridNetwork.Models.PodStatus? Status { get { throw null; } }
    }
    public partial class PodEvent
    {
        internal PodEvent() { }
        public Azure.ResourceManager.HybridNetwork.Models.PodEventType? EventType { get { throw null; } }
        public System.DateTimeOffset? LastSeenOn { get { throw null; } }
        public string Message { get { throw null; } }
        public string Reason { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PodEventType : System.IEquatable<Azure.ResourceManager.HybridNetwork.Models.PodEventType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PodEventType(string value) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.PodEventType Normal { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.PodEventType Warning { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridNetwork.Models.PodEventType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridNetwork.Models.PodEventType left, Azure.ResourceManager.HybridNetwork.Models.PodEventType right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridNetwork.Models.PodEventType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridNetwork.Models.PodEventType left, Azure.ResourceManager.HybridNetwork.Models.PodEventType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PodStatus : System.IEquatable<Azure.ResourceManager.HybridNetwork.Models.PodStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PodStatus(string value) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.PodStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.PodStatus NotReady { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.PodStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.PodStatus Running { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.PodStatus Succeeded { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.PodStatus Terminating { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.PodStatus Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridNetwork.Models.PodStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridNetwork.Models.PodStatus left, Azure.ResourceManager.HybridNetwork.Models.PodStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridNetwork.Models.PodStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridNetwork.Models.PodStatus left, Azure.ResourceManager.HybridNetwork.Models.PodStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.HybridNetwork.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.ProvisioningState Accepted { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ProvisioningState Converging { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ProvisioningState Deleted { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.ProvisioningState Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridNetwork.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridNetwork.Models.ProvisioningState left, Azure.ResourceManager.HybridNetwork.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridNetwork.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridNetwork.Models.ProvisioningState left, Azure.ResourceManager.HybridNetwork.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ProxyArtifactListOverview : Azure.ResourceManager.Models.ResourceData
    {
        public ProxyArtifactListOverview() { }
    }
    public partial class ProxyArtifactVersionsListOverview : Azure.ResourceManager.Models.ResourceData
    {
        public ProxyArtifactVersionsListOverview() { }
        public Azure.ResourceManager.HybridNetwork.Models.ArtifactState? ArtifactState { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.ArtifactType? ArtifactType { get { throw null; } set { } }
        public string ArtifactVersion { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PublisherScope : System.IEquatable<Azure.ResourceManager.HybridNetwork.Models.PublisherScope>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PublisherScope(string value) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.PublisherScope Private { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.PublisherScope Public { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.PublisherScope Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridNetwork.Models.PublisherScope other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridNetwork.Models.PublisherScope left, Azure.ResourceManager.HybridNetwork.Models.PublisherScope right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridNetwork.Models.PublisherScope (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridNetwork.Models.PublisherScope left, Azure.ResourceManager.HybridNetwork.Models.PublisherScope right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ReplicaSet
    {
        internal ReplicaSet() { }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public int? Current { get { throw null; } }
        public int? Desired { get { throw null; } }
        public string Name { get { throw null; } }
        public string Namespace { get { throw null; } }
        public int? Ready { get { throw null; } }
    }
    public partial class RequestMetadata
    {
        public RequestMetadata(string relativePath, Azure.ResourceManager.HybridNetwork.Models.HttpMethod httpMethod, string serializedBody) { }
        public string ApiVersion { get { throw null; } set { } }
        public Azure.ResourceManager.HybridNetwork.Models.HttpMethod HttpMethod { get { throw null; } }
        public string RelativePath { get { throw null; } }
        public string SerializedBody { get { throw null; } }
    }
    public abstract partial class ResourceElementTemplate
    {
        protected ResourceElementTemplate() { }
        public Azure.ResourceManager.HybridNetwork.Models.DependsOnProfile DependsOnProfile { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
    }
    public partial class Resources
    {
        internal Resources() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HybridNetwork.Models.DaemonSet> DaemonSets { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HybridNetwork.Models.Deployment> Deployments { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HybridNetwork.Models.Pod> Pods { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HybridNetwork.Models.ReplicaSet> ReplicaSets { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.HybridNetwork.Models.StatefulSet> StatefulSets { get { throw null; } }
    }
    public partial class StatefulSet
    {
        internal StatefulSet() { }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public int? Desired { get { throw null; } }
        public string Name { get { throw null; } }
        public string Namespace { get { throw null; } }
        public int? Ready { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct Status : System.IEquatable<Azure.ResourceManager.HybridNetwork.Models.Status>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public Status(string value) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.Status Deployed { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.Status Downloading { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.Status Failed { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.Status Installing { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.Status PendingInstall { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.Status PendingRollback { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.Status PendingUpgrade { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.Status Reinstalling { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.Status Rollingback { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.Status Superseded { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.Status Uninstalled { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.Status Uninstalling { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.Status Unknown { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.Status Upgrading { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridNetwork.Models.Status other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridNetwork.Models.Status left, Azure.ResourceManager.HybridNetwork.Models.Status right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridNetwork.Models.Status (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridNetwork.Models.Status left, Azure.ResourceManager.HybridNetwork.Models.Status right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TagsObject
    {
        public TagsObject() { }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TemplateType : System.IEquatable<Azure.ResourceManager.HybridNetwork.Models.TemplateType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public TemplateType(string value) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.TemplateType ArmTemplate { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.TemplateType Unknown { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridNetwork.Models.TemplateType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridNetwork.Models.TemplateType left, Azure.ResourceManager.HybridNetwork.Models.TemplateType right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridNetwork.Models.TemplateType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridNetwork.Models.TemplateType left, Azure.ResourceManager.HybridNetwork.Models.TemplateType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct VersionState : System.IEquatable<Azure.ResourceManager.HybridNetwork.Models.VersionState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public VersionState(string value) { throw null; }
        public static Azure.ResourceManager.HybridNetwork.Models.VersionState Active { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.VersionState Deprecated { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.VersionState Preview { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.VersionState Unknown { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.VersionState Validating { get { throw null; } }
        public static Azure.ResourceManager.HybridNetwork.Models.VersionState ValidationFailed { get { throw null; } }
        public bool Equals(Azure.ResourceManager.HybridNetwork.Models.VersionState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.HybridNetwork.Models.VersionState left, Azure.ResourceManager.HybridNetwork.Models.VersionState right) { throw null; }
        public static implicit operator Azure.ResourceManager.HybridNetwork.Models.VersionState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.HybridNetwork.Models.VersionState left, Azure.ResourceManager.HybridNetwork.Models.VersionState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class VhdImageFileApplicationOverview : Azure.ResourceManager.HybridNetwork.Models.NetworkFunctionDefinitionApplicationOverview
    {
        public VhdImageFileApplicationOverview() { }
        public Azure.ResourceManager.HybridNetwork.Models.AzureCoreVhdImageDeployMappingRuleProfile DeployParametersMappingRuleProfile { get { throw null; } }
    }
}
