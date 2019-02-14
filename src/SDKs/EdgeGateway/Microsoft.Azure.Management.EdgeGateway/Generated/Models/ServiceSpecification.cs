// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EdgeGateway.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Service specification.
    /// </summary>
    public partial class ServiceSpecification
    {
        /// <summary>
        /// Initializes a new instance of the ServiceSpecification class.
        /// </summary>
        public ServiceSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceSpecification class.
        /// </summary>
        /// <param name="metricSpecifications">Metric specification as defined
        /// by shoebox.</param>
        public ServiceSpecification(IList<MetricSpecificationV1> metricSpecifications = default(IList<MetricSpecificationV1>))
        {
            MetricSpecifications = metricSpecifications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets metric specification as defined by shoebox.
        /// </summary>
        [JsonProperty(PropertyName = "metricSpecifications")]
        public IList<MetricSpecificationV1> MetricSpecifications { get; set; }

    }
}
