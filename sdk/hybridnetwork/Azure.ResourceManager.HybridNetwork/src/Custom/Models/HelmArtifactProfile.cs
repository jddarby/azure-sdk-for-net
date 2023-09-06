// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Helm artifact profile. </summary>
    public partial class HelmArtifactProfile
    {
        /// <summary> Initializes a new instance of HelmArtifactProfile. </summary>
        public HelmArtifactProfile()
        {
            RegistryValuesPaths = new ChangeTrackingList<string>();
            ImagePullSecretsValuesPaths = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of HelmArtifactProfile. </summary>
        /// <param name="helmPackageName"> Helm package name. </param>
        /// <param name="helmPackageVersionRange"> Helm package version range. </param>
        /// <param name="registryValuesPaths"> The registry values path list. </param>
        /// <param name="imagePullSecretsValuesPaths"> The image pull secrets values path list. </param>
        internal HelmArtifactProfile(string helmPackageName, string helmPackageVersionRange, IList<string> registryValuesPaths, IList<string> imagePullSecretsValuesPaths)
        {
            HelmPackageName = helmPackageName;
            HelmPackageVersionRange = helmPackageVersionRange;
            RegistryValuesPaths = registryValuesPaths;
            ImagePullSecretsValuesPaths = imagePullSecretsValuesPaths;
        }

        /// <summary> Helm package name. </summary>
        public string HelmPackageName { get; set; }
        /// <summary> Helm package version range. </summary>
        public string HelmPackageVersionRange { get; set; }
        /// <summary> The registry values path list. </summary>
        public IList<string> RegistryValuesPaths { get; }
        /// <summary> The image pull secrets values path list. </summary>
        public IList<string> ImagePullSecretsValuesPaths { get; }
    }
}
