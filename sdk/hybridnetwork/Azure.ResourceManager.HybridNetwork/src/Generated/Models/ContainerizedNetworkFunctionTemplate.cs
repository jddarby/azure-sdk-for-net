// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary>
    /// Containerized network function template.
    /// Please note <see cref="ContainerizedNetworkFunctionTemplate"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzureArcKubernetesNetworkFunctionTemplate"/>.
    /// </summary>
    public abstract partial class ContainerizedNetworkFunctionTemplate
    {
        /// <summary> Initializes a new instance of ContainerizedNetworkFunctionTemplate. </summary>
        protected ContainerizedNetworkFunctionTemplate()
        {
        }

        /// <summary> Initializes a new instance of ContainerizedNetworkFunctionTemplate. </summary>
        /// <param name="nfviType"> The network function type. </param>
        internal ContainerizedNetworkFunctionTemplate(ContainerizedNetworkFunctionNfviType nfviType)
        {
            NfviType = nfviType;
        }

        /// <summary> The network function type. </summary>
        internal ContainerizedNetworkFunctionNfviType NfviType { get; set; }
    }
}
