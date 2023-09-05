using System;
using System.Collections.Generic;
using System.Text;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Custom.Models
{
    internal class ContainerizedNetworkFunctionDefinitionVersionData : NetworkFunctionDefinitionVersionData
    {
        /// <summary> Initializes a new instance of NetworkFunctionDefinitionVersionData. </summary>
        /// <param name="location"> The location. </param>
        public ContainerizedNetworkFunctionDefinitionVersionData(AzureLocation location) : base(location)
        {
        }
    }
}
