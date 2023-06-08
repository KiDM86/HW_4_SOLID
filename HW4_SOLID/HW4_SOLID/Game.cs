using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_SOLID
{
    public class Game : IGame
    {
        public virtual IGameScore Play(IGameConfig gameSettings, ITryInput tryInput)
        {
            var secret = new Random();
            var number = secret.Next(gameSettings.StartRange, gameSettings.EndRange);
            bool secretIsOut = false;

            var report = tryInput.Input(0);
            if (report == number)
            {
                secretIsOut = true;
            }

            var gameResults = new GameResults();
            if (secretIsOut)
            {
                gameResults.GoodJob = true;
            }
            else
            {
                gameResults.GoodJob = false;
                gameResults.Message = $"Вы не угадали число {report}!Попытки закончились!";
            }
            return gameResults;
        }
    }
}
