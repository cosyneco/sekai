﻿// Copyright (c) The Vignette Authors
// Licensed under MIT. See LICENSE for details.

using Sekai;
using Sekai.OpenGL;
using Sekai.SDL;
using Triangle;

Game.Setup<TriangleGame>()
    .UseSDL()
    .UseGL()
    .Run();
