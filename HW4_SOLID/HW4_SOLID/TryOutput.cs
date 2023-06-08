using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_SOLID
{
    public class TryOutput : ITryOutput
    {
        public void Output(IGameScore playScores)
        {
            if (playScores.GoodJob)
                Console.WriteLine("Верно!Вы победили!");
            else
            {
                Console.WriteLine("До новых встреч!");
                Console.WriteLine(playScores.Message);
            }
        }
    }
}
