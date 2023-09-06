// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary>
    /// Source with uploaded location
    /// Please note <see cref="AppPlatformUploadedUserSourceInfo"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="JarUploadedUserSourceInfo"/>, <see cref="NetCoreZipUploadedUserSourceInfo"/> and <see cref="SourceUploadedUserSourceInfo"/>.
    /// </summary>
    public partial class AppPlatformUploadedUserSourceInfo : AppPlatformUserSourceInfo
    {
        /// <summary> Initializes a new instance of <see cref="AppPlatformUploadedUserSourceInfo"/>. </summary>
        public AppPlatformUploadedUserSourceInfo()
        {
            UserSourceInfoType = "UploadedUserSourceInfo";
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformUploadedUserSourceInfo"/>. </summary>
        /// <param name="userSourceInfoType"> Type of the source uploaded. </param>
        /// <param name="version"> Version of the source. </param>
        /// <param name="relativePath"> Relative path of the storage which stores the source. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformUploadedUserSourceInfo(string userSourceInfoType, string version, string relativePath, Dictionary<string, BinaryData> rawData) : base(userSourceInfoType, version, rawData)
        {
            RelativePath = relativePath;
            UserSourceInfoType = userSourceInfoType ?? "UploadedUserSourceInfo";
        }

        /// <summary> Relative path of the storage which stores the source. </summary>
        public string RelativePath { get; set; }
    }
}
