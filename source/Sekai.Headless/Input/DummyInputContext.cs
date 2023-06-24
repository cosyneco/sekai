// Copyright (c) Cosyne
// Licensed under MIT. See LICENSE for details.

using System;
using System.Collections.Generic;
using System.Linq;
using Sekai.Input;

namespace Sekai.Headless.Input;

internal sealed class DummyInputContext : IInputContext
{
    public IEnumerable<IInputDevice> Devices => Enumerable.Empty<IInputDevice>();

#pragma warning disable CS0067

    public event Action<IInputDevice, bool>? ConnectionChanged;

#pragma warning restore CS0067
}
