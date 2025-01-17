// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The protocol used to connect to the target. </summary>
    internal readonly partial struct BastionConnectProtocol : IEquatable<BastionConnectProtocol>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="BastionConnectProtocol"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BastionConnectProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SSHValue = "SSH";
        private const string RDPValue = "RDP";

        /// <summary> SSH. </summary>
        public static BastionConnectProtocol SSH { get; } = new BastionConnectProtocol(SSHValue);
        /// <summary> RDP. </summary>
        public static BastionConnectProtocol RDP { get; } = new BastionConnectProtocol(RDPValue);
        /// <summary> Determines if two <see cref="BastionConnectProtocol"/> values are the same. </summary>
        public static bool operator ==(BastionConnectProtocol left, BastionConnectProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BastionConnectProtocol"/> values are not the same. </summary>
        public static bool operator !=(BastionConnectProtocol left, BastionConnectProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BastionConnectProtocol"/>. </summary>
        public static implicit operator BastionConnectProtocol(string value) => new BastionConnectProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BastionConnectProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BastionConnectProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
