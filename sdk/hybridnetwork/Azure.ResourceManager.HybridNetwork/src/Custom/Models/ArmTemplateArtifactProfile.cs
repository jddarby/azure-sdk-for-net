// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Template artifact profile. </summary>
    public partial class ArmTemplateArtifactProfile
    {
        /// <summary> Initializes a new instance of ArmTemplateArtifactProfile. </summary>
        public ArmTemplateArtifactProfile()
        {
        }

        /// <summary> Initializes a new instance of ArmTemplateArtifactProfile. </summary>
        /// <param name="templateName"> Template name. </param>
        /// <param name="templateVersion"> Template version. </param>
        internal ArmTemplateArtifactProfile(string templateName, string templateVersion)
        {
            TemplateName = templateName;
            TemplateVersion = templateVersion;
        }

        /// <summary> Template name. </summary>
        public string TemplateName { get; set; }
        /// <summary> Template version. </summary>
        public string TemplateVersion { get; set; }
    }
}
