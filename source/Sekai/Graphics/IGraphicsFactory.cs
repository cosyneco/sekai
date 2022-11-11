// Copyright (c) The Vignette Authors
// Licensed under MIT. See LICENSE for details.

using Sekai.Graphics.Buffers;
using Sekai.Graphics.Shaders;
using Sekai.Graphics.Textures;

namespace Sekai.Graphics;

/// <summary>
/// Factory for creating graphics resources.
/// </summary>
public interface IGraphicsFactory
{
    /// <summary>
    /// Creates a shader used for computing.
    /// </summary>
    INativeShader CreateShader(string comp);

    /// <summary>
    /// Creates a shader used for graphics.
    /// </summary>
    INativeShader CreateShader(string vert, string frag);

    /// <summary>
    /// Creates a buffer.
    /// </summary>
    INativeBuffer CreateBuffer(int capacity, bool dynamic);

    /// <summary>
    /// Creates a texture.
    /// </summary>
    INativeTexture CreateTexture(int width, int height, int depth, int level, int layers, FilterMode min, FilterMode mag, WrapMode wrapModeS, WrapMode wrapModeT, WrapMode wrapModeR, TextureType type, TextureUsage usage, TextureSampleCount sampleCount, PixelFormat format);

    /// <summary>
    /// Creates a framebuffer.
    /// </summary>
    INativeFrameBuffer CreateFramebuffer();
}
