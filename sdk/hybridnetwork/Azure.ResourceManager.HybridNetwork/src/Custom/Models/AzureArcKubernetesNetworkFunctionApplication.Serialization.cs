// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureArcKubernetesNetworkFunctionApplication : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
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

        internal static AzureArcKubernetesNetworkFunctionApplication DeserializeAzureArcKubernetesNetworkFunctionApplication(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("artifactType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "HelmPackage": return AzureArcKubernetesHelmApplication.DeserializeAzureArcKubernetesHelmApplication(element);
                }
            }
            AzureArcKubernetesArtifactType artifactType = default;
            Optional<string> name = default;
            Optional<DependsOnProfile> dependsOnProfile = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("artifactType"u8))
                {
                    artifactType = new AzureArcKubernetesArtifactType(property.Value.GetString());
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
            return new AzureArcKubernetesNetworkFunctionApplication(name.Value, dependsOnProfile.Value, artifactType);
        }
    }
}
