using System;
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
    }
}
