// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The ARM create email sign in url operation response. </summary>
    public partial class BotCreateEmailSignInUriResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BotCreateEmailSignInUriResult"/>. </summary>
        internal BotCreateEmailSignInUriResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BotCreateEmailSignInUriResult"/>. </summary>
        /// <param name="id"> Specifies the resource ID. </param>
        /// <param name="location"> Specifies the location of the resource. </param>
        /// <param name="properties"> The set of properties specific to sign in url. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BotCreateEmailSignInUriResult(ResourceIdentifier id, AzureLocation? location, CreateEmailSignInUrlResponseProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Location = location;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies the resource ID. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Specifies the location of the resource. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The set of properties specific to sign in url. </summary>
        internal CreateEmailSignInUrlResponseProperties Properties { get; }
        /// <summary> Sign in url. </summary>
        public Uri CreateEmailSignInUrlResponseUri
        {
            get => Properties?.Uri;
        }
    }
}
