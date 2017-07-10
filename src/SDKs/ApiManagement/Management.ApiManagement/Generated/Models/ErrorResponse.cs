// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Error Body contract.
    /// </summary>
    public partial class ErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>
        public ErrorResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorResponse class.
        /// </summary>
        /// <param name="code">Service-defined error code. This code serves as
        /// a sub-status for the HTTP error code specified in the
        /// response.</param>
        /// <param name="message">Human-readable representation of the
        /// error.</param>
        /// <param name="details">The list of invalid fields send in request,
        /// in case of validation error.</param>
        public ErrorResponse(string code = default(string), string message = default(string), IList<ErrorFieldContract> details = default(IList<ErrorFieldContract>))
        {
            Code = code;
            Message = message;
            Details = details;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets service-defined error code. This code serves as a
        /// sub-status for the HTTP error code specified in the response.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets human-readable representation of the error.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the list of invalid fields send in request, in case of
        /// validation error.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<ErrorFieldContract> Details { get; set; }

    }
}
