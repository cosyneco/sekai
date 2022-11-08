// Copyright (c) The Vignette Authors
// Licensed under MIT. See LICENSE for details.

using System;
using System.Collections.Generic;

namespace Sekai.Framework.Graphics.Shaders;

/// <summary>
/// A shader graphics device.
/// </summary>
public interface INativeShader : IDisposable
{
    /// <summary>
    /// The shader type.
    /// </summary>
    ShaderType Type { get; }

    /// <summary>
    /// The uniforms declared in this shader.
    /// </summary>
    IReadOnlyList<INativeUniform> Uniforms { get; }
}
