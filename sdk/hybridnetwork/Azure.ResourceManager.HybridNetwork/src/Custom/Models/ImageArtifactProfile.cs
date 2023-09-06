// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Image artifact profile. </summary>
    public partial class ImageArtifactProfile
    {
        /// <summary> Initializes a new instance of ImageArtifactProfile. </summary>
        public ImageArtifactProfile()
        {
        }

        /// <summary> Initializes a new instance of ImageArtifactProfile. </summary>
        /// <param name="imageName"> Image name. </param>
        /// <param name="imageVersion"> Image version. </param>
        internal ImageArtifactProfile(string imageName, string imageVersion)
        {
            ImageName = imageName;
            ImageVersion = imageVersion;
        }

        /// <summary> Image name. </summary>
        public string ImageName { get; set; }
        /// <summary> Image version. </summary>
        public string ImageVersion { get; set; }
    }
}
