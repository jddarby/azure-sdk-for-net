// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    internal partial class UnknownContainerizedNetworkFunctionTemplate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("nfviType"u8);
            writer.WriteStringValue(NfviType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownContainerizedNetworkFunctionTemplate DeserializeUnknownContainerizedNetworkFunctionTemplate(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerizedNetworkFunctionNfviType nfviType = "AutoRest.CSharp.Output.Models.Types.EnumTypeValue";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nfviType"u8))
                {
                    nfviType = new ContainerizedNetworkFunctionNfviType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownContainerizedNetworkFunctionTemplate(nfviType);
        }
    }
}
