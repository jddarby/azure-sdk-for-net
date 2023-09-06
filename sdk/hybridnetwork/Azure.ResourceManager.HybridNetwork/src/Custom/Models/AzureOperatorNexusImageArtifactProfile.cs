// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure Operator Distributed Services image artifact profile properties. </summary>
    public partial class AzureOperatorNexusImageArtifactProfile : ArtifactProfile
    {
        /// <summary> Initializes a new instance of AzureOperatorNexusImageArtifactProfile. </summary>
        public AzureOperatorNexusImageArtifactProfile()
        {
        }

        /// <summary> Initializes a new instance of AzureOperatorNexusImageArtifactProfile. </summary>
        /// <param name="artifactStore"> The reference to artifact store. </param>
        /// <param name="imageArtifactProfile"> Image artifact profile. </param>
        internal AzureOperatorNexusImageArtifactProfile(WritableSubResource artifactStore, ImageArtifactProfile imageArtifactProfile) : base(artifactStore)
        {
            ImageArtifactProfile = imageArtifactProfile;
        }

        /// <summary> Image artifact profile. </summary>
        public ImageArtifactProfile ImageArtifactProfile { get; set; }
    }
}
