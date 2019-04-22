// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Personalizer.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PolicyResult
    {
        /// <summary>
        /// Initializes a new instance of the PolicyResult class.
        /// </summary>
        public PolicyResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PolicyResult class.
        /// </summary>
        public PolicyResult(string name = default(string), string arguments = default(string), IList<PolicyResultSummary> summary = default(IList<PolicyResultSummary>), PolicyResultSummary totalSummary = default(PolicyResultSummary))
        {
            Name = name;
            Arguments = arguments;
            Summary = summary;
            TotalSummary = totalSummary;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "arguments")]
        public string Arguments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "summary")]
        public IList<PolicyResultSummary> Summary { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalSummary")]
        public PolicyResultSummary TotalSummary { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Summary != null)
            {
                foreach (var element in Summary)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (TotalSummary != null)
            {
                TotalSummary.Validate();
            }
        }
    }
}
