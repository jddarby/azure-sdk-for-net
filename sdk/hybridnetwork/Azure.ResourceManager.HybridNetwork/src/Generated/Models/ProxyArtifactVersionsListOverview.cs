// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The proxy artifact overview. </summary>
    public partial class ProxyArtifactVersionsListOverview : ResourceData
    {
        /// <summary> Initializes a new instance of ProxyArtifactVersionsListOverview. </summary>
        public ProxyArtifactVersionsListOverview()
        {
        }

        /// <summary> Initializes a new instance of ProxyArtifactVersionsListOverview. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="artifactType"> The artifact type. </param>
        /// <param name="artifactVersion"> The artifact version. </param>
        /// <param name="artifactState"> The artifact state. </param>
        internal ProxyArtifactVersionsListOverview(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ArtifactType? artifactType, string artifactVersion, ArtifactState? artifactState) : base(id, name, resourceType, systemData)
        {
            ArtifactType = artifactType;
            ArtifactVersion = artifactVersion;
            ArtifactState = artifactState;
        }

        /// <summary> The artifact type. </summary>
        public ArtifactType? ArtifactType { get; set; }
        /// <summary> The artifact version. </summary>
        public string ArtifactVersion { get; set; }
        /// <summary> The artifact state. </summary>
        public ArtifactState? ArtifactState { get; set; }
    }
}
