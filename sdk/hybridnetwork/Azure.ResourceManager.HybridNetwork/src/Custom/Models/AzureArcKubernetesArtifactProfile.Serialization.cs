// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureArcKubernetesArtifactProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(HelmArtifactProfile))
            {
                writer.WritePropertyName("helmArtifactProfile"u8);
                writer.WriteObjectValue(HelmArtifactProfile);
            }
            if (Optional.IsDefined(ArtifactStore))
            {
                writer.WritePropertyName("artifactStore"u8);
                JsonSerializer.Serialize(writer, ArtifactStore);
            }
            writer.WriteEndObject();
        }

        internal static AzureArcKubernetesArtifactProfile DeserializeAzureArcKubernetesArtifactProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HelmArtifactProfile> helmArtifactProfile = default;
            Optional<WritableSubResource> artifactStore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("helmArtifactProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    helmArtifactProfile = HelmArtifactProfile.DeserializeHelmArtifactProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("artifactStore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    artifactStore = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
            }
            return new AzureArcKubernetesArtifactProfile(artifactStore, helmArtifactProfile.Value);
        }
    }
}
