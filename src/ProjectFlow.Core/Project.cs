﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFlow.Core
{
    public abstract class Project
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
    }
}
