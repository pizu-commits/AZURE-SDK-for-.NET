// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure;

namespace Microsoft.WindowsAzure.Management.RecoveryServicesVaultUpgrade.Models
{
    /// <summary>
    /// The definition of a resource upgrade output object.
    /// </summary>
    public partial class ResourceUpgradeDetails : AzureOperationResponse
    {
        private DateTime _endTimeUtc;
        
        /// <summary>
        /// Optional. Operation end time.
        /// </summary>
        public DateTime EndTimeUtc
        {
            get { return this._endTimeUtc; }
            set { this._endTimeUtc = value; }
        }
        
        private DateTime _lastUpdatedTimeUtc;
        
        /// <summary>
        /// Optional. Resource last updated time.
        /// </summary>
        public DateTime LastUpdatedTimeUtc
        {
            get { return this._lastUpdatedTimeUtc; }
            set { this._lastUpdatedTimeUtc = value; }
        }
        
        private string _message;
        
        /// <summary>
        /// Optional. Message.
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }
        
        private string _operationId;
        
        /// <summary>
        /// Optional. Resource upgarde operation Id.
        /// </summary>
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }
        
        private DateTime _startTimeUtc;
        
        /// <summary>
        /// Optional. Operation start time.
        /// </summary>
        public DateTime StartTimeUtc
        {
            get { return this._startTimeUtc; }
            set { this._startTimeUtc = value; }
        }
        
        private string _status;
        
        /// <summary>
        /// Optional. Resource upgrade state.
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private string _triggerType;
        
        /// <summary>
        /// Optional. If the resource upgrade is user triggered or forcefully
        /// started.
        /// </summary>
        public string TriggerType
        {
            get { return this._triggerType; }
            set { this._triggerType = value; }
        }
        
        private string _upgradedResourceId;
        
        /// <summary>
        /// Optional. Upgraded resource id.
        /// </summary>
        public string UpgradedResourceId
        {
            get { return this._upgradedResourceId; }
            set { this._upgradedResourceId = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ResourceUpgradeDetails class.
        /// </summary>
        public ResourceUpgradeDetails()
        {
        }
    }
}
