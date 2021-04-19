// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> List of tag details. </summary>
    internal partial class TagList
    {
        /// <summary> Initializes a new instance of TagList. </summary>
        /// <param name="repository"> Image name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="repository"/> is null. </exception>
        internal TagList(string repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException(nameof(repository));
            }

            Repository = repository;
            TagAttributeBases = new ChangeTrackingList<TagAttributesBase>();
        }

        /// <summary> Initializes a new instance of TagList. </summary>
        /// <param name="repository"> Image name. </param>
        /// <param name="tagAttributeBases"> List of tag attribute details. </param>
        /// <param name="link"> . </param>
        internal TagList(string repository, IReadOnlyList<TagAttributesBase> tagAttributeBases, string link)
        {
            Repository = repository;
            TagAttributeBases = tagAttributeBases;
            Link = link;
        }

        /// <summary> Image name. </summary>
        public string Repository { get; }
        /// <summary> List of tag attribute details. </summary>
        public IReadOnlyList<TagAttributesBase> TagAttributeBases { get; }
        public string Link { get; }
    }
}
