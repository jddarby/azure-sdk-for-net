// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The UnknownVirtualNetworkFunctionTemplate. </summary>
    internal partial class UnknownVirtualNetworkFunctionTemplate : VirtualNetworkFunctionTemplate
    {
        /// <summary> Initializes a new instance of UnknownVirtualNetworkFunctionTemplate. </summary>
        /// <param name="nfviType"> The network function type. </param>
        internal UnknownVirtualNetworkFunctionTemplate(VirtualNetworkFunctionNfviType nfviType) : base(nfviType)
        {
            NfviType = nfviType;
        }
    }
}
