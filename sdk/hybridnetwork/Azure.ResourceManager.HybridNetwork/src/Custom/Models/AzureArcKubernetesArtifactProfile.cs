// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure arc kubernetes artifact profile properties. </summary>
    public partial class AzureArcKubernetesArtifactProfile : ArtifactProfile
    {
        /// <summary> Initializes a new instance of AzureArcKubernetesArtifactProfile. </summary>
        public AzureArcKubernetesArtifactProfile()
        {
        }

        /// <summary> Initializes a new instance of AzureArcKubernetesArtifactProfile. </summary>
        /// <param name="artifactStore"> The reference to artifact store. </param>
        /// <param name="helmArtifactProfile"> Helm artifact profile. </param>
        internal AzureArcKubernetesArtifactProfile(WritableSubResource artifactStore, HelmArtifactProfile helmArtifactProfile) : base(artifactStore)
        {
            HelmArtifactProfile = helmArtifactProfile;
        }

        /// <summary> Helm artifact profile. </summary>
        public HelmArtifactProfile HelmArtifactProfile { get; set; }
    }
}
