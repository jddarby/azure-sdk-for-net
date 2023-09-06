// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureCoreVhdImageArtifactProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VhdArtifactProfile))
            {
                writer.WritePropertyName("vhdArtifactProfile"u8);
                writer.WriteObjectValue(VhdArtifactProfile);
            }
            if (Optional.IsDefined(ArtifactStore))
            {
                writer.WritePropertyName("artifactStore"u8);
                JsonSerializer.Serialize(writer, ArtifactStore);
            }
            writer.WriteEndObject();
        }

        internal static AzureCoreVhdImageArtifactProfile DeserializeAzureCoreVhdImageArtifactProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<VhdImageArtifactProfile> vhdArtifactProfile = default;
            Optional<WritableSubResource> artifactStore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vhdArtifactProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vhdArtifactProfile = VhdImageArtifactProfile.DeserializeVhdImageArtifactProfile(property.Value);
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
            return new AzureCoreVhdImageArtifactProfile(artifactStore, vhdArtifactProfile.Value);
        }
    }
}
