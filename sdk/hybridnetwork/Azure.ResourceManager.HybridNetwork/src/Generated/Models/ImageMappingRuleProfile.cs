// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Image mapping rule profile. </summary>
    internal partial class ImageMappingRuleProfile
    {
        /// <summary> Initializes a new instance of ImageMappingRuleProfile. </summary>
        internal ImageMappingRuleProfile()
        {
        }

        /// <summary> Initializes a new instance of ImageMappingRuleProfile. </summary>
        /// <param name="userConfiguration"> List of values. </param>
        internal ImageMappingRuleProfile(string userConfiguration)
        {
            UserConfiguration = userConfiguration;
        }

        /// <summary> List of values. </summary>
        public string UserConfiguration { get; }
    }
}
