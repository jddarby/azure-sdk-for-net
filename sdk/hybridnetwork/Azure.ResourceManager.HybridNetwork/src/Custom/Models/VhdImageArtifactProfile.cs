// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Vhd artifact profile. </summary>
    public partial class VhdImageArtifactProfile
    {
        /// <summary> Initializes a new instance of VhdImageArtifactProfile. </summary>
        public VhdImageArtifactProfile()
        {
        }

        /// <summary> Initializes a new instance of VhdImageArtifactProfile. </summary>
        /// <param name="vhdName"> Vhd name. </param>
        /// <param name="vhdVersion"> Vhd version. </param>
        internal VhdImageArtifactProfile(string vhdName, string vhdVersion)
        {
            VhdName = vhdName;
            VhdVersion = vhdVersion;
        }

        /// <summary> Vhd name. </summary>
        public string VhdName { get; set; }
        /// <summary> Vhd version. </summary>
        public string VhdVersion { get; set; }
    }
}
