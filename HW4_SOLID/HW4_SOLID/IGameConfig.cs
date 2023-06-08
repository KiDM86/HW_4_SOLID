using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_SOLID
{
    public interface IGameConfig
    {
        public int StartRange { get; }
        public int EndRange { get; }
        public int TriesCount { get; }
    }
}
