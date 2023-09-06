// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure vhd artifact profile properties. </summary>
    public partial class AzureCoreVhdImageArtifactProfile : ArtifactProfile
    {
        /// <summary> Initializes a new instance of AzureCoreVhdImageArtifactProfile. </summary>
        public AzureCoreVhdImageArtifactProfile()
        {
        }

        /// <summary> Initializes a new instance of AzureCoreVhdImageArtifactProfile. </summary>
        /// <param name="artifactStore"> The reference to artifact store. </param>
        /// <param name="vhdArtifactProfile"> Vhd artifact profile. </param>
        internal AzureCoreVhdImageArtifactProfile(WritableSubResource artifactStore, VhdImageArtifactProfile vhdArtifactProfile) : base(artifactStore)
        {
            VhdArtifactProfile = vhdArtifactProfile;
        }

        /// <summary> Vhd artifact profile. </summary>
        public VhdImageArtifactProfile VhdArtifactProfile { get; set; }
    }
}
