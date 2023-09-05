// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.HybridNetwork.Models;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Azure.ResourceManager.HybridNetwork.Tests
{
    public class HybridNetworkManagementTestBase : ManagementRecordedTestBase<HybridNetworkManagementTestEnvironment>
    {
        protected ArmClient Client { get; private set; }
        protected SubscriptionResource DefaultSubscription { get; private set; }
        private static readonly string TestAssetPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "Scenario", "TestAssets");

        protected HybridNetworkManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
        }

        protected HybridNetworkManagementTestBase(bool isAsync)
            : base(isAsync)
        {
        }

        protected JsonElement ReadJsonFile(string filePath)
        {
            var json = File.ReadAllText(Path.Combine(TestAssetPath, filePath));
            JsonDocument document = JsonDocument.Parse(json);

            return document.RootElement;
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

        protected async Task<ConfigurationGroupSchemaResource> CreateConfigGroupSchemaResource(
            PublisherResource publisher,
            string cgSchemaName,
            AzureLocation location)
        {
            var cgSchemaData = new ConfigurationGroupSchemaData(location)
            {
                SchemaDefinition = ReadJsonFile("cg_schema.json").GetRawText(),
            };
            var lro = await publisher
                .GetConfigurationGroupSchemas()
                .CreateOrUpdateAsync(WaitUntil.Completed, cgSchemaName, cgSchemaData);

            return lro.Value;
        }

        protected async Task<ArtifactStoreResource> CreateArtifactStoreResource(
            PublisherResource publisher,
            string artifactStoreName,
            AzureLocation location)
        {
            var artifactStoreData = new ArtifactStoreData(location)
            {
                StoreType = ArtifactStoreType.AzureContainerRegistry,
                ReplicationStrategy = ArtifactReplicationStrategy.SingleReplication,
            };
            var lro = await publisher
                .GetArtifactStores()
                .CreateOrUpdateAsync(WaitUntil.Completed, artifactStoreName, artifactStoreData);

            return lro.Value;
        }

        protected async Task<NetworkFunctionDefinitionGroupResource> CreateNFDGResource(
            PublisherResource publisher,
            string nfdgName,
            AzureLocation location)
        {
            var nfdgData = new NetworkFunctionDefinitionGroupData(location)
            {
                Description = "NFD for .NET SDK UTs."
            };
            var lro = await publisher
                .GetNetworkFunctionDefinitionGroups()
                .CreateOrUpdateAsync(WaitUntil.Completed, nfdgName, nfdgData);

            return lro.Value;
        }

        protected async Task<NetworkServiceDesignGroupResource> CreateNSDGResource(
            PublisherResource publisher,
            string nsdgName,
            AzureLocation location)
        {
            var nsdgData = new NetworkServiceDesignGroupData(location)
            {
                Description = "NSD for .NET SDK UTs."
            };
            var lro = await publisher
                .GetNetworkServiceDesignGroups()
                .CreateOrUpdateAsync(WaitUntil.Completed, nsdgName, nsdgData);

            return lro.Value;
        }

        protected async Task<ArtifactManifestResource> CreateArtifactManifestResource(
            ArtifactStoreResource artifactStore,
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
            var lro = await artifactStore
                .GetArtifactManifests()
                .CreateOrUpdateAsync(WaitUntil.Completed, artifactManifestName, artifactManifestData);

            return lro.Value;
        }
    }
}
