// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary>
    /// Virtual network function template.
    /// Please note <see cref="VirtualNetworkFunctionTemplate"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureCoreNetworkFunctionTemplate"/> and <see cref="AzureOperatorNexusNetworkFunctionTemplate"/>.
    /// </summary>
    internal abstract partial class VirtualNetworkFunctionTemplate
    {
        /// <summary> Initializes a new instance of VirtualNetworkFunctionTemplate. </summary>
        protected VirtualNetworkFunctionTemplate()
        {
        }

        /// <summary> The network function type. </summary>
        internal VirtualNetworkFunctionNfviType NfviType { get; set; }
    }
}
