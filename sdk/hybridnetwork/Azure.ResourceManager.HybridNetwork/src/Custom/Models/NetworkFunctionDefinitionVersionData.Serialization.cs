// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class NetworkFunctionDefinitionVersionData
    {
        //internal static NetworkFunctionDefinitionVersionData DeserializeNetworkFunctionDefinitionVersionData(JsonElement element)
        //{
        //    if (element.ValueKind == JsonValueKind.Null)
        //    {
        //        return null;
        //    }
        //    if (element.TryGetProperty("networkFunctionType", out JsonElement discriminator))
        //    {
        //        switch (discriminator.GetString())
        //        {
        //            case "ContainerizedNetworkFunction":
        //                return ContainerizedNetworkFunctionDefinitionVersion.DeserializeContainerizedNetworkFunctionDefinitionVersion(element);
        //            case "VirtualNetworkFunction":
        //                return VirtualNetworkFunctionDefinitionVersion.DeserializeVirtualNetworkFunctionDefinitionVersion(element);
        //        }
        //    }
        //}
    }
}
