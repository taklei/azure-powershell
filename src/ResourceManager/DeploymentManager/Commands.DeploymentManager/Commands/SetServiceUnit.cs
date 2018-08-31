﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.DeploymentManager.Commands
{
    using System.Management.Automation;
    using Microsoft.Azure.Commands.DeploymentManager.Models;

    [Cmdlet(VerbsCommon.Set, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "DeploymentManagerServiceUnit"), OutputType(typeof(PSServiceUnitResource))]
    public class SetServiceUnit : DeploymentManagerBaseCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ValueFromPipeline = true, 
            HelpMessage = "The service unit object.")]
        [ValidateNotNullOrEmpty]
        public PSServiceUnitResource ServiceUnit { get; set; }

        public override void ExecuteCmdlet()
        {
            var topologyResource = this.DeploymentManagerClient.PutServiceUnit(this.ServiceUnit);
            this.WriteObject(topologyResource);
        }
    }
}
