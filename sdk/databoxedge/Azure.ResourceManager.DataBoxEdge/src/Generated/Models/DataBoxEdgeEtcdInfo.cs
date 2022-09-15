// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Etcd configuration. </summary>
    public partial class DataBoxEdgeEtcdInfo
    {
        /// <summary> Initializes a new instance of DataBoxEdgeEtcdInfo. </summary>
        internal DataBoxEdgeEtcdInfo()
        {
        }

        /// <summary> Initializes a new instance of DataBoxEdgeEtcdInfo. </summary>
        /// <param name="etcdInfoType"> Etcd type. </param>
        /// <param name="version"> Etcd version. </param>
        internal DataBoxEdgeEtcdInfo(string etcdInfoType, string version)
        {
            EtcdInfoType = etcdInfoType;
            Version = version;
        }

        /// <summary> Etcd type. </summary>
        public string EtcdInfoType { get; }
        /// <summary> Etcd version. </summary>
        public string Version { get; }
    }
}
