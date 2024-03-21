// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Defines parameters for a search index that influence scoring in search queries. </summary>
    public partial class ScoringProfile
    {
        /// <summary> Initializes a new instance of <see cref="ScoringProfile"/>. </summary>
        /// <param name="name"> The name of the scoring profile. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ScoringProfile(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Functions = new ChangeTrackingList<ScoringFunction>();
        }

        /// <summary> Initializes a new instance of <see cref="ScoringProfile"/>. </summary>
        /// <param name="name"> The name of the scoring profile. </param>
        /// <param name="textWeights"> Parameters that boost scoring based on text matches in certain index fields. </param>
        /// <param name="functions">
        /// The collection of functions that influence the scoring of documents.
        /// Please note <see cref="ScoringFunction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DistanceScoringFunction"/>, <see cref="FreshnessScoringFunction"/>, <see cref="MagnitudeScoringFunction"/> and <see cref="TagScoringFunction"/>.
        /// </param>
        /// <param name="functionAggregation"> A value indicating how the results of individual scoring functions should be combined. Defaults to "Sum". Ignored if there are no scoring functions. </param>
        internal ScoringProfile(string name, TextWeights textWeights, IList<ScoringFunction> functions, ScoringFunctionAggregation? functionAggregation)
        {
            Name = name;
            TextWeights = textWeights;
            Functions = functions;
            FunctionAggregation = functionAggregation;
        }

        /// <summary> The name of the scoring profile. </summary>
        public string Name { get; set; }
        /// <summary> Parameters that boost scoring based on text matches in certain index fields. </summary>
        public TextWeights TextWeights { get; set; }
        /// <summary> A value indicating how the results of individual scoring functions should be combined. Defaults to "Sum". Ignored if there are no scoring functions. </summary>
        public ScoringFunctionAggregation? FunctionAggregation { get; set; }
    }
}
