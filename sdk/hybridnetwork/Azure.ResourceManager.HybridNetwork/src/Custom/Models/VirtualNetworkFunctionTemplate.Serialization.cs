// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class VirtualNetworkFunctionTemplate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("nfviType"u8);
            writer.WriteStringValue(NfviType.ToString());
            writer.WriteEndObject();
        }

        internal static VirtualNetworkFunctionTemplate DeserializeVirtualNetworkFunctionTemplate(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("nfviType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureCore": return AzureCoreNetworkFunctionTemplate.DeserializeAzureCoreNetworkFunctionTemplate(element);
                    case "AzureOperatorNexus": return AzureOperatorNexusNetworkFunctionTemplate.DeserializeAzureOperatorNexusNetworkFunctionTemplate(element);
                }
            }
            return UnknownVirtualNetworkFunctionTemplate.DeserializeUnknownVirtualNetworkFunctionTemplate(element);
        }
    }
}
