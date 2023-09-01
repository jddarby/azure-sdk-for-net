// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> The cluster secret profile. </summary>
    public partial class ClusterSecretsProfile
    {
        /// <summary> Initializes a new instance of ClusterSecretsProfile. </summary>
        /// <param name="keyVaultResourceId"> Name of the user Key Vault where all the cluster specific user secrets are stored. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVaultResourceId"/> is null. </exception>
        public ClusterSecretsProfile(ResourceIdentifier keyVaultResourceId)
        {
            Argument.AssertNotNull(keyVaultResourceId, nameof(keyVaultResourceId));

            KeyVaultResourceId = keyVaultResourceId;
            Secrets = new ChangeTrackingList<ClusterSecretReference>();
        }

        /// <summary> Initializes a new instance of ClusterSecretsProfile. </summary>
        /// <param name="keyVaultResourceId"> Name of the user Key Vault where all the cluster specific user secrets are stored. </param>
        /// <param name="secrets"> Properties of Key Vault secret. </param>
        internal ClusterSecretsProfile(ResourceIdentifier keyVaultResourceId, IList<ClusterSecretReference> secrets)
        {
            KeyVaultResourceId = keyVaultResourceId;
            Secrets = secrets;
        }

        /// <summary> Name of the user Key Vault where all the cluster specific user secrets are stored. </summary>
        public ResourceIdentifier KeyVaultResourceId { get; set; }
        /// <summary> Properties of Key Vault secret. </summary>
        public IList<ClusterSecretReference> Secrets { get; }
    }
}
