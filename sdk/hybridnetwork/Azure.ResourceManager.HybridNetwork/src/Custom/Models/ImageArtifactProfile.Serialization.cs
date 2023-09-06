// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class ImageArtifactProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ImageName))
            {
                writer.WritePropertyName("imageName"u8);
                writer.WriteStringValue(ImageName);
            }
            if (Optional.IsDefined(ImageVersion))
            {
                writer.WritePropertyName("imageVersion"u8);
                writer.WriteStringValue(ImageVersion);
            }
            writer.WriteEndObject();
        }

        internal static ImageArtifactProfile DeserializeImageArtifactProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> imageName = default;
            Optional<string> imageVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageName"u8))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("imageVersion"u8))
                {
                    imageVersion = property.Value.GetString();
                    continue;
                }
            }
            return new ImageArtifactProfile(imageName.Value, imageVersion.Value);
        }
    }
}
