// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    /// <summary>
    /// A location given as a combination of city, state and country/region. It could specify a city, a state or a country/region.
    /// In case a city is specified, either state +country/region or country/region (for countries/regions where there are no states) should be added.
    /// In case a state is specified (without a city), country/region should be added.
    /// </summary>
    public partial class GeographicLocation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of GeographicLocation. </summary>
        /// <param name="countryOrRegion"> Country/region name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="countryOrRegion"/> is null. </exception>
        public GeographicLocation(string countryOrRegion)
        {
            Argument.AssertNotNull(countryOrRegion, nameof(countryOrRegion));

            CountryOrRegion = countryOrRegion;
        }

        /// <summary> Initializes a new instance of GeographicLocation. </summary>
        /// <param name="city"> City name. </param>
        /// <param name="state"> State name. </param>
        /// <param name="countryOrRegion"> Country/region name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GeographicLocation(string city, string state, string countryOrRegion, Dictionary<string, BinaryData> rawData)
        {
            City = city;
            State = state;
            CountryOrRegion = countryOrRegion;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="GeographicLocation"/> for deserialization. </summary>
        internal GeographicLocation()
        {
        }

        /// <summary> City name. </summary>
        public string City { get; set; }
        /// <summary> State name. </summary>
        public string State { get; set; }
        /// <summary> Country/region name. </summary>
        public string CountryOrRegion { get; }
    }
}
