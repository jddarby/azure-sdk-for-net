// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureArcKubernetesNetworkFunctionTemplate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(NetworkFunctionApplications))
            {
                writer.WritePropertyName("networkFunctionApplications"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkFunctionApplications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("nfviType"u8);
            writer.WriteStringValue(NfviType.ToString());
            writer.WriteEndObject();
        }

        internal static AzureArcKubernetesNetworkFunctionTemplate DeserializeAzureArcKubernetesNetworkFunctionTemplate(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<AzureArcKubernetesNetworkFunctionApplication>> networkFunctionApplications = default;
            ContainerizedNetworkFunctionNfviType nfviType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkFunctionApplications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureArcKubernetesNetworkFunctionApplication> array = new List<AzureArcKubernetesNetworkFunctionApplication>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureArcKubernetesNetworkFunctionApplication.DeserializeAzureArcKubernetesNetworkFunctionApplication(item));
                    }
                    networkFunctionApplications = array;
                    continue;
                }
                if (property.NameEquals("nfviType"u8))
                {
                    nfviType = new ContainerizedNetworkFunctionNfviType(property.Value.GetString());
                    continue;
                }
            }
            return new AzureArcKubernetesNetworkFunctionTemplate(nfviType, Optional.ToList(networkFunctionApplications));
        }
    }
}
