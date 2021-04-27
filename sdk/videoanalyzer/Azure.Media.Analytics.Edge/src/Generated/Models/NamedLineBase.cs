// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Describes the named line. </summary>
    public partial class NamedLineBase
    {
        /// <summary> Initializes a new instance of NamedLineBase. </summary>
        /// <param name="name"> The name of the line. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public NamedLineBase(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        /// <summary> Initializes a new instance of NamedLineBase. </summary>
        /// <param name="type"> The discriminator for derived types. </param>
        /// <param name="name"> The name of the line. </param>
        internal NamedLineBase(string type, string name)
        {
            Type = type;
            Name = name;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string Type { get; set; }
        /// <summary> The name of the line. </summary>
        public string Name { get; set; }
    }
}
