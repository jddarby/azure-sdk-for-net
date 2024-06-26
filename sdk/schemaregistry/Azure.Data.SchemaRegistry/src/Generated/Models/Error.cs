// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Data.SchemaRegistry.Models
{
    /// <summary> An error response returned from Azure Schema Registry service. </summary>
    internal partial class Error
    {
        /// <summary> Initializes a new instance of <see cref="Error"/>. </summary>
        /// <param name="errorProperty"> Error response returned from Azure Schema Registry service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="errorProperty"/> is null. </exception>
        internal Error(ErrorDetail errorProperty)
        {
            Argument.AssertNotNull(errorProperty, nameof(errorProperty));

            ErrorProperty = errorProperty;
        }

        /// <summary> Error response returned from Azure Schema Registry service. </summary>
        public ErrorDetail ErrorProperty { get; }
    }
}
