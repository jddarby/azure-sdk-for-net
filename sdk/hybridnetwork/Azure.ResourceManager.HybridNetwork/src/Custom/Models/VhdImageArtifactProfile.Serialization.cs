// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class VhdImageArtifactProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(VhdName))
            {
                writer.WritePropertyName("vhdName"u8);
                writer.WriteStringValue(VhdName);
            }
            if (Optional.IsDefined(VhdVersion))
            {
                writer.WritePropertyName("vhdVersion"u8);
                writer.WriteStringValue(VhdVersion);
            }
            writer.WriteEndObject();
        }

        internal static VhdImageArtifactProfile DeserializeVhdImageArtifactProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> vhdName = default;
            Optional<string> vhdVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vhdName"u8))
                {
                    vhdName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vhdVersion"u8))
                {
                    vhdVersion = property.Value.GetString();
                    continue;
                }
            }
            return new VhdImageArtifactProfile(vhdName.Value, vhdVersion.Value);
        }
    }
}
