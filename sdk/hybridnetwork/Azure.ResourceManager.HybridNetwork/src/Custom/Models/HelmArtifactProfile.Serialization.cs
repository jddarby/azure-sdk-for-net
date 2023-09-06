// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class HelmArtifactProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(HelmPackageName))
            {
                writer.WritePropertyName("helmPackageName"u8);
                writer.WriteStringValue(HelmPackageName);
            }
            if (Optional.IsDefined(HelmPackageVersionRange))
            {
                writer.WritePropertyName("helmPackageVersionRange"u8);
                writer.WriteStringValue(HelmPackageVersionRange);
            }
            if (Optional.IsCollectionDefined(RegistryValuesPaths))
            {
                writer.WritePropertyName("registryValuesPaths"u8);
                writer.WriteStartArray();
                foreach (var item in RegistryValuesPaths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ImagePullSecretsValuesPaths))
            {
                writer.WritePropertyName("imagePullSecretsValuesPaths"u8);
                writer.WriteStartArray();
                foreach (var item in ImagePullSecretsValuesPaths)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static HelmArtifactProfile DeserializeHelmArtifactProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> helmPackageName = default;
            Optional<string> helmPackageVersionRange = default;
            Optional<IList<string>> registryValuesPaths = default;
            Optional<IList<string>> imagePullSecretsValuesPaths = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("helmPackageName"u8))
                {
                    helmPackageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("helmPackageVersionRange"u8))
                {
                    helmPackageVersionRange = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registryValuesPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    registryValuesPaths = array;
                    continue;
                }
                if (property.NameEquals("imagePullSecretsValuesPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    imagePullSecretsValuesPaths = array;
                    continue;
                }
            }
            return new HelmArtifactProfile(helmPackageName.Value, helmPackageVersionRange.Value, Optional.ToList(registryValuesPaths), Optional.ToList(imagePullSecretsValuesPaths));
        }
    }
}
