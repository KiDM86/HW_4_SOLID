using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_SOLID
{
    public interface IGameScore
    {
        public bool GoodJob { get; set; }
        public string Message { get; set; }
    }
}
