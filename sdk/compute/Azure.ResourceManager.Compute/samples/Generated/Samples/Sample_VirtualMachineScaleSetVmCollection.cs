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
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Samples
{
    public partial class Sample_VirtualMachineScaleSetVmCollection
    {
        // VirtualMachineScaleSetVM_Update_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_VirtualMachineScaleSetVMUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetVM_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMs_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetResourceId = VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // get the collection of this VirtualMachineScaleSetVmResource
            VirtualMachineScaleSetVmCollection collection = virtualMachineScaleSet.GetVirtualMachineScaleSetVms();

            // invoke the operation
            string instanceId = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            VirtualMachineScaleSetVmData data = new VirtualMachineScaleSetVmData(new AzureLocation("westus"))
            {
                Plan = new ComputePlan()
                {
                    Name = "aaaaaaaaaa",
                    Publisher = "aaaaaaaaaaaaaaaaaaaaaa",
                    Product = "aaaaaaaaaaaaaaaaaaaa",
                    PromotionCode = "aaaaaaaaaaaaaaaaaaaa",
                },
                HardwareProfile = new VirtualMachineHardwareProfile()
                {
                    VmSize = VirtualMachineSizeType.BasicA0,
                    VmSizeProperties = new VirtualMachineSizeProperties()
                    {
                        VCpusAvailable = 9,
                        VCpusPerCore = 12,
                    },
                },
                StorageProfile = new VirtualMachineStorageProfile()
                {
                    ImageReference = new ImageReference()
                    {
                        Publisher = "MicrosoftWindowsServer",
                        Offer = "WindowsServer",
                        Sku = "2012-R2-Datacenter",
                        Version = "4.127.20180315",
                        SharedGalleryImageUniqueId = "aaaaaaaaaaaaaaaaaaaa",
                        Id = new ResourceIdentifier("a"),
                    },
                    OSDisk = new VirtualMachineOSDisk(DiskCreateOptionType.FromImage)
                    {
                        OSType = SupportedOperatingSystemType.Windows,
                        EncryptionSettings = new DiskEncryptionSettings()
                        {
                            DiskEncryptionKey = new KeyVaultSecretReference(new Uri("aaaaaaaa"), new WritableSubResource()
                            {
                                Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
                            }),
                            KeyEncryptionKey = new KeyVaultKeyReference(new Uri("aaaaaaaaaaaaaa"), new WritableSubResource()
                            {
                                Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
                            }),
                            Enabled = true,
                        },
                        Name = "vmss3176_vmss3176_0_OsDisk_1_6d72b805e50e4de6830303c5055077fc",
                        VhdUri = new Uri("https://{storageAccountName}.blob.core.windows.net/{containerName}/{vhdName}.vhd"),
                        ImageUri = new Uri("https://{storageAccountName}.blob.core.windows.net/{containerName}/{vhdName}.vhd"),
                        Caching = CachingType.None,
                        WriteAcceleratorEnabled = true,
                        DiffDiskSettings = new DiffDiskSettings()
                        {
                            Option = DiffDiskOption.Local,
                            Placement = DiffDiskPlacement.CacheDisk,
                        },
                        DiskSizeGB = 127,
                        ManagedDisk = new VirtualMachineManagedDisk()
                        {
                            StorageAccountType = StorageAccountType.StandardLrs,
                            DiskEncryptionSetId = new ResourceIdentifier("aaaaaaaaaaaa"),
                            Id = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/disks/vmss3176_vmss3176_0_OsDisk_1_6d72b805e50e4de6830303c5055077fc"),
                        },
                        DeleteOption = DiskDeleteOptionType.Delete,
                    },
                    DataDisks =
{
new VirtualMachineDataDisk(1,DiskCreateOptionType.Empty)
{
Name = "vmss3176_vmss3176_0_disk2_6c4f554bdafa49baa780eb2d128ff39d",
VhdUri = new Uri("https://{storageAccountName}.blob.core.windows.net/{containerName}/{vhdName}.vhd"),
ImageUri = new Uri("https://{storageAccountName}.blob.core.windows.net/{containerName}/{vhdName}.vhd"),
Caching = CachingType.None,
WriteAcceleratorEnabled = true,
DiskSizeGB = 128,
ManagedDisk = new VirtualMachineManagedDisk()
{
StorageAccountType = StorageAccountType.StandardLrs,
DiskEncryptionSetId = new ResourceIdentifier("aaaaaaaaaaaa"),
Id = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/disks/vmss3176_vmss3176_0_disk2_6c4f554bdafa49baa780eb2d128ff39d"),
},
ToBeDetached = true,
DetachOption = DiskDetachOptionType.ForceDetach,
DeleteOption = DiskDeleteOptionType.Delete,
}
},
                },
                AdditionalCapabilities = new AdditionalCapabilities()
                {
                    UltraSsdEnabled = true,
                    HibernationEnabled = true,
                },
                OSProfile = new VirtualMachineOSProfile()
                {
                    ComputerName = "test000000",
                    AdminUsername = "Foo12",
                    AdminPassword = "aaaaaaaaaaaaaaaa",
                    CustomData = "aaaa",
                    WindowsConfiguration = new WindowsConfiguration()
                    {
                        ProvisionVmAgent = true,
                        IsAutomaticUpdatesEnabled = true,
                        TimeZone = "aaaaaaaaaaaaaaaaaaaaaaaaaaa",
                        AdditionalUnattendContent =
{
new AdditionalUnattendContent()
{
PassName = PassName.OobeSystem,
ComponentName = ComponentName.MicrosoftWindowsShellSetup,
SettingName = SettingName.AutoLogon,
Content = "aaaaaaaaaaaaaaaaaaaa",
}
},
                        PatchSettings = new PatchSettings()
                        {
                            PatchMode = WindowsVmGuestPatchMode.Manual,
                            EnableHotpatching = true,
                            AssessmentMode = WindowsPatchAssessmentMode.ImageDefault,
                        },
                        WinRMListeners =
{
new WinRMListener()
{
Protocol = WinRMListenerProtocolType.Http,
CertificateUri = new Uri("aaaaaaaaaaaaaaaaaaaaaa"),
}
},
                    },
                    LinuxConfiguration = new LinuxConfiguration()
                    {
                        IsPasswordAuthenticationDisabled = true,
                        SshPublicKeys =
{
new SshPublicKeyConfiguration()
{
Path = "aaa",
KeyData = "aaaaaa",
}
},
                        ProvisionVmAgent = true,
                        PatchSettings = new LinuxPatchSettings()
                        {
                            PatchMode = LinuxVmGuestPatchMode.ImageDefault,
                            AssessmentMode = LinuxPatchAssessmentMode.ImageDefault,
                        },
                    },
                    Secrets =
{
},
                    AllowExtensionOperations = true,
                    RequireGuestProvisionSignal = true,
                },
                SecurityProfile = new SecurityProfile()
                {
                    UefiSettings = new UefiSettings()
                    {
                        IsSecureBootEnabled = true,
                        IsVirtualTpmEnabled = true,
                    },
                    EncryptionAtHost = true,
                    SecurityType = SecurityType.TrustedLaunch,
                },
                NetworkProfile = new VirtualMachineNetworkProfile()
                {
                    NetworkInterfaces =
{
new VirtualMachineNetworkInterfaceReference()
{
Primary = true,
DeleteOption = ComputeDeleteOption.Delete,
Id = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Compute/virtualMachineScaleSets/{vmss-name}/virtualMachines/0/networkInterfaces/vmsstestnetconfig5415"),
}
},
                    NetworkApiVersion = NetworkApiVersion.TwoThousandTwenty1101,
                    NetworkInterfaceConfigurations =
{
new VirtualMachineNetworkInterfaceConfiguration("aaaaaaaaaaa")
{
Primary = true,
DeleteOption = ComputeDeleteOption.Delete,
EnableAcceleratedNetworking = true,
EnableFpga = true,
EnableIPForwarding = true,
NetworkSecurityGroupId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
DnsServers =
{
"aaaaaa"
},
IPConfigurations =
{
new VirtualMachineNetworkInterfaceIPConfiguration("aa")
{
SubnetId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
Primary = true,
PublicIPAddressConfiguration = new VirtualMachinePublicIPAddressConfiguration("aaaaaaaaaaaaaaaaaaaaaaaaaaaaa")
{
Sku = new ComputePublicIPAddressSku()
{
Name = ComputePublicIPAddressSkuName.Basic,
Tier = ComputePublicIPAddressSkuTier.Regional,
},
IdleTimeoutInMinutes = 2,
DeleteOption = ComputeDeleteOption.Delete,
DnsSettings = new VirtualMachinePublicIPAddressDnsSettingsConfiguration("aaaaaaaaaaaaaaaaaaaaaaaaa"),
IPTags =
{
new VirtualMachineIPTag()
{
IPTagType = "aaaaaaaaaaaaaaaaaaaaaaaaa",
Tag = "aaaaaaaaaaaaaaaaaaaa",
}
},
PublicIPPrefixId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
PublicIPAddressVersion = IPVersion.IPv4,
PublicIPAllocationMethod = PublicIPAllocationMethod.Dynamic,
},
PrivateIPAddressVersion = IPVersion.IPv4,
ApplicationSecurityGroups =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
}
},
ApplicationGatewayBackendAddressPools =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
}
},
LoadBalancerBackendAddressPools =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
}
},
}
},
DscpConfigurationId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
}
},
                },
                NetworkInterfaceConfigurations =
{
new VirtualMachineScaleSetNetworkConfiguration("vmsstestnetconfig5415")
{
Primary = true,
EnableAcceleratedNetworking = true,
EnableFpga = true,
NetworkSecurityGroupId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
DnsServers =
{
},
IPConfigurations =
{
new VirtualMachineScaleSetIPConfiguration("vmsstestnetconfig9693")
{
SubnetId = new ResourceIdentifier("/subscriptions/{subscription-id}/resourceGroups/myResourceGroup/providers/Microsoft.Network/virtualNetworks/vn4071/subnets/sn5503"),
Primary = true,
PublicIPAddressConfiguration = new VirtualMachineScaleSetPublicIPAddressConfiguration("aaaaaaaaaaaaaaaaaa")
{
Sku = new ComputePublicIPAddressSku()
{
Name = ComputePublicIPAddressSkuName.Basic,
Tier = ComputePublicIPAddressSkuTier.Regional,
},
IdleTimeoutInMinutes = 18,
DnsSettings = new VirtualMachineScaleSetPublicIPAddressConfigurationDnsSettings("aaaaaaaaaaaaaaaaaa"),
IPTags =
{
new VirtualMachineScaleSetIPTag()
{
IPTagType = "aaaaaaa",
Tag = "aaaaaaaaaaaaaaaaaaaaaaaaaaa",
}
},
PublicIPPrefixId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
PublicIPAddressVersion = IPVersion.IPv4,
DeleteOption = ComputeDeleteOption.Delete,
},
PrivateIPAddressVersion = IPVersion.IPv4,
ApplicationGatewayBackendAddressPools =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
}
},
ApplicationSecurityGroups =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
}
},
LoadBalancerBackendAddressPools =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
}
},
LoadBalancerInboundNatPools =
{
new WritableSubResource()
{
Id = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
}
},
}
},
EnableIPForwarding = true,
DeleteOption = ComputeDeleteOption.Delete,
}
},
                BootDiagnostics = new BootDiagnostics()
                {
                    Enabled = true,
                    StorageUri = new Uri("aaaaaaaaaaaaa"),
                },
                AvailabilitySetId = new ResourceIdentifier("/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}"),
                LicenseType = "aaaaaaaaaa",
                ProtectionPolicy = new VirtualMachineScaleSetVmProtectionPolicy()
                {
                    ProtectFromScaleIn = true,
                    ProtectFromScaleSetActions = true,
                },
                UserData = "RXhhbXBsZSBVc2VyRGF0YQ==",
                Tags =
{
},
            };
            ArmOperation<VirtualMachineScaleSetVmResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, instanceId, data);
            VirtualMachineScaleSetVmResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualMachineScaleSetVmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // VirtualMachineScaleSetVM_Update_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_VirtualMachineScaleSetVMUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetVM_Update_MinimumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMs_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetResourceId = VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // get the collection of this VirtualMachineScaleSetVmResource
            VirtualMachineScaleSetVmCollection collection = virtualMachineScaleSet.GetVirtualMachineScaleSetVms();

            // invoke the operation
            string instanceId = "aaaaaaaaaaaaaaaaaaaa";
            VirtualMachineScaleSetVmData data = new VirtualMachineScaleSetVmData(new AzureLocation("westus"));
            ArmOperation<VirtualMachineScaleSetVmResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, instanceId, data);
            VirtualMachineScaleSetVmResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualMachineScaleSetVmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get VM scale set VM with UserData
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVMScaleSetVMWithUserData()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetVM_Get_WithUserData.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string virtualMachineScaleSetName = "{vmss-name}";
            ResourceIdentifier virtualMachineScaleSetResourceId = VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // get the collection of this VirtualMachineScaleSetVmResource
            VirtualMachineScaleSetVmCollection collection = virtualMachineScaleSet.GetVirtualMachineScaleSetVms();

            // invoke the operation
            string instanceId = "0";
            VirtualMachineScaleSetVmResource result = await collection.GetAsync(instanceId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualMachineScaleSetVmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get VM scale set VM with UserData
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetVMScaleSetVMWithUserData()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetVM_Get_WithUserData.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string virtualMachineScaleSetName = "{vmss-name}";
            ResourceIdentifier virtualMachineScaleSetResourceId = VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // get the collection of this VirtualMachineScaleSetVmResource
            VirtualMachineScaleSetVmCollection collection = virtualMachineScaleSet.GetVirtualMachineScaleSetVms();

            // invoke the operation
            string instanceId = "0";
            bool result = await collection.ExistsAsync(instanceId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get VM scale set VM with VMSizeProperties
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetVMScaleSetVMWithVMSizeProperties()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetVM_Get_WithVMSizeProperties.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string virtualMachineScaleSetName = "{vmss-name}";
            ResourceIdentifier virtualMachineScaleSetResourceId = VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // get the collection of this VirtualMachineScaleSetVmResource
            VirtualMachineScaleSetVmCollection collection = virtualMachineScaleSet.GetVirtualMachineScaleSetVms();

            // invoke the operation
            string instanceId = "0";
            VirtualMachineScaleSetVmResource result = await collection.GetAsync(instanceId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            VirtualMachineScaleSetVmData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get VM scale set VM with VMSizeProperties
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetVMScaleSetVMWithVMSizeProperties()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetVM_Get_WithVMSizeProperties.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMs_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "myResourceGroup";
            string virtualMachineScaleSetName = "{vmss-name}";
            ResourceIdentifier virtualMachineScaleSetResourceId = VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // get the collection of this VirtualMachineScaleSetVmResource
            VirtualMachineScaleSetVmCollection collection = virtualMachineScaleSet.GetVirtualMachineScaleSetVms();

            // invoke the operation
            string instanceId = "0";
            bool result = await collection.ExistsAsync(instanceId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // VirtualMachineScaleSetVM_List_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_VirtualMachineScaleSetVMListMaximumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetVM_List_MaximumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetResourceId = VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // get the collection of this VirtualMachineScaleSetVmResource
            VirtualMachineScaleSetVmCollection collection = virtualMachineScaleSet.GetVirtualMachineScaleSetVms();

            // invoke the operation and iterate over the result
            string filter = "aaaaaaaaaaaaaa";
            string select = "aaaaaaaaaaaaaaaaaaaaa";
            string expand = "aaaaaaaaaaaaa";
            await foreach (VirtualMachineScaleSetVmResource item in collection.GetAllAsync(filter: filter, select: select, expand: expand))
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualMachineScaleSetVmData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // VirtualMachineScaleSetVM_List_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_VirtualMachineScaleSetVMListMinimumSetGen()
        {
            // Generated from example definition: specification/compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2023-07-01/examples/virtualMachineScaleSetExamples/VirtualMachineScaleSetVM_List_MinimumSet_Gen.json
            // this example is just showing the usage of "VirtualMachineScaleSetVMs_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this VirtualMachineScaleSetResource created on azure
            // for more information of creating VirtualMachineScaleSetResource, please refer to the document of VirtualMachineScaleSetResource
            string subscriptionId = "{subscription-id}";
            string resourceGroupName = "rgcompute";
            string virtualMachineScaleSetName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            ResourceIdentifier virtualMachineScaleSetResourceId = VirtualMachineScaleSetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, virtualMachineScaleSetName);
            VirtualMachineScaleSetResource virtualMachineScaleSet = client.GetVirtualMachineScaleSetResource(virtualMachineScaleSetResourceId);

            // get the collection of this VirtualMachineScaleSetVmResource
            VirtualMachineScaleSetVmCollection collection = virtualMachineScaleSet.GetVirtualMachineScaleSetVms();

            // invoke the operation and iterate over the result
            await foreach (VirtualMachineScaleSetVmResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                VirtualMachineScaleSetVmData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
