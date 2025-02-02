// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

namespace System.Text.Json.Serialization
{
    internal struct ReferenceEqualsWrapper : IEquatable<ReferenceEqualsWrapper>
    {
        private readonly object _object;

        public ReferenceEqualsWrapper(object obj) => _object = obj;

        public override bool Equals([NotNullWhen(true)] object? obj) => obj is ReferenceEqualsWrapper otherObj && Equals(otherObj);
        public bool Equals(ReferenceEqualsWrapper obj) => ReferenceEquals(_object, obj._object);
        public override int GetHashCode() => RuntimeHelpers.GetHashCode(_object);
    }
}
