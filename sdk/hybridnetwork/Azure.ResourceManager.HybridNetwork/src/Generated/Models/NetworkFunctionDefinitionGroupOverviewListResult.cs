// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> A list of available network function definition groups. </summary>
    internal partial class NetworkFunctionDefinitionGroupOverviewListResult
    {
        /// <summary> Initializes a new instance of NetworkFunctionDefinitionGroupOverviewListResult. </summary>
        internal NetworkFunctionDefinitionGroupOverviewListResult()
        {
            Value = new ChangeTrackingList<NetworkFunctionDefinitionGroupOverviewData>();
        }

        /// <summary> Initializes a new instance of NetworkFunctionDefinitionGroupOverviewListResult. </summary>
        /// <param name="value"> The network function group list properties. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal NetworkFunctionDefinitionGroupOverviewListResult(IReadOnlyList<NetworkFunctionDefinitionGroupOverviewData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The network function group list properties. </summary>
        public IReadOnlyList<NetworkFunctionDefinitionGroupOverviewData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
