// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary>
    /// The resource element template object.
    /// Please note <see cref="ResourceElementTemplate"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ArmResourceDefinitionResourceElementTemplateDetails"/> and <see cref="NetworkFunctionDefinitionResourceElementTemplateDetails"/>.
    /// </summary>
    public abstract partial class ResourceElementTemplate
    {
        /// <summary> Initializes a new instance of ResourceElementTemplate. </summary>
        protected ResourceElementTemplate()
        {
        }

        /// <summary> Initializes a new instance of ResourceElementTemplate. </summary>
        /// <param name="name"> Name of the resource element template. </param>
        /// <param name="resourceElementTemplateType"> The resource element template type. </param>
        /// <param name="dependsOnProfile"> The depends on profile. </param>
        internal ResourceElementTemplate(string name, Type resourceElementTemplateType, DependsOnProfile dependsOnProfile)
        {
            Name = name;
            ResourceElementTemplateType = resourceElementTemplateType;
            DependsOnProfile = dependsOnProfile;
        }

        /// <summary> Name of the resource element template. </summary>
        public string Name { get; set; }
        /// <summary> The resource element template type. </summary>
        internal Type ResourceElementTemplateType { get; set; }
        /// <summary> The depends on profile. </summary>
        public DependsOnProfile DependsOnProfile { get; set; }
    }
}
