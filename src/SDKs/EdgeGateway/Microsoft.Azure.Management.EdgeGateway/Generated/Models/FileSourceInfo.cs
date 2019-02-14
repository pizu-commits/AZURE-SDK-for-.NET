// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EdgeGateway.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// File source details.
    /// </summary>
    public partial class FileSourceInfo
    {
        /// <summary>
        /// Initializes a new instance of the FileSourceInfo class.
        /// </summary>
        public FileSourceInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileSourceInfo class.
        /// </summary>
        /// <param name="shareId">File share ID.</param>
        public FileSourceInfo(string shareId)
        {
            ShareId = shareId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets file share ID.
        /// </summary>
        [JsonProperty(PropertyName = "shareId")]
        public string ShareId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ShareId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ShareId");
            }
        }
    }
}
