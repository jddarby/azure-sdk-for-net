// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.ResourceManager.HybridNetwork.Models;

namespace Azure.ResourceManager.HybridNetwork
{
    public partial class NetworkFunctionDefinitionVersionData
    {
        internal static NetworkFunctionDefinitionVersionData DeserializeNetworkFunctionDefinitionVersionData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("networkFunctionTemplate", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ContainerizedNetworkFunction":
                        return ContainerizedNetworkFunctionDefinitionVersionData.DeserializeContainerizedNetworkFunctionDefinitionVersionData(element);
                    case "VirtualNetworkFunction":
                        return VirtualNetworkFunctionDefinitionVersionData.DeserializeVirtualNetworkFunctionDefinitionVersionData(element);
                }
            }
            return null;
        }
    }
}
