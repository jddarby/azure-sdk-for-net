// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork
{
    public partial class SiteNetworkServiceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ManagedResourceGroupConfiguration))
            {
                writer.WritePropertyName("managedResourceGroupConfiguration"u8);
                writer.WriteObjectValue(ManagedResourceGroupConfiguration);
            }
            if (Optional.IsDefined(SiteReference))
            {
                writer.WritePropertyName("siteReference"u8);
                JsonSerializer.Serialize(writer, SiteReference);
            }
            if (Optional.IsDefined(PublisherName))
            {
                writer.WritePropertyName("publisherName"u8);
                writer.WriteStringValue(PublisherName);
            }
            if (Optional.IsDefined(PublisherScope))
            {
                writer.WritePropertyName("publisherScope"u8);
                writer.WriteStringValue(PublisherScope.Value.ToString());
            }
            if (Optional.IsDefined(NetworkServiceDesignGroupName))
            {
                writer.WritePropertyName("networkServiceDesignGroupName"u8);
                writer.WriteStringValue(NetworkServiceDesignGroupName);
            }
            if (Optional.IsDefined(NetworkServiceDesignVersionName))
            {
                writer.WritePropertyName("networkServiceDesignVersionName"u8);
                writer.WriteStringValue(NetworkServiceDesignVersionName);
            }
            if (Optional.IsDefined(NetworkServiceDesignVersionOfferingLocation))
            {
                writer.WritePropertyName("networkServiceDesignVersionOfferingLocation"u8);
                writer.WriteStringValue(NetworkServiceDesignVersionOfferingLocation);
            }
            if (Optional.IsCollectionDefined(DesiredStateConfigurationGroupValueReferences))
            {
                writer.WritePropertyName("desiredStateConfigurationGroupValueReferences"u8);
                writer.WriteStartObject();
                foreach (var item in DesiredStateConfigurationGroupValueReferences)
                {
                    writer.WritePropertyName(item.Key);
                    JsonSerializer.Serialize(writer, item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SiteNetworkServiceData DeserializeSiteNetworkServiceData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<HybridNetworkSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<ResourceManager.Models.SystemData> systemData = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<ManagedResourceGroupConfiguration> managedResourceGroupConfiguration = default;
            Optional<WritableSubResource> siteReference = default;
            Optional<string> publisherName = default;
            Optional<PublisherScope> publisherScope = default;
            Optional<string> networkServiceDesignGroupName = default;
            Optional<string> networkServiceDesignVersionName = default;
            Optional<string> networkServiceDesignVersionOfferingLocation = default;
            Optional<IDictionary<string, WritableSubResource>> desiredStateConfigurationGroupValueReferences = default;
            Optional<string> lastStateNetworkServiceDesignVersionName = default;
            Optional<IReadOnlyDictionary<string, WritableSubResource>> lastStateConfigurationGroupValueReferences = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = HybridNetworkSku.DeserializeHybridNetworkSku(property.Value);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<ResourceManager.Models.SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("managedResourceGroupConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managedResourceGroupConfiguration = ManagedResourceGroupConfiguration.DeserializeManagedResourceGroupConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("siteReference"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            siteReference = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("publisherName"u8))
                        {
                            publisherName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherScope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publisherScope = new PublisherScope(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("networkServiceDesignGroupName"u8))
                        {
                            networkServiceDesignGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkServiceDesignVersionName"u8))
                        {
                            networkServiceDesignVersionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkServiceDesignVersionOfferingLocation"u8))
                        {
                            networkServiceDesignVersionOfferingLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("desiredStateConfigurationGroupValueReferences"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, WritableSubResource> dictionary = new Dictionary<string, WritableSubResource>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, JsonSerializer.Deserialize<WritableSubResource>(property1.Value.GetRawText()));
                            }
                            desiredStateConfigurationGroupValueReferences = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("lastStateNetworkServiceDesignVersionName"u8))
                        {
                            lastStateNetworkServiceDesignVersionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastStateConfigurationGroupValueReferences"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, WritableSubResource> dictionary = new Dictionary<string, WritableSubResource>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, JsonSerializer.Deserialize<WritableSubResource>(property1.Value.GetRawText()));
                            }
                            lastStateConfigurationGroupValueReferences = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SiteNetworkServiceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, sku.Value, Optional.ToNullable(provisioningState), managedResourceGroupConfiguration.Value, siteReference, publisherName.Value, Optional.ToNullable(publisherScope), networkServiceDesignGroupName.Value, networkServiceDesignVersionName.Value, networkServiceDesignVersionOfferingLocation.Value, Optional.ToDictionary(desiredStateConfigurationGroupValueReferences), lastStateNetworkServiceDesignVersionName.Value, Optional.ToDictionary(lastStateConfigurationGroupValueReferences));
        }
    }
}
