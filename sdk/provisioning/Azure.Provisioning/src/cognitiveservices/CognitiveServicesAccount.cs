// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Azure.Provisioning.ResourceManager;
using Azure.ResourceManager.CognitiveServices;
using Azure.ResourceManager.CognitiveServices.Models;

namespace Azure.Provisioning.CognitiveServices
{
    /// <summary>
    /// Represents a Cognitive Services account.
    /// </summary>
    public class CognitiveServicesAccount : Resource<CognitiveServicesAccountData>
    {
        private const string ResourceTypeName = "Microsoft.CognitiveServices/accounts";
        private static readonly Func<string, CognitiveServicesAccountData> Empty = (name) => ArmCognitiveServicesModelFactory.CognitiveServicesAccountData();

        /// <summary>
        /// Creates a new instance of the <see cref="CognitiveServicesAccount"/> class.
        /// </summary>
        /// <param name="scope">The scope.</param>
        /// <param name="kind">The kind.</param>
        /// <param name="sku">The sku.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="name">The name.</param>
        /// <param name="version">The version.</param>
        /// <param name="location">The location.</param>
        public CognitiveServicesAccount(
            IConstruct scope,
            string? kind = default,
            CognitiveServicesSku? sku = default,
            ResourceGroup? parent = default,
            string name = "cs",
            string version = "2023-05-01",
            AzureLocation? location = default)
            : this(scope, parent, name, version, false, (name) =>
                ArmCognitiveServicesModelFactory.CognitiveServicesAccountData(
                    name: name,
                    sku: sku ?? new CognitiveServicesSku("S0"),
                    location: location ?? Environment.GetEnvironmentVariable("AZURE_LOCATION") ?? AzureLocation.WestUS,
                    kind: kind ?? "OpenAI",
                    properties: new CognitiveServicesAccountProperties()))
        {
            AssignProperty(data => data.Name, GetAzureName(scope, name));
        }

        private CognitiveServicesAccount(
            IConstruct scope,
            ResourceGroup? parent = default,
            string name = "cosmosDB",
            string version = "2023-04-15",
            bool isExisting = false,
            Func<string, CognitiveServicesAccountData>? creator = null)
            : base(scope, parent, name, ResourceTypeName, version, creator ?? Empty, isExisting)
        {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="CognitiveServicesAccount"/> class referencing an existing instance.
        /// </summary>
        /// <param name="scope">The scope.</param>
        /// <param name="name">The resource name.</param>
        /// <param name="parent">The resource group.</param>
        /// <returns>The KeyVault instance.</returns>
        public static CognitiveServicesAccount FromExisting(IConstruct scope, string name, ResourceGroup? parent = null)
            => new CognitiveServicesAccount(scope, parent: parent, name: name, isExisting: true);

        /// <inheritdoc/>
        protected override string GetAzureName(IConstruct scope, string resourceName) => GetGloballyUniqueName(resourceName);
    }
}
