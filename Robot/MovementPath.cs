﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public interface IMovementPath
    {
        List<int> startPos();

        int movement();
    }
}
