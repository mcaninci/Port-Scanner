﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Interface
{
    public interface IPortRange
    {
        bool MorePorts();
        int NextPort();
        void ResetPorts();
        int GetStartPort();

        int GetEndPort();
        void UpdatePortRange(int threadCount, int threadIndex);
    }
}
