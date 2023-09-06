// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Artifact profile properties. </summary>
    public partial class ArtifactProfile
    {
        /// <summary> Initializes a new instance of ArtifactProfile. </summary>
        public ArtifactProfile()
        {
        }

        /// <summary> Initializes a new instance of ArtifactProfile. </summary>
        /// <param name="artifactStore"> The reference to artifact store. </param>
        internal ArtifactProfile(WritableSubResource artifactStore)
        {
            ArtifactStore = artifactStore;
        }

        /// <summary> The reference to artifact store. </summary>
        internal WritableSubResource ArtifactStore { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ArtifactStoreId
        {
            get => ArtifactStore is null ? default : ArtifactStore.Id;
            set
            {
                if (ArtifactStore is null)
                    ArtifactStore = new WritableSubResource();
                ArtifactStore.Id = value;
            }
        }
    }
}
