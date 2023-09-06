// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure Operator Distributed Services vhd artifact profile properties. </summary>
    public partial class AzureOperatorNexusArmTemplateArtifactProfile : ArtifactProfile
    {
        /// <summary> Initializes a new instance of AzureOperatorNexusArmTemplateArtifactProfile. </summary>
        public AzureOperatorNexusArmTemplateArtifactProfile()
        {
        }

        /// <summary> Initializes a new instance of AzureOperatorNexusArmTemplateArtifactProfile. </summary>
        /// <param name="artifactStore"> The reference to artifact store. </param>
        /// <param name="templateArtifactProfile"> Template artifact profile. </param>
        internal AzureOperatorNexusArmTemplateArtifactProfile(WritableSubResource artifactStore, ArmTemplateArtifactProfile templateArtifactProfile) : base(artifactStore)
        {
            TemplateArtifactProfile = templateArtifactProfile;
        }

        /// <summary> Template artifact profile. </summary>
        public ArmTemplateArtifactProfile TemplateArtifactProfile { get; set; }
    }
}
