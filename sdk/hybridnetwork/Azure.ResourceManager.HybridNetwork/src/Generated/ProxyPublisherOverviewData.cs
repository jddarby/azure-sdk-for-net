// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary>
    /// A class representing the ProxyPublisherOverview data model.
    /// The proxy publisher overview.
    /// </summary>
    public partial class ProxyPublisherOverviewData : ResourceData
    {
        /// <summary> Initializes a new instance of ProxyPublisherOverviewData. </summary>
        public ProxyPublisherOverviewData()
        {
        }

        /// <summary> Initializes a new instance of ProxyPublisherOverviewData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        internal ProxyPublisherOverviewData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData) : base(id, name, resourceType, systemData)
        {
        }
    }
}
