// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureOperatorNexusArmTemplateArtifactProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TemplateArtifactProfile))
            {
                writer.WritePropertyName("templateArtifactProfile"u8);
                writer.WriteObjectValue(TemplateArtifactProfile);
            }
            if (Optional.IsDefined(ArtifactStore))
            {
                writer.WritePropertyName("artifactStore"u8);
                JsonSerializer.Serialize(writer, ArtifactStore);
            }
            writer.WriteEndObject();
        }

        internal static AzureOperatorNexusArmTemplateArtifactProfile DeserializeAzureOperatorNexusArmTemplateArtifactProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ArmTemplateArtifactProfile> templateArtifactProfile = default;
            Optional<WritableSubResource> artifactStore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("templateArtifactProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    templateArtifactProfile = ArmTemplateArtifactProfile.DeserializeArmTemplateArtifactProfile(property.Value);
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
            return new AzureOperatorNexusArmTemplateArtifactProfile(artifactStore, templateArtifactProfile.Value);
        }
    }
}
