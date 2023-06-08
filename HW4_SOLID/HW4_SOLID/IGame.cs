using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_SOLID
{
    public interface IGame
    {
        IGameScore Play(IGameConfig gameSettings, ITryInput tryInput);
    }
}
