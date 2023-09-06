// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    internal partial class UnknownVirtualNetworkFunctionTemplate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("nfviType"u8);
            writer.WriteStringValue(NfviType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownVirtualNetworkFunctionTemplate DeserializeUnknownVirtualNetworkFunctionTemplate(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VirtualNetworkFunctionNfviType nfviType = "AutoRest.CSharp.Output.Models.Types.EnumTypeValue";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nfviType"u8))
                {
                    nfviType = new VirtualNetworkFunctionNfviType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownVirtualNetworkFunctionTemplate(nfviType);
        }
    }
}
