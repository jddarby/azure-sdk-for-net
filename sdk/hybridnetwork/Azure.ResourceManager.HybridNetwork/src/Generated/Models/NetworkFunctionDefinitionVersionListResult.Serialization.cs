// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    internal partial class NetworkFunctionDefinitionVersionListResult
    {
        internal static NetworkFunctionDefinitionVersionListResult DeserializeNetworkFunctionDefinitionVersionListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<HybridNetwork.NetworkFunctionDefinitionVersionData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<HybridNetwork.NetworkFunctionDefinitionVersionData> array = new List<HybridNetwork.NetworkFunctionDefinitionVersionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HybridNetwork.NetworkFunctionDefinitionVersionData.DeserializeNetworkFunctionDefinitionVersionData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new NetworkFunctionDefinitionVersionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
