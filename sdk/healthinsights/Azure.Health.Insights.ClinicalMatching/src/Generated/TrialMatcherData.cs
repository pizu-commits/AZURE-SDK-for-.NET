// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary> The body of the Trial Matcher request. </summary>
    public partial class TrialMatcherData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of TrialMatcherData. </summary>
        /// <param name="patients"> The list of patients, including their clinical information and data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="patients"/> is null. </exception>
        public TrialMatcherData(IEnumerable<PatientRecord> patients)
        {
            Argument.AssertNotNull(patients, nameof(patients));

            Patients = patients.ToList();
        }

        /// <summary> Initializes a new instance of TrialMatcherData. </summary>
        /// <param name="patients"> The list of patients, including their clinical information and data. </param>
        /// <param name="configuration"> Configuration affecting the Trial Matcher model's inference. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TrialMatcherData(IList<PatientRecord> patients, TrialMatcherModelConfiguration configuration, Dictionary<string, BinaryData> rawData)
        {
            Patients = patients;
            Configuration = configuration;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="TrialMatcherData"/> for deserialization. </summary>
        internal TrialMatcherData()
        {
        }

        /// <summary> The list of patients, including their clinical information and data. </summary>
        public IList<PatientRecord> Patients { get; }
        /// <summary> Configuration affecting the Trial Matcher model's inference. </summary>
        public TrialMatcherModelConfiguration Configuration { get; set; }
    }
}
