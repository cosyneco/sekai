// Copyright (c) The Vignette Authors
// Licensed under MIT. See LICENSE for details.

using System.Numerics;

namespace Sekai.Framework.Graphics.Vertices;

/// <summary>
/// A vertex that has a position in three-dimensional space.
/// </summary>
public interface IVertex3D : IVertex
{
    /// <summary>
    /// The vertex position.
    /// </summary>
    Vector3 Position { get; set; }
}
