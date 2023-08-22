// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> The component resource deployment status. </summary>
    public readonly partial struct Status : IEquatable<Status>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Status"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Status(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string DeployedValue = "Deployed";
        private const string UninstalledValue = "Uninstalled";
        private const string SupersededValue = "Superseded";
        private const string FailedValue = "Failed";
        private const string UninstallingValue = "Uninstalling";
        private const string PendingInstallValue = "Pending-Install";
        private const string PendingUpgradeValue = "Pending-Upgrade";
        private const string PendingRollbackValue = "Pending-Rollback";
        private const string DownloadingValue = "Downloading";
        private const string InstallingValue = "Installing";
        private const string ReinstallingValue = "Reinstalling";
        private const string RollingbackValue = "Rollingback";
        private const string UpgradingValue = "Upgrading";

        /// <summary> Unknown. </summary>
        public static Status Unknown { get; } = new Status(UnknownValue);
        /// <summary> Deployed. </summary>
        public static Status Deployed { get; } = new Status(DeployedValue);
        /// <summary> Uninstalled. </summary>
        public static Status Uninstalled { get; } = new Status(UninstalledValue);
        /// <summary> Superseded. </summary>
        public static Status Superseded { get; } = new Status(SupersededValue);
        /// <summary> Failed. </summary>
        public static Status Failed { get; } = new Status(FailedValue);
        /// <summary> Uninstalling. </summary>
        public static Status Uninstalling { get; } = new Status(UninstallingValue);
        /// <summary> Pending-Install. </summary>
        public static Status PendingInstall { get; } = new Status(PendingInstallValue);
        /// <summary> Pending-Upgrade. </summary>
        public static Status PendingUpgrade { get; } = new Status(PendingUpgradeValue);
        /// <summary> Pending-Rollback. </summary>
        public static Status PendingRollback { get; } = new Status(PendingRollbackValue);
        /// <summary> Downloading. </summary>
        public static Status Downloading { get; } = new Status(DownloadingValue);
        /// <summary> Installing. </summary>
        public static Status Installing { get; } = new Status(InstallingValue);
        /// <summary> Reinstalling. </summary>
        public static Status Reinstalling { get; } = new Status(ReinstallingValue);
        /// <summary> Rollingback. </summary>
        public static Status Rollingback { get; } = new Status(RollingbackValue);
        /// <summary> Upgrading. </summary>
        public static Status Upgrading { get; } = new Status(UpgradingValue);
        /// <summary> Determines if two <see cref="Status"/> values are the same. </summary>
        public static bool operator ==(Status left, Status right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Status"/> values are not the same. </summary>
        public static bool operator !=(Status left, Status right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Status"/>. </summary>
        public static implicit operator Status(string value) => new Status(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Status other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Status other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
