// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure vhd deploy mapping rule profile. </summary>
    public partial class AzureCoreVhdImageDeployMappingRuleProfile : MappingRuleProfile
    {
        /// <summary> Initializes a new instance of AzureCoreVhdImageDeployMappingRuleProfile. </summary>
        internal AzureCoreVhdImageDeployMappingRuleProfile()
        {
        }

        /// <summary> Initializes a new instance of AzureCoreVhdImageDeployMappingRuleProfile. </summary>
        /// <param name="applicationEnablement"> The application enablement. </param>
        /// <param name="vhdImageMappingRuleProfile"> The vhd mapping rule profile. </param>
        internal AzureCoreVhdImageDeployMappingRuleProfile(ApplicationEnablement? applicationEnablement, VhdImageMappingRuleProfile vhdImageMappingRuleProfile) : base(applicationEnablement)
        {
            VhdImageMappingRuleProfile = vhdImageMappingRuleProfile;
        }

        /// <summary> The vhd mapping rule profile. </summary>
        internal VhdImageMappingRuleProfile VhdImageMappingRuleProfile { get; }
        /// <summary> List of values. </summary>
        public string VhdImageMappingRuleUserConfiguration
        {
            get => VhdImageMappingRuleProfile?.UserConfiguration;
        }
    }
}
