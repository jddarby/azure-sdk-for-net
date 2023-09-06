// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork.Models;

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary>
    /// A class representing the UnknownNetworkFunctionDefinitionVersionData data model.
    /// Unknown network function definition version.
    /// </summary>

    public partial class UnknownNetworkFunctionDefinitionVersionData : NetworkFunctionDefinitionVersionData
    {
        /// <summary> Initializes a new instance of UnknownNetworkFunctionDefinitionVersionData. </summary>
        /// <param name="location"> The location. </param>
        public UnknownNetworkFunctionDefinitionVersionData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of NetworkFunctionDefinitionVersionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the network function definition version resource. </param>
        /// <param name="versionState"> The network function definition version state. </param>
        /// <param name="description"> The network function definition version description. </param>
        /// <param name="deployParameters"> The deployment parameters of the network function definition version. </param>
        /// <param name="networkFunctionType"> The network function type. </param>
        internal UnknownNetworkFunctionDefinitionVersionData(ResourceIdentifier id, string name, ResourceType resourceType, Azure.ResourceManager.Models.SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ProvisioningState? provisioningState, VersionState? versionState, string description, string deployParameters, NetworkFunctionType? networkFunctionType) : base(id, name, resourceType, systemData, tags, location, provisioningState, versionState, description, deployParameters, networkFunctionType)
        {
        }
    }
}
