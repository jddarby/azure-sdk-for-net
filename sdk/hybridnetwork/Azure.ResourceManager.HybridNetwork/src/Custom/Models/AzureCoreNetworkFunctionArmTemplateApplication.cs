// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure core network function Template application definition. </summary>
    public partial class AzureCoreNetworkFunctionArmTemplateApplication : AzureCoreNetworkFunctionApplication
    {
        /// <summary> Initializes a new instance of AzureCoreNetworkFunctionArmTemplateApplication. </summary>
        public AzureCoreNetworkFunctionArmTemplateApplication()
        {
            ArtifactType = AzureCoreArtifactType.ArmTemplate;
        }

        /// <summary> Initializes a new instance of AzureCoreNetworkFunctionArmTemplateApplication. </summary>
        /// <param name="name"> The name of the network function application. </param>
        /// <param name="dependsOnProfile"> Depends on profile definition. </param>
        /// <param name="artifactType"> The artifact type. </param>
        /// <param name="artifactProfile"> Azure template artifact profile. </param>
        /// <param name="deployParametersMappingRuleProfile"> Deploy mapping rule profile. </param>
        internal AzureCoreNetworkFunctionArmTemplateApplication(string name, DependsOnProfile dependsOnProfile, AzureCoreArtifactType artifactType, AzureCoreArmTemplateArtifactProfile artifactProfile, AzureCoreArmTemplateDeployMappingRuleProfile deployParametersMappingRuleProfile) : base(name, dependsOnProfile, artifactType)
        {
            ArtifactProfile = artifactProfile;
            DeployParametersMappingRuleProfile = deployParametersMappingRuleProfile;
            ArtifactType = artifactType;
        }

        /// <summary> Azure template artifact profile. </summary>
        public AzureCoreArmTemplateArtifactProfile ArtifactProfile { get; set; }
        /// <summary> Deploy mapping rule profile. </summary>
        public AzureCoreArmTemplateDeployMappingRuleProfile DeployParametersMappingRuleProfile { get; set; }
    }
}
