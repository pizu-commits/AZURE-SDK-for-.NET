// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> DatabricksSparkJar activity. </summary>
    public partial class DatabricksSparkJarActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of <see cref="DatabricksSparkJarActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="mainClassName"> The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="mainClassName"/> is null. </exception>
        public DatabricksSparkJarActivity(string name, object mainClassName) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(mainClassName, nameof(mainClassName));

            MainClassName = mainClassName;
            Parameters = new ChangeTrackingList<object>();
            Libraries = new ChangeTrackingList<IDictionary<string, object>>();
            Type = "DatabricksSparkJar";
        }

        /// <summary> Initializes a new instance of <see cref="DatabricksSparkJarActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="mainClassName"> The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. Type: string (or Expression with resultType string). </param>
        /// <param name="parameters"> Parameters that will be passed to the main method. </param>
        /// <param name="libraries"> A list of libraries to be installed on the cluster that will execute the job. </param>
        internal DatabricksSparkJarActivity(string name, string type, string description, ActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, object mainClassName, IList<object> parameters, IList<IDictionary<string, object>> libraries) : base(name, type, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            MainClassName = mainClassName;
            Parameters = parameters;
            Libraries = libraries;
            Type = type ?? "DatabricksSparkJar";
        }

        /// <summary> The full name of the class containing the main method to be executed. This class must be contained in a JAR provided as a library. Type: string (or Expression with resultType string). </summary>
        public object MainClassName { get; set; }
        /// <summary> Parameters that will be passed to the main method. </summary>
        public IList<object> Parameters { get; }
        /// <summary> A list of libraries to be installed on the cluster that will execute the job. </summary>
        public IList<IDictionary<string, object>> Libraries { get; }
    }
}
