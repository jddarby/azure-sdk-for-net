// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.HybridNetwork;
using Azure.ResourceManager.HybridNetwork.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Samples
{
    public partial class Sample_NetworkServiceDesignVersionCollection
    {
        // Create or update a network service design version resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateANetworkServiceDesignVersionResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkServiceDesignVersionCreate.json
            // this example is just showing the usage of "NetworkServiceDesignVersions_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkServiceDesignGroupResource created on azure
            // for more information of creating NetworkServiceDesignGroupResource, please refer to the document of NetworkServiceDesignGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkServiceDesignGroupName = "TestNetworkServiceDesignGroupName";
            ResourceIdentifier networkServiceDesignGroupResourceId = NetworkServiceDesignGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkServiceDesignGroupName);
            NetworkServiceDesignGroupResource networkServiceDesignGroup = client.GetNetworkServiceDesignGroupResource(networkServiceDesignGroupResourceId);

            // get the collection of this NetworkServiceDesignVersionResource
            NetworkServiceDesignVersionCollection collection = networkServiceDesignGroup.GetNetworkServiceDesignVersions();

            // invoke the operation
            string networkServiceDesignVersionName = "1.0.0";
            NetworkServiceDesignVersionData data = new NetworkServiceDesignVersionData(new AzureLocation("eastus"))
            {
                Properties = new NetworkServiceDesignVersionPropertiesFormat()
                {
                    ConfigurationGroupSchemaReferences =
{
["MyVM_Configuration"] = new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/subid/resourcegroups/contosorg1/providers/microsoft.hybridnetwork/publishers/contosoGroup/networkServiceDesignGroups/NSD_contoso/configurationGroupSchemas/MyVM_Configuration_Schema"),
},
},
                    ResourceElementTemplates =
{
new ArmResourceDefinitionResourceElementTemplateDetails()
{
Configuration = new ArmResourceDefinitionResourceElementTemplate()
{
TemplateType = TemplateType.ArmTemplate,
ParameterValues = "{\"publisherName\":\"{configurationparameters('MyVM_Configuration').publisherName}\",\"skuGroupName\":\"{configurationparameters('MyVM_Configuration').skuGroupName}\",\"skuVersion\":\"{configurationparameters('MyVM_Configuration').skuVersion}\",\"skuOfferingLocation\":\"{configurationparameters('MyVM_Configuration').skuOfferingLocation}\",\"nfviType\":\"{nfvis().nfvisFromSitePerNfviType.AzureCore.nfviAlias1.nfviType}\",\"nfviId\":\"{nfvis().nfvisFromSitePerNfviType.AzureCore.nfviAlias1.nfviId}\",\"allowSoftwareUpdates\":\"{configurationparameters('MyVM_Configuration').allowSoftwareUpdates}\",\"virtualNetworkName\":\"{configurationparameters('MyVM_Configuration').vnetName}\",\"subnetName\":\"{configurationparameters('MyVM_Configuration').subnetName}\",\"subnetAddressPrefix\":\"{configurationparameters('MyVM_Configuration').subnetAddressPrefix}\",\"managedResourceGroup\":\"{configurationparameters('SNSSelf').managedResourceGroupName}\",\"adminPassword\":\"{secretparameters('MyVM_Configuration').adminPassword}\"}",
ArtifactProfile = new NSDArtifactProfile()
{
ArtifactStoreReferenceId = new ResourceIdentifier("/subscriptions/subid/providers/Microsoft.HybridNetwork/publishers/contosoGroup/artifactStoreReference/store1"),
ArtifactName = "MyVMArmTemplate",
ArtifactVersion = "1.0.0",
},
},
Name = "MyVM",
DependsOnProfile = new DependsOnProfile()
{
InstallDependsOn =
{
},
},
}
},
                },
            };
            ArmOperation<NetworkServiceDesignVersionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, networkServiceDesignVersionName, data);
            NetworkServiceDesignVersionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkServiceDesignVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a network service design version resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetANetworkServiceDesignVersionResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkServiceDesignVersionGet.json
            // this example is just showing the usage of "NetworkServiceDesignVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkServiceDesignGroupResource created on azure
            // for more information of creating NetworkServiceDesignGroupResource, please refer to the document of NetworkServiceDesignGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkServiceDesignGroupName = "TestNetworkServiceDesignGroupName";
            ResourceIdentifier networkServiceDesignGroupResourceId = NetworkServiceDesignGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkServiceDesignGroupName);
            NetworkServiceDesignGroupResource networkServiceDesignGroup = client.GetNetworkServiceDesignGroupResource(networkServiceDesignGroupResourceId);

            // get the collection of this NetworkServiceDesignVersionResource
            NetworkServiceDesignVersionCollection collection = networkServiceDesignGroup.GetNetworkServiceDesignVersions();

            // invoke the operation
            string networkServiceDesignVersionName = "1.0.0";
            NetworkServiceDesignVersionResource result = await collection.GetAsync(networkServiceDesignVersionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkServiceDesignVersionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a network service design version resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetANetworkServiceDesignVersionResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkServiceDesignVersionGet.json
            // this example is just showing the usage of "NetworkServiceDesignVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkServiceDesignGroupResource created on azure
            // for more information of creating NetworkServiceDesignGroupResource, please refer to the document of NetworkServiceDesignGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkServiceDesignGroupName = "TestNetworkServiceDesignGroupName";
            ResourceIdentifier networkServiceDesignGroupResourceId = NetworkServiceDesignGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkServiceDesignGroupName);
            NetworkServiceDesignGroupResource networkServiceDesignGroup = client.GetNetworkServiceDesignGroupResource(networkServiceDesignGroupResourceId);

            // get the collection of this NetworkServiceDesignVersionResource
            NetworkServiceDesignVersionCollection collection = networkServiceDesignGroup.GetNetworkServiceDesignVersions();

            // invoke the operation
            string networkServiceDesignVersionName = "1.0.0";
            bool result = await collection.ExistsAsync(networkServiceDesignVersionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a network service design version resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetANetworkServiceDesignVersionResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkServiceDesignVersionGet.json
            // this example is just showing the usage of "NetworkServiceDesignVersions_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkServiceDesignGroupResource created on azure
            // for more information of creating NetworkServiceDesignGroupResource, please refer to the document of NetworkServiceDesignGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkServiceDesignGroupName = "TestNetworkServiceDesignGroupName";
            ResourceIdentifier networkServiceDesignGroupResourceId = NetworkServiceDesignGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkServiceDesignGroupName);
            NetworkServiceDesignGroupResource networkServiceDesignGroup = client.GetNetworkServiceDesignGroupResource(networkServiceDesignGroupResourceId);

            // get the collection of this NetworkServiceDesignVersionResource
            NetworkServiceDesignVersionCollection collection = networkServiceDesignGroup.GetNetworkServiceDesignVersions();

            // invoke the operation
            string networkServiceDesignVersionName = "1.0.0";
            NullableResponse<NetworkServiceDesignVersionResource> response = await collection.GetIfExistsAsync(networkServiceDesignVersionName);
            NetworkServiceDesignVersionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkServiceDesignVersionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Get Publisher resource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetPublisherResource()
        {
            // Generated from example definition: specification/hybridnetwork/resource-manager/Microsoft.HybridNetwork/stable/2023-09-01/examples/NetworkServiceDesignVersionListByNetworkServiceDesignGroup.json
            // this example is just showing the usage of "NetworkServiceDesignVersions_ListByNetworkServiceDesignGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkServiceDesignGroupResource created on azure
            // for more information of creating NetworkServiceDesignGroupResource, please refer to the document of NetworkServiceDesignGroupResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg";
            string publisherName = "TestPublisher";
            string networkServiceDesignGroupName = "TestNetworkServiceDesignGroupName";
            ResourceIdentifier networkServiceDesignGroupResourceId = NetworkServiceDesignGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, publisherName, networkServiceDesignGroupName);
            NetworkServiceDesignGroupResource networkServiceDesignGroup = client.GetNetworkServiceDesignGroupResource(networkServiceDesignGroupResourceId);

            // get the collection of this NetworkServiceDesignVersionResource
            NetworkServiceDesignVersionCollection collection = networkServiceDesignGroup.GetNetworkServiceDesignVersions();

            // invoke the operation and iterate over the result
            await foreach (NetworkServiceDesignVersionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkServiceDesignVersionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
