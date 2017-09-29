// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.2.22.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// HDInsight Hive activity type.
    /// </summary>
    [Newtonsoft.Json.JsonObject("HDInsightHive")]
    [Rest.Serialization.JsonTransformation]
    public partial class HDInsightHiveActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the HDInsightHiveActivity class.
        /// </summary>
        public HDInsightHiveActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HDInsightHiveActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="description">Activity description.</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        /// <param name="storageLinkedServices">Storage linked service
        /// references.</param>
        /// <param name="arguments">User specified arguments to
        /// HDInsightActivity.</param>
        /// <param name="getDebugInfo">Debug info option. Possible values
        /// include: 'None', 'Always', 'Failure'</param>
        /// <param name="scriptPath">Script path. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="scriptLinkedService">Script linked service
        /// reference.</param>
        /// <param name="defines">Allows user to specify defines for Hive job
        /// request.</param>
        public HDInsightHiveActivity(string name, string description = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), IList<LinkedServiceReference> storageLinkedServices = default(IList<LinkedServiceReference>), IList<object> arguments = default(IList<object>), string getDebugInfo = default(string), object scriptPath = default(object), LinkedServiceReference scriptLinkedService = default(LinkedServiceReference), IDictionary<string, object> defines = default(IDictionary<string, object>))
            : base(name, description, dependsOn, linkedServiceName, policy)
        {
            StorageLinkedServices = storageLinkedServices;
            Arguments = arguments;
            GetDebugInfo = getDebugInfo;
            ScriptPath = scriptPath;
            ScriptLinkedService = scriptLinkedService;
            Defines = defines;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets storage linked service references.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.storageLinkedServices")]
        public IList<LinkedServiceReference> StorageLinkedServices { get; set; }

        /// <summary>
        /// Gets or sets user specified arguments to HDInsightActivity.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.arguments")]
        public IList<object> Arguments { get; set; }

        /// <summary>
        /// Gets or sets debug info option. Possible values include: 'None',
        /// 'Always', 'Failure'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.getDebugInfo")]
        public string GetDebugInfo { get; set; }

        /// <summary>
        /// Gets or sets script path. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.scriptPath")]
        public object ScriptPath { get; set; }

        /// <summary>
        /// Gets or sets script linked service reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.scriptLinkedService")]
        public LinkedServiceReference ScriptLinkedService { get; set; }

        /// <summary>
        /// Gets or sets allows user to specify defines for Hive job request.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.defines")]
        public IDictionary<string, object> Defines { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (StorageLinkedServices != null)
            {
                foreach (var element in StorageLinkedServices)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (ScriptLinkedService != null)
            {
                ScriptLinkedService.Validate();
            }
        }
    }
}
