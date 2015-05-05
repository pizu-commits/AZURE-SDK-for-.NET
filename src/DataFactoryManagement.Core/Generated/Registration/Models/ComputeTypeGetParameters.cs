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

namespace Microsoft.Azure.Management.DataFactories.Registration.Models
{
    /// <summary>
    /// Parameters specifying how to return a ComputeType definition for a Get
    /// operation.
    /// </summary>
    public partial class ComputeTypeGetParameters
    {
        private string _computeTypeName;
        
        /// <summary>
        /// Required. A ComputeType name.
        /// </summary>
        public string ComputeTypeName
        {
            get { return this._computeTypeName; }
            set { this._computeTypeName = value; }
        }
        
        private string _registrationScope;
        
        /// <summary>
        /// Required. The scope for which to get a ComputeType definition.
        /// </summary>
        public string RegistrationScope
        {
            get { return this._registrationScope; }
            set { this._registrationScope = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ComputeTypeGetParameters class.
        /// </summary>
        public ComputeTypeGetParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the ComputeTypeGetParameters class
        /// with required arguments.
        /// </summary>
        public ComputeTypeGetParameters(string registrationScope, string computeTypeName)
            : this()
        {
            if (registrationScope == null)
            {
                throw new ArgumentNullException("registrationScope");
            }
            if (computeTypeName == null)
            {
                throw new ArgumentNullException("computeTypeName");
            }
            this.RegistrationScope = registrationScope;
            this.ComputeTypeName = computeTypeName;
        }
    }
}
