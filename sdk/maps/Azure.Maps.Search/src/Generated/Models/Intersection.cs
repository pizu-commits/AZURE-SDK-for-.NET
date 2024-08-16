// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Maps.Search.Models
{
    /// <summary> The address of the result. </summary>
    public partial class Intersection
    {
        /// <summary> Initializes a new instance of <see cref="Intersection"/>. </summary>
        internal Intersection()
        {
        }

        /// <summary> Initializes a new instance of <see cref="Intersection"/>. </summary>
        /// <param name="baseStreet"> Primary street for the location. </param>
        /// <param name="secondaryStreet1"> The first intersecting street. </param>
        /// <param name="secondaryStreet2"> If any, the second intersecting street. </param>
        /// <param name="intersectionType"> Type of intersection. </param>
        /// <param name="displayName"> Complete name of the intersection. </param>
        internal Intersection(string baseStreet, string secondaryStreet1, string secondaryStreet2, string intersectionType, string displayName)
        {
            BaseStreet = baseStreet;
            SecondaryStreet1 = secondaryStreet1;
            SecondaryStreet2 = secondaryStreet2;
            IntersectionType = intersectionType;
            DisplayName = displayName;
        }

        /// <summary> Primary street for the location. </summary>
        public string BaseStreet { get; }
        /// <summary> The first intersecting street. </summary>
        public string SecondaryStreet1 { get; }
        /// <summary> If any, the second intersecting street. </summary>
        public string SecondaryStreet2 { get; }
        /// <summary> Type of intersection. </summary>
        public string IntersectionType { get; }
        /// <summary> Complete name of the intersection. </summary>
        public string DisplayName { get; }
    }
}
