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
    /// <summary> The results of the model's work for a single patient. </summary>
    public partial class TrialMatcherPatientResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of TrialMatcherPatientResult. </summary>
        /// <param name="id"> The identifier given for the patient in the request. </param>
        /// <param name="inferences"> The model's inferences for the given patient. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="inferences"/> is null. </exception>
        internal TrialMatcherPatientResult(string id, IEnumerable<TrialMatcherInference> inferences)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(inferences, nameof(inferences));

            Id = id;
            Inferences = inferences.ToList();
            NeededClinicalInfo = new ChangeTrackingList<ExtendedClinicalCodedElement>();
        }

        /// <summary> Initializes a new instance of TrialMatcherPatientResult. </summary>
        /// <param name="id"> The identifier given for the patient in the request. </param>
        /// <param name="inferences"> The model's inferences for the given patient. </param>
        /// <param name="neededClinicalInfo"> Clinical information which is needed to provide better trial matching results for the patient. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TrialMatcherPatientResult(string id, IReadOnlyList<TrialMatcherInference> inferences, IReadOnlyList<ExtendedClinicalCodedElement> neededClinicalInfo, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Inferences = inferences;
            NeededClinicalInfo = neededClinicalInfo;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="TrialMatcherPatientResult"/> for deserialization. </summary>
        internal TrialMatcherPatientResult()
        {
        }

        /// <summary> The identifier given for the patient in the request. </summary>
        public string Id { get; }
        /// <summary> The model's inferences for the given patient. </summary>
        public IReadOnlyList<TrialMatcherInference> Inferences { get; }
        /// <summary> Clinical information which is needed to provide better trial matching results for the patient. </summary>
        public IReadOnlyList<ExtendedClinicalCodedElement> NeededClinicalInfo { get; }
    }
}
