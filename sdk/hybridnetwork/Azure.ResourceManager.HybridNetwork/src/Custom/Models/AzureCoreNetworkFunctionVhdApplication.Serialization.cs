// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureCoreNetworkFunctionVhdApplication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ArtifactProfile))
            {
                writer.WritePropertyName("artifactProfile"u8);
                writer.WriteObjectValue(ArtifactProfile);
            }
            if (Optional.IsDefined(DeployParametersMappingRuleProfile))
            {
                writer.WritePropertyName("deployParametersMappingRuleProfile"u8);
                writer.WriteObjectValue(DeployParametersMappingRuleProfile);
            }
            writer.WritePropertyName("artifactType"u8);
            writer.WriteStringValue(ArtifactType.ToString());
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DependsOnProfile))
            {
                writer.WritePropertyName("dependsOnProfile"u8);
                writer.WriteObjectValue(DependsOnProfile);
            }
            writer.WriteEndObject();
        }

        internal static AzureCoreNetworkFunctionVhdApplication DeserializeAzureCoreNetworkFunctionVhdApplication(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureCoreVhdImageArtifactProfile> artifactProfile = default;
            Optional<AzureCoreVhdImageDeployMappingRuleProfile> deployParametersMappingRuleProfile = default;
            AzureCoreArtifactType artifactType = default;
            Optional<string> name = default;
            Optional<DependsOnProfile> dependsOnProfile = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactProfile = AzureCoreVhdImageArtifactProfile.DeserializeAzureCoreVhdImageArtifactProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("deployParametersMappingRuleProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deployParametersMappingRuleProfile = AzureCoreVhdImageDeployMappingRuleProfile.DeserializeAzureCoreVhdImageDeployMappingRuleProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("artifactType"u8))
                {
                    artifactType = new AzureCoreArtifactType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOnProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dependsOnProfile = DependsOnProfile.DeserializeDependsOnProfile(property.Value);
                    continue;
                }
            }
            return new AzureCoreNetworkFunctionVhdApplication(name.Value, dependsOnProfile.Value, artifactType, artifactProfile.Value, deployParametersMappingRuleProfile.Value);
        }
    }
}
