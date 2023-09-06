// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork
{
    /// <summary>
    /// A class representing the SiteNetworkService data model.
    /// Site network service resource.
    /// </summary>
    public partial class SiteNetworkServiceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of SiteNetworkServiceData. </summary>
        /// <param name="location"> The location. </param>
        public SiteNetworkServiceData(AzureLocation location) : base(location)
        {
            DesiredStateConfigurationGroupValueReferences = new ChangeTrackingDictionary<string, WritableSubResource>();
            LastStateConfigurationGroupValueReferences = new ChangeTrackingDictionary<string, WritableSubResource>();
        }

        /// <summary> Initializes a new instance of SiteNetworkServiceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The managed identity of the Site network service, if configured. </param>
        /// <param name="sku"> Sku of the site network service. </param>
        /// <param name="provisioningState"> The provisioning state of the site network service resource. </param>
        /// <param name="managedResourceGroupConfiguration"> Managed resource group configuration. </param>
        /// <param name="siteReference"> The site details. </param>
        /// <param name="publisherName"> The publisher name for the site network service. </param>
        /// <param name="publisherScope"> The scope of the publisher. </param>
        /// <param name="networkServiceDesignGroupName"> The network service design group name for the site network service. </param>
        /// <param name="networkServiceDesignVersionName"> The network service design version for the site network service. </param>
        /// <param name="networkServiceDesignVersionOfferingLocation"> The location of the network service design offering. </param>
        /// <param name="desiredStateConfigurationGroupValueReferences"> The goal state of the site network service resource. This has references to the configuration group value objects that describe the desired state of the site network service. </param>
        /// <param name="lastStateNetworkServiceDesignVersionName"> The network service design version for the site network service. </param>
        /// <param name="lastStateConfigurationGroupValueReferences"> The last state of the site network service resource. </param>
        internal SiteNetworkServiceData(ResourceIdentifier id, string name, ResourceType resourceType, ResourceManager.Models.SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, HybridNetworkSku sku, ProvisioningState? provisioningState, ManagedResourceGroupConfiguration managedResourceGroupConfiguration, WritableSubResource siteReference, string publisherName, PublisherScope? publisherScope, string networkServiceDesignGroupName, string networkServiceDesignVersionName, string networkServiceDesignVersionOfferingLocation, IDictionary<string, WritableSubResource> desiredStateConfigurationGroupValueReferences, string lastStateNetworkServiceDesignVersionName, IReadOnlyDictionary<string, WritableSubResource> lastStateConfigurationGroupValueReferences) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            Sku = sku;
            ProvisioningState = provisioningState;
            ManagedResourceGroupConfiguration = managedResourceGroupConfiguration;
            SiteReference = siteReference;
            PublisherName = publisherName;
            PublisherScope = publisherScope;
            NetworkServiceDesignGroupName = networkServiceDesignGroupName;
            NetworkServiceDesignVersionName = networkServiceDesignVersionName;
            NetworkServiceDesignVersionOfferingLocation = networkServiceDesignVersionOfferingLocation;
            DesiredStateConfigurationGroupValueReferences = desiredStateConfigurationGroupValueReferences;
            LastStateNetworkServiceDesignVersionName = lastStateNetworkServiceDesignVersionName;
            LastStateConfigurationGroupValueReferences = lastStateConfigurationGroupValueReferences;
        }

        /// <summary> The managed identity of the Site network service, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Sku of the site network service. </summary>
        public HybridNetworkSku Sku { get; set; }
        /// <summary> The provisioning state of the site network service resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Managed resource group configuration. </summary>
        public ManagedResourceGroupConfiguration ManagedResourceGroupConfiguration { get; set; }
        /// <summary> The site details. </summary>
        internal WritableSubResource SiteReference { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SiteReferenceId
        {
            get => SiteReference is null ? default : SiteReference.Id;
            set
            {
                if (SiteReference is null)
                    SiteReference = new WritableSubResource();
                SiteReference.Id = value;
            }
        }

        /// <summary> The publisher name for the site network service. </summary>
        public string PublisherName { get; set; }
        /// <summary> The scope of the publisher. </summary>
        public PublisherScope? PublisherScope { get; set; }
        /// <summary> The network service design group name for the site network service. </summary>
        public string NetworkServiceDesignGroupName { get; set; }
        /// <summary> The network service design version for the site network service. </summary>
        public string NetworkServiceDesignVersionName { get; set; }
        /// <summary> The location of the network service design offering. </summary>
        public string NetworkServiceDesignVersionOfferingLocation { get; set; }
        /// <summary> The goal state of the site network service resource. This has references to the configuration group value objects that describe the desired state of the site network service. </summary>
        public IDictionary<string, WritableSubResource> DesiredStateConfigurationGroupValueReferences { get; }
        /// <summary> The network service design version for the site network service. </summary>
        public string LastStateNetworkServiceDesignVersionName { get; }
        /// <summary> The last state of the site network service resource. </summary>
        public IReadOnlyDictionary<string, WritableSubResource> LastStateConfigurationGroupValueReferences { get; }
    }
}
