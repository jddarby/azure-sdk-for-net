// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.HybridNetwork.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.HybridNetwork.Tests.Scenario
{
    internal class PublisherTest : HybridNetworkManagementTestBase
    {
        public PublisherTest(bool isAsync) : base(isAsync)
        {
        }

        [OneTimeSetUp]
        public async Task GlobalSetUp()
        {
            DefaultResourceGroupName = SessionRecording.GenerateAssetName("PublisherUTRG");
            DefaultResourceLocation = new AzureLocation("eastus2euap");

            ResourceGroupData rgData = new ResourceGroupData(DefaultResourceLocation);
            var rgLro = await GlobalClient
                .GetDefaultSubscriptionAsync().Result
                .GetResourceGroups()
                .CreateOrUpdateAsync(WaitUntil.Completed, DefaultResourceGroupName, rgData);
            ResourceGroupResource rg = rgLro.Value;
            ResourceGroupId = rg.Id;

            await StopSessionRecordingAsync();
        }

        [SetUp]
        public async Task SetUp()
        {
            ArmClient client = GetArmClient();

            ResourceGroup = await client.GetResourceGroupResource(ResourceGroupId).GetAsync();
        }

        [OneTimeTearDown]
        public void CleanUp()
        {
            CleanupResourceGroups();
        }

        [TestCase]
        [Order(0)]
        [RecordedTest]
        public async Task CanCreateGetPublisher()
        {
            PublisherName = Recording.GenerateAssetName("publisher");

            // Create Publisher
            PublisherResource publisher = await CreatePublisherResource(ResourceGroup, PublisherName, DefaultResourceLocation);

            // Get Publisher
            Response<PublisherResource> getPublisherResponse = await publisher.GetAsync();
            PublisherResource publisherResourceRetrieved = getPublisherResponse.Value;
            Assert.IsNotNull(publisherResourceRetrieved);
            Assert.AreEqual(publisher.Data.Location, publisherResourceRetrieved.Data.Location);
            Assert.AreEqual(PublisherScope.Private, publisherResourceRetrieved.Data.Scope);
        }

        [TestCase]
        [Order(1)]
        [RecordedTest]
        public async Task CanCreateGetConfigGroupSchema()
        {
            string cgSchemaName = Recording.GenerateAssetName("cgSchema");

            // Create Artifact Store
            PublisherResource publisher = await ResourceGroup.GetPublishers().GetAsync(PublisherName);
            ConfigurationGroupSchemaResource cgSchema = await CreateConfigGroupSchemaResource(publisher, cgSchemaName, DefaultResourceLocation);

            // Get Artifact Store
            Response<ConfigurationGroupSchemaResource> getArtifactStoreResponse = await cgSchema.GetAsync();
            ConfigurationGroupSchemaResource cgSchemaResourceRetrieved = getArtifactStoreResponse.Value;
            ConfigurationGroupSchemaData retrievedData = cgSchemaResourceRetrieved.Data;
            Assert.IsNotNull(cgSchemaResourceRetrieved);
            var schema = "hello Jacob" + ReadJsonFile("cg_schema.json").ToString();
            Assert.AreEqual(cgSchema.Data.Location, retrievedData.Location);
            Assert.AreEqual(schema, retrievedData.SchemaDefinition);
        }

        [TestCase]
        [Order(1)]
        [RecordedTest]
        [Ignore("Test not written yet")]
        public async Task CanCreateGetArtifactStore()
        {
            ArtifactStoreName = Recording.GenerateAssetName("artifactStore");

            // Create Artifact Store
            PublisherResource publisher = await ResourceGroup.GetPublishers().GetAsync(PublisherName);
            ArtifactStoreResource artifactStore = await CreateArtifactStoreResource(publisher, ArtifactStoreName, DefaultResourceLocation);

            // Get Artifact Store
            Response<ArtifactStoreResource> getArtifactStoreResponse = await artifactStore.GetAsync();
            ArtifactStoreResource artifactStoreResourceRetrieved = getArtifactStoreResponse.Value;
            ArtifactStoreData retrievedData = artifactStoreResourceRetrieved.Data;
            Assert.IsNotNull(artifactStoreResourceRetrieved);
            Assert.AreEqual(artifactStore.Data.Location, retrievedData.Location);
            Assert.AreEqual(ArtifactStoreType.AzureContainerRegistry, retrievedData.StoreType);
            Assert.AreEqual(ArtifactReplicationStrategy.SingleReplication, retrievedData.ReplicationStrategy);
        }

        [TestCase]
        [Order(1)]
        [RecordedTest]
        [Ignore("Test not written yet")]
        public async Task CanCreateGetNFDG()
        {
            NFDGName = Recording.GenerateAssetName("nfdg");

            // Create NFDG
            PublisherResource publisher = await ResourceGroup.GetPublishers().GetAsync(PublisherName);
            NetworkFunctionDefinitionGroupResource nfdg = await CreateNFDGResource(publisher, NFDGName, DefaultResourceLocation);

            // Get NFDG
            Response<NetworkFunctionDefinitionGroupResource> getNfdgResponse = await nfdg.GetAsync();
            NetworkFunctionDefinitionGroupResource nfdgResourceRetrieved = getNfdgResponse.Value;
            NetworkFunctionDefinitionGroupData retrievedData = nfdgResourceRetrieved.Data;
            Assert.IsNotNull(nfdgResourceRetrieved);
            Assert.AreEqual(nfdg.Data.Location, retrievedData.Location);
            Assert.AreEqual("NFD for .NET SDK UTs.", retrievedData.Description);
        }

        [TestCase]
        [Order(1)]
        [RecordedTest]
        [Ignore("Test not written yet")]
        public async Task CanCreateGetNSDG()
        {
            NSDGName = Recording.GenerateAssetName("nsdg");

            // Create NSDG
            PublisherResource publisher = await ResourceGroup.GetPublishers().GetAsync(PublisherName);
            NetworkServiceDesignGroupResource nsdg = await CreateNSDGResource(publisher, NSDGName, DefaultResourceLocation);

            // Get NSDG
            Response<NetworkServiceDesignGroupResource> getNsdgResponse = await nsdg.GetAsync();
            NetworkServiceDesignGroupResource nsdgResourceRetrieved = getNsdgResponse.Value;
            NetworkServiceDesignGroupData retrievedData = nsdgResourceRetrieved.Data;
            Assert.IsNotNull(nsdgResourceRetrieved);
            Assert.AreEqual(nsdg.Data.Location, retrievedData.Location);
            Assert.AreEqual("NSD for .NET SDK UTs.", retrievedData.Description);
        }

        [TestCase]
        [Order(2)]
        [RecordedTest]
        [Ignore("Test not written yet")]
        public async Task CanCreateGetArtifactManifest()
        {
            string artifactManifestName = Recording.GenerateAssetName("artifactManifest");

            // Create Artifact Manifest
            ArtifactStoreResource artifactStore = await ResourceGroup.GetPublisherAsync(PublisherName).Result.Value.GetArtifactStoreAsync(ArtifactStoreName);
            ArtifactManifestResource artifactManifest = await CreateArtifactManifestResource(artifactStore, artifactManifestName, DefaultResourceLocation);

            // Get Artifact Manifest
            Response<ArtifactManifestResource> getArtifactManifestResponse = await artifactManifest.GetAsync();
            ArtifactManifestResource artifactManifestResourceRetrieved = getArtifactManifestResponse.Value;
            ArtifactManifestData retrievedData = artifactManifestResourceRetrieved.Data;
            Assert.IsNotNull(artifactManifestResourceRetrieved);
            Assert.AreEqual(artifactManifest.Data.Location, retrievedData.Location);
            Assert.AreEqual("vnet-arm-template", retrievedData.Artifacts[0].ArtifactName);
            Assert.AreEqual(ArtifactType.ArmTemplate, retrievedData.Artifacts[0].ArtifactType);
            Assert.AreEqual("1.0.0", retrievedData.Artifacts[0].ArtifactVersion);
        }

        [TestCase]
        [Order(2)]
        [RecordedTest]
        [Ignore("Test not written yet")]
        public async Task CanCreateGetNSDV()
        {
            await Task.CompletedTask;
        }

        private string DefaultResourceGroupName;
        private string PublisherName;
        private string ArtifactStoreName;
        private string NFDGName;
        private string NSDGName;
        private ResourceIdentifier ResourceGroupId;
        private AzureLocation DefaultResourceLocation;
        private ResourceGroupResource ResourceGroup;
    }
}
