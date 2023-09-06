// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class ArmTemplateArtifactProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TemplateName))
            {
                writer.WritePropertyName("templateName"u8);
                writer.WriteStringValue(TemplateName);
            }
            if (Optional.IsDefined(TemplateVersion))
            {
                writer.WritePropertyName("templateVersion"u8);
                writer.WriteStringValue(TemplateVersion);
            }
            writer.WriteEndObject();
        }

        internal static ArmTemplateArtifactProfile DeserializeArmTemplateArtifactProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> templateName = default;
            Optional<string> templateVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("templateName"u8))
                {
                    templateName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("templateVersion"u8))
                {
                    templateVersion = property.Value.GetString();
                    continue;
                }
            }
            return new ArmTemplateArtifactProfile(templateName.Value, templateVersion.Value);
        }
    }
}
