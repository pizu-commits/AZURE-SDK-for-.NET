// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the ContinuousWebJob data model. </summary>
    public partial class ContinuousWebJobData : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of ContinuousWebJobData. </summary>
        public ContinuousWebJobData()
        {
            Settings = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of ContinuousWebJobData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="status"> Job status. </param>
        /// <param name="detailedStatus"> Detailed status. </param>
        /// <param name="logUrl"> Log URL. </param>
        /// <param name="runCommand"> Run command. </param>
        /// <param name="url"> Job URL. </param>
        /// <param name="extraInfoUrl"> Extra Info URL. </param>
        /// <param name="webJobType"> Job type. </param>
        /// <param name="error"> Error information. </param>
        /// <param name="usingSdk"> Using SDK?. </param>
        /// <param name="settings"> Job settings. </param>
        internal ContinuousWebJobData(ResourceIdentifier id, string name, ResourceType type, string kind, ContinuousWebJobStatus? status, string detailedStatus, string logUrl, string runCommand, string url, string extraInfoUrl, WebJobType? webJobType, string error, bool? usingSdk, IDictionary<string, object> settings) : base(id, name, type, kind)
        {
            Status = status;
            DetailedStatus = detailedStatus;
            LogUrl = logUrl;
            RunCommand = runCommand;
            Url = url;
            ExtraInfoUrl = extraInfoUrl;
            WebJobType = webJobType;
            Error = error;
            UsingSdk = usingSdk;
            Settings = settings;
        }

        /// <summary> Job status. </summary>
        public ContinuousWebJobStatus? Status { get; set; }
        /// <summary> Detailed status. </summary>
        public string DetailedStatus { get; set; }
        /// <summary> Log URL. </summary>
        public string LogUrl { get; set; }
        /// <summary> Run command. </summary>
        public string RunCommand { get; set; }
        /// <summary> Job URL. </summary>
        public string Url { get; set; }
        /// <summary> Extra Info URL. </summary>
        public string ExtraInfoUrl { get; set; }
        /// <summary> Job type. </summary>
        public WebJobType? WebJobType { get; set; }
        /// <summary> Error information. </summary>
        public string Error { get; set; }
        /// <summary> Using SDK?. </summary>
        public bool? UsingSdk { get; set; }
        /// <summary> Job settings. </summary>
        public IDictionary<string, object> Settings { get; }
    }
}
