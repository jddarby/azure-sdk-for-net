// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Artifact profile properties. </summary>
    internal partial class ArtifactProfile
    {
        /// <summary> Initializes a new instance of ArtifactProfile. </summary>
        internal ArtifactProfile()
        {
        }

        /// <summary> The reference to artifact store. </summary>
        internal WritableSubResource ArtifactStore { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ArtifactStoreId
        {
            get => ArtifactStore?.Id;
        }
    }
}
