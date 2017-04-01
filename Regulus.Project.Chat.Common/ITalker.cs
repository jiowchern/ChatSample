﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Regulus.Project.Chat.Common
{
    public interface ITalker
    {
        string Name { get; }
        event Action<string> MessageEvent;
    }
}
