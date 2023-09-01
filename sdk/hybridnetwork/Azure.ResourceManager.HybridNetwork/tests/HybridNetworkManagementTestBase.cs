// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.HybridNetwork.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Azure.ResourceManager.HybridNetwork.Tests
{
    public class HybridNetworkManagementTestBase : ManagementRecordedTestBase<HybridNetworkManagementTestEnvironment>
    {
        protected ArmClient Client { get; private set; }
        protected SubscriptionResource DefaultSubscription { get; private set; }

        protected HybridNetworkManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
        }

        protected HybridNetworkManagementTestBase(bool isAsync)
            : base(isAsync)
        {
        }

        [SetUp]
        public async Task CreateCommonClient()
        {
            Client = GetArmClient();
            DefaultSubscription = await Client.GetDefaultSubscriptionAsync().ConfigureAwait(false);
        }

        protected async Task<ResourceGroupResource> CreateResourceGroup(SubscriptionResource subscription, string rgNamePrefix, AzureLocation location)
        {
            string rgName = Recording.GenerateAssetName(rgNamePrefix);
            ResourceGroupData input = new ResourceGroupData(location);
            var lro = await subscription.GetResourceGroups().CreateOrUpdateAsync(WaitUntil.Completed, rgName, input);
            return lro.Value;
        }

        protected async Task<PublisherResource> CreatePublisherResource(
            ResourceGroupResource resourceGroup,
            string publisherName,
            AzureLocation location)
        {
            var publisherData = new PublisherData(location)
            {
                Scope = PublisherScope.Private,
            };
            var lro = await resourceGroup
                .GetPublishers()
                .CreateOrUpdateAsync(WaitUntil.Completed, publisherName, publisherData);

            return lro.Value;
        }

        protected async Task<ArtifactStoreResource> CreateArtifactStoreResource(
            ResourceGroupResource resourceGroup,
            string publisherName,
            string artifactStoreName,
            AzureLocation location)
        {
            var artifactStoreData = new ArtifactStoreData(location)
            {
                StoreType = ArtifactStoreType.AzureContainerRegistry,
                ReplicationStrategy = ArtifactReplicationStrategy.SingleReplication,
            };
            var lro = await resourceGroup
                .GetPublisher(publisherName).Value
                .GetArtifactStores()
                .CreateOrUpdateAsync(WaitUntil.Completed, artifactStoreName, artifactStoreData);

            return lro.Value;
        }

        protected async Task<ArtifactManifestResource> CreateArtifactManifestResource(
            ResourceGroupResource resourceGroup,
            string publisherName,
            string artifactStoreName,
            string artifactManifestName,
            AzureLocation location)
        {
            var artifact = new ManifestArtifactFormat()
            {
                ArtifactName = "vnet-arm-template",
                ArtifactType = ArtifactType.ArmTemplate,
                ArtifactVersion = "1.0.0",
            };
            var artifactManifestData = new ArtifactManifestData(location);
            artifactManifestData.Artifacts.Add(artifact);
            var lro = await resourceGroup
                .GetPublisher(publisherName).Value
                .GetArtifactStore(artifactStoreName).Value
                .GetArtifactManifests()
                .CreateOrUpdateAsync(WaitUntil.Completed, artifactManifestName, artifactManifestData);

            return lro.Value;
        }
    }
}
