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

namespace Microsoft.WindowsAzure.Management.Sql.Models
{
    /// <summary>
    /// Represents the parameters for the Create Firewall Rule operation.
    /// </summary>
    public partial class FirewallRuleCreateParameters
    {
        private string _endIPAddress;
        
        /// <summary>
        /// Required. Gets or sets the ending IP address for the new Firewall
        /// Rule.
        /// </summary>
        public string EndIPAddress
        {
            get { return this._endIPAddress; }
            set { this._endIPAddress = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Required. Gets or sets the name for the new Firewall Rule.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _startIPAddress;
        
        /// <summary>
        /// Required. Gets or sets the beginning IP address for the new
        /// Firewall Rule.
        /// </summary>
        public string StartIPAddress
        {
            get { return this._startIPAddress; }
            set { this._startIPAddress = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the FirewallRuleCreateParameters
        /// class.
        /// </summary>
        public FirewallRuleCreateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the FirewallRuleCreateParameters
        /// class with required arguments.
        /// </summary>
        public FirewallRuleCreateParameters(string name, string startIPAddress, string endIPAddress)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            if (startIPAddress == null)
            {
                throw new ArgumentNullException("startIPAddress");
            }
            if (endIPAddress == null)
            {
                throw new ArgumentNullException("endIPAddress");
            }
            this.Name = name;
            this.StartIPAddress = startIPAddress;
            this.EndIPAddress = endIPAddress;
        }
    }
}
