// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure Operator Distributed Services network function image application definition. </summary>
    public partial class AzureOperatorNexusNetworkFunctionImageApplication : AzureOperatorNexusNetworkFunctionApplication
    {
        /// <summary> Initializes a new instance of AzureOperatorNexusNetworkFunctionImageApplication. </summary>
        public AzureOperatorNexusNetworkFunctionImageApplication()
        {
            ArtifactType = AzureOperatorNexusArtifactType.ImageFile;
        }

        /// <summary> Initializes a new instance of AzureOperatorNexusNetworkFunctionImageApplication. </summary>
        /// <param name="name"> The name of the network function application. </param>
        /// <param name="dependsOnProfile"> Depends on profile definition. </param>
        /// <param name="artifactType"> The artifact type. </param>
        /// <param name="artifactProfile"> Azure Operator Distributed Services image artifact profile. </param>
        /// <param name="deployParametersMappingRuleProfile"> Deploy mapping rule profile. </param>
        internal AzureOperatorNexusNetworkFunctionImageApplication(string name, DependsOnProfile dependsOnProfile, AzureOperatorNexusArtifactType artifactType, AzureOperatorNexusImageArtifactProfile artifactProfile, AzureOperatorNexusImageDeployMappingRuleProfile deployParametersMappingRuleProfile) : base(name, dependsOnProfile, artifactType)
        {
            ArtifactProfile = artifactProfile;
            DeployParametersMappingRuleProfile = deployParametersMappingRuleProfile;
            ArtifactType = artifactType;
        }

        /// <summary> Azure Operator Distributed Services image artifact profile. </summary>
        public AzureOperatorNexusImageArtifactProfile ArtifactProfile { get; set; }
        /// <summary> Deploy mapping rule profile. </summary>
        public AzureOperatorNexusImageDeployMappingRuleProfile DeployParametersMappingRuleProfile { get; set; }
    }
}
