// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure template artifact profile properties. </summary>
    public partial class AzureCoreArmTemplateArtifactProfile : ArtifactProfile
    {
        /// <summary> Initializes a new instance of AzureCoreArmTemplateArtifactProfile. </summary>
        public AzureCoreArmTemplateArtifactProfile()
        {
        }

        /// <summary> Initializes a new instance of AzureCoreArmTemplateArtifactProfile. </summary>
        /// <param name="artifactStore"> The reference to artifact store. </param>
        /// <param name="templateArtifactProfile"> Template artifact profile. </param>
        internal AzureCoreArmTemplateArtifactProfile(WritableSubResource artifactStore, ArmTemplateArtifactProfile templateArtifactProfile) : base(artifactStore)
        {
            TemplateArtifactProfile = templateArtifactProfile;
        }

        /// <summary> Template artifact profile. </summary>
        public ArmTemplateArtifactProfile TemplateArtifactProfile { get; set; }
    }
}
