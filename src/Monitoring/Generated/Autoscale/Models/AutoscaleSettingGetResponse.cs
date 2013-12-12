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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Monitoring.Autoscale.Models;

namespace Microsoft.WindowsAzure.Management.Monitoring.Autoscale.Models
{
    /// <summary>
    /// A standard service response including an HTTP status code and request
    /// ID.
    /// </summary>
    public partial class AutoscaleSettingGetResponse : OperationResponse
    {
        private AutoscaleSetting _setting;
        
        public AutoscaleSetting Setting
        {
            get { return this._setting; }
            set { this._setting = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AutoscaleSettingGetResponse class.
        /// </summary>
        public AutoscaleSettingGetResponse()
        {
        }
    }
}
