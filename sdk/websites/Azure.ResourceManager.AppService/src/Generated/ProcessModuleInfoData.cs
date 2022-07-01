// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the ProcessModuleInfo data model. </summary>
    public partial class ProcessModuleInfoData : ResourceData
    {
        /// <summary> Initializes a new instance of ProcessModuleInfoData. </summary>
        public ProcessModuleInfoData()
        {
        }

        /// <summary> Initializes a new instance of ProcessModuleInfoData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="baseAddress"> Base address. Used as module identifier in ARM resource URI. </param>
        /// <param name="fileName"> File name. </param>
        /// <param name="href"> HRef URI. </param>
        /// <param name="filePath"> File path. </param>
        /// <param name="moduleMemorySize"> Module memory size. </param>
        /// <param name="fileVersion"> File version. </param>
        /// <param name="fileDescription"> File description. </param>
        /// <param name="product"> Product name. </param>
        /// <param name="productVersion"> Product version. </param>
        /// <param name="isDebug"> Is debug?. </param>
        /// <param name="language"> Module language (locale). </param>
        /// <param name="kind"> Kind of resource. </param>
        internal ProcessModuleInfoData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string baseAddress, string fileName, string href, string filePath, int? moduleMemorySize, string fileVersion, string fileDescription, string product, string productVersion, bool? isDebug, string language, string kind) : base(id, name, resourceType, systemData)
        {
            BaseAddress = baseAddress;
            FileName = fileName;
            Href = href;
            FilePath = filePath;
            ModuleMemorySize = moduleMemorySize;
            FileVersion = fileVersion;
            FileDescription = fileDescription;
            Product = product;
            ProductVersion = productVersion;
            IsDebug = isDebug;
            Language = language;
            Kind = kind;
        }

        /// <summary> Base address. Used as module identifier in ARM resource URI. </summary>
        public string BaseAddress { get; set; }
        /// <summary> File name. </summary>
        public string FileName { get; set; }
        /// <summary> HRef URI. </summary>
        public string Href { get; set; }
        /// <summary> File path. </summary>
        public string FilePath { get; set; }
        /// <summary> Module memory size. </summary>
        public int? ModuleMemorySize { get; set; }
        /// <summary> File version. </summary>
        public string FileVersion { get; set; }
        /// <summary> File description. </summary>
        public string FileDescription { get; set; }
        /// <summary> Product name. </summary>
        public string Product { get; set; }
        /// <summary> Product version. </summary>
        public string ProductVersion { get; set; }
        /// <summary> Is debug?. </summary>
        public bool? IsDebug { get; set; }
        /// <summary> Module language (locale). </summary>
        public string Language { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
