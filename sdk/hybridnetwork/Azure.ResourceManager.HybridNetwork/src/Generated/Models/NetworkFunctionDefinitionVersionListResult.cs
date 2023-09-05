// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> A list of network function definition versions. </summary>
    internal partial class NetworkFunctionDefinitionVersionListResult
    {
        /// <summary> Initializes a new instance of NetworkFunctionDefinitionVersionListResult. </summary>
        internal NetworkFunctionDefinitionVersionListResult()
        {
            Value = new ChangeTrackingList<HybridNetwork.NetworkFunctionDefinitionVersionData>();
        }

        /// <summary> Initializes a new instance of NetworkFunctionDefinitionVersionListResult. </summary>
        /// <param name="value"> A list of network function definition versions. </param>
        /// <param name="nextLink"> The URI to get the next set of results. </param>
        internal NetworkFunctionDefinitionVersionListResult(IReadOnlyList<HybridNetwork.NetworkFunctionDefinitionVersionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of network function definition versions. </summary>
        public IReadOnlyList<HybridNetwork.NetworkFunctionDefinitionVersionData> Value { get; }
        /// <summary> The URI to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
