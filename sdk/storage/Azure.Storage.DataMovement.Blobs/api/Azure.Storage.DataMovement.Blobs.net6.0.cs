namespace Azure.Storage.Blobs
{
    public static partial class BlobContainerClientExtensions
    {
        public static System.Threading.Tasks.Task<Azure.Storage.DataMovement.DataTransfer> StartDownloadToDirectoryAsync(this Azure.Storage.Blobs.BlobContainerClient client, string localDirectoryPath, Azure.Storage.Blobs.Models.BlobContainerClientTransferOptions options) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Storage.DataMovement.DataTransfer> StartDownloadToDirectoryAsync(this Azure.Storage.Blobs.BlobContainerClient client, string localDirectoryPath, string blobDirectoryPrefix = null) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Storage.DataMovement.DataTransfer> StartUploadDirectoryAsync(this Azure.Storage.Blobs.BlobContainerClient client, string localDirectoryPath, Azure.Storage.Blobs.Models.BlobContainerClientTransferOptions options) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Storage.DataMovement.DataTransfer> StartUploadDirectoryAsync(this Azure.Storage.Blobs.BlobContainerClient client, string localDirectoryPath, string blobDirectoryPrefix = null) { throw null; }
    }
}
namespace Azure.Storage.Blobs.Models
{
    public partial class BlobContainerClientTransferOptions
    {
        public BlobContainerClientTransferOptions() { }
        public Azure.Storage.DataMovement.Blobs.BlobStorageResourceContainerOptions BlobContainerOptions { get { throw null; } set { } }
        public Azure.Storage.DataMovement.TransferOptions TransferOptions { get { throw null; } set { } }
    }
}
namespace Azure.Storage.DataMovement.Blobs
{
    public partial class AppendBlobStorageResourceOptions : Azure.Storage.DataMovement.Blobs.BlobStorageResourceOptions
    {
        public AppendBlobStorageResourceOptions() { }
        public Azure.Storage.Blobs.Models.AppendBlobRequestConditions DestinationConditions { get { throw null; } set { } }
        public Azure.Storage.Blobs.Models.AppendBlobRequestConditions SourceConditions { get { throw null; } set { } }
    }
    public partial class BlobStorageResourceContainerOptions
    {
        public BlobStorageResourceContainerOptions() { }
        public Azure.Storage.Blobs.Models.BlobType BlobType { get { throw null; } set { } }
        public string DirectoryPrefix { get { throw null; } set { } }
        public Azure.Storage.DataMovement.Blobs.BlobStorageResourceOptions ResourceOptions { get { throw null; } set { } }
    }
    public partial class BlobStorageResourceOptions
    {
        public BlobStorageResourceOptions() { }
        public Azure.Storage.Blobs.Models.AccessTier? AccessTier { get { throw null; } set { } }
        public Azure.Storage.Blobs.Models.BlobImmutabilityPolicy DestinationImmutabilityPolicy { get { throw null; } set { } }
        public Azure.Storage.DownloadTransferValidationOptions DownloadTransferValidationOptions { get { throw null; } set { } }
        public Azure.Storage.Blobs.Models.BlobHttpHeaders HttpHeaders { get { throw null; } set { } }
        public bool? LegalHold { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Metadata { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } set { } }
        public Azure.Storage.UploadTransferValidationOptions UploadTransferValidationOptions { get { throw null; } set { } }
    }
    public partial class BlobStorageResourceProvider : Azure.Storage.DataMovement.StorageResourceProvider
    {
        public BlobStorageResourceProvider(Azure.Storage.DataMovement.Blobs.BlobStorageResourceProvider.GetCredentialAsync credentialProvider) { }
        protected override string TypeId { get { throw null; } }
        public Azure.Storage.DataMovement.StorageResource FromBlob(string blobUri, Azure.Storage.DataMovement.Blobs.BlobStorageResourceOptions options = null) { throw null; }
        public Azure.Storage.DataMovement.StorageResource FromClient(Azure.Storage.Blobs.BlobClient client, Azure.Storage.DataMovement.Blobs.BlobStorageResourceOptions options = null) { throw null; }
        public Azure.Storage.DataMovement.StorageResource FromClient(Azure.Storage.Blobs.BlobContainerClient client, Azure.Storage.DataMovement.Blobs.BlobStorageResourceContainerOptions options = null) { throw null; }
        public Azure.Storage.DataMovement.StorageResource FromClient(Azure.Storage.Blobs.Specialized.AppendBlobClient client, Azure.Storage.DataMovement.Blobs.AppendBlobStorageResourceOptions options = null) { throw null; }
        public Azure.Storage.DataMovement.StorageResource FromClient(Azure.Storage.Blobs.Specialized.BlobBaseClient client, Azure.Storage.DataMovement.Blobs.BlobStorageResourceOptions options = null) { throw null; }
        public Azure.Storage.DataMovement.StorageResource FromClient(Azure.Storage.Blobs.Specialized.BlockBlobClient client, Azure.Storage.DataMovement.Blobs.BlockBlobStorageResourceOptions options = null) { throw null; }
        public Azure.Storage.DataMovement.StorageResource FromClient(Azure.Storage.Blobs.Specialized.PageBlobClient client, Azure.Storage.DataMovement.Blobs.PageBlobStorageResourceOptions options = null) { throw null; }
        public Azure.Storage.DataMovement.StorageResource FromContainer(string containerUri, Azure.Storage.DataMovement.Blobs.BlobStorageResourceContainerOptions options = null) { throw null; }
        protected override Azure.Storage.DataMovement.StorageResource FromDestination(Azure.Storage.DataMovement.DataTransferProperties props) { throw null; }
        protected override Azure.Storage.DataMovement.StorageResource FromSource(Azure.Storage.DataMovement.DataTransferProperties props) { throw null; }
        public delegate System.Threading.Tasks.Task<(Azure.Storage.StorageSharedKeyCredential SharedKey, Azure.Core.TokenCredential Token, Azure.AzureSasCredential Sas)> GetCredentialAsync(string uri, bool readOnly);
    }
    public partial class BlockBlobStorageResourceOptions : Azure.Storage.DataMovement.Blobs.BlobStorageResourceOptions
    {
        public BlockBlobStorageResourceOptions() { }
        public Azure.Storage.Blobs.Models.BlobRequestConditions DestinationConditions { get { throw null; } set { } }
        public Azure.Storage.Blobs.Models.BlobRequestConditions SourceConditions { get { throw null; } set { } }
    }
    public partial class PageBlobStorageResourceOptions : Azure.Storage.DataMovement.Blobs.BlobStorageResourceOptions
    {
        public PageBlobStorageResourceOptions() { }
        public Azure.Storage.Blobs.Models.PageBlobRequestConditions DestinationConditions { get { throw null; } set { } }
        public long? SequenceNumber { get { throw null; } set { } }
        public Azure.Storage.Blobs.Models.PageBlobRequestConditions SourceConditions { get { throw null; } set { } }
    }
}
