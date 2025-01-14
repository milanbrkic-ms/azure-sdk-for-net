// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Sci mode enabled/disabled. </summary>
    public readonly partial struct ExpressRouteLinkMacSecSciState : IEquatable<ExpressRouteLinkMacSecSciState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ExpressRouteLinkMacSecSciState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ExpressRouteLinkMacSecSciState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static ExpressRouteLinkMacSecSciState Disabled { get; } = new ExpressRouteLinkMacSecSciState(DisabledValue);
        /// <summary> Enabled. </summary>
        public static ExpressRouteLinkMacSecSciState Enabled { get; } = new ExpressRouteLinkMacSecSciState(EnabledValue);
        /// <summary> Determines if two <see cref="ExpressRouteLinkMacSecSciState"/> values are the same. </summary>
        public static bool operator ==(ExpressRouteLinkMacSecSciState left, ExpressRouteLinkMacSecSciState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ExpressRouteLinkMacSecSciState"/> values are not the same. </summary>
        public static bool operator !=(ExpressRouteLinkMacSecSciState left, ExpressRouteLinkMacSecSciState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ExpressRouteLinkMacSecSciState"/>. </summary>
        public static implicit operator ExpressRouteLinkMacSecSciState(string value) => new ExpressRouteLinkMacSecSciState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ExpressRouteLinkMacSecSciState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ExpressRouteLinkMacSecSciState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
