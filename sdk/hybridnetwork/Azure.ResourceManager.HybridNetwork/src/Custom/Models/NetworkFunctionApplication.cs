// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Network function application definition. </summary>
    public partial class NetworkFunctionApplication
    {
        /// <summary> Initializes a new instance of NetworkFunctionApplication. </summary>
        public NetworkFunctionApplication()
        {
        }

        /// <summary> Initializes a new instance of NetworkFunctionApplication. </summary>
        /// <param name="name"> The name of the network function application. </param>
        /// <param name="dependsOnProfile"> Depends on profile definition. </param>
        internal NetworkFunctionApplication(string name, DependsOnProfile dependsOnProfile)
        {
            Name = name;
            DependsOnProfile = dependsOnProfile;
        }

        /// <summary> The name of the network function application. </summary>
        public string Name { get; set; }
        /// <summary> Depends on profile definition. </summary>
        public DependsOnProfile DependsOnProfile { get; set; }
    }
}
