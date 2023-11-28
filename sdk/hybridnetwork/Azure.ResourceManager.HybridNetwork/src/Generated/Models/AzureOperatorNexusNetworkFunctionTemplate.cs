// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure Operator Distributed Services network function template. </summary>
    public partial class AzureOperatorNexusNetworkFunctionTemplate : VirtualNetworkFunctionTemplate
    {
        /// <summary> Initializes a new instance of <see cref="AzureOperatorNexusNetworkFunctionTemplate"/>. </summary>
        public AzureOperatorNexusNetworkFunctionTemplate()
        {
            NetworkFunctionApplications = new ChangeTrackingList<AzureOperatorNexusNetworkFunctionApplication>();
            NfviType = VirtualNetworkFunctionNfviType.AzureOperatorNexus;
        }

        /// <summary> Initializes a new instance of <see cref="AzureOperatorNexusNetworkFunctionTemplate"/>. </summary>
        /// <param name="nfviType"> The network function type. </param>
        /// <param name="networkFunctionApplications">
        /// Network function applications.
        /// Please note <see cref="AzureOperatorNexusNetworkFunctionApplication"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureOperatorNexusNetworkFunctionArmTemplateApplication"/> and <see cref="AzureOperatorNexusNetworkFunctionImageApplication"/>.
        /// </param>
        internal AzureOperatorNexusNetworkFunctionTemplate(VirtualNetworkFunctionNfviType nfviType, IList<AzureOperatorNexusNetworkFunctionApplication> networkFunctionApplications) : base(nfviType)
        {
            NetworkFunctionApplications = networkFunctionApplications;
            NfviType = nfviType;
        }

        /// <summary>
        /// Network function applications.
        /// Please note <see cref="AzureOperatorNexusNetworkFunctionApplication"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureOperatorNexusNetworkFunctionArmTemplateApplication"/> and <see cref="AzureOperatorNexusNetworkFunctionImageApplication"/>.
        /// </summary>
        public IList<AzureOperatorNexusNetworkFunctionApplication> NetworkFunctionApplications { get; }
    }
}
