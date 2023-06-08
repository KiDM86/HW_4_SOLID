using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_SOLID
{
    public class TryInput : ITryInput
    {
        public int Input(int tryNum)
        {
            Console.WriteLine($"{tryNum + 1} попытка:");
            var inputNum = Console.ReadLine();
            if (int.TryParse(inputNum, out int result))
                return result;
            else
                throw new ArgumentException($"Некорректный ввод. Используйте целые числа!");
        }

    }
}
