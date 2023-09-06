// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure virtual network function template. </summary>
    internal partial class AzureCoreNetworkFunctionTemplate : VirtualNetworkFunctionTemplate
    {
        /// <summary> Initializes a new instance of AzureCoreNetworkFunctionTemplate. </summary>
        internal AzureCoreNetworkFunctionTemplate()
        {
            NetworkFunctionApplications = new ChangeTrackingList<AzureCoreNetworkFunctionApplication>();
            NfviType = VirtualNetworkFunctionNfviType.AzureCore;
        }

        /// <summary>
        /// Network function applications.
        /// Please note <see cref="AzureCoreNetworkFunctionApplication"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureCoreNetworkFunctionArmTemplateApplication"/> and <see cref="AzureCoreNetworkFunctionVhdApplication"/>.
        /// </summary>
        public IReadOnlyList<AzureCoreNetworkFunctionApplication> NetworkFunctionApplications { get; }
    }
}
