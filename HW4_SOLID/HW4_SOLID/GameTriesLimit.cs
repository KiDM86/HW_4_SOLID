using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_SOLID
{
    public class GameTriesLimit : Game
    {
        public override IGameScore Play(IGameConfig gameSettings, ITryInput tryInput)
        {
            var secret = new Random();
            var number = secret.Next(gameSettings.StartRange, gameSettings.EndRange);
            bool secretIsOut = false;
            for (int i = 0; i < gameSettings.TriesCount; i++)
            {
                var report = tryInput.Input(i);
                if (report == number)
                {
                    secretIsOut = true;
                    break;
                }

            }
            var gameResults = new GameResults();
            if (secretIsOut)
            {
                gameResults.GoodJob = true;
            }
            else
            {
                gameResults.GoodJob = false;
                gameResults.Message = $"Вы не угадали число {number}!Попытки закончились!";
            }
            return gameResults;
        }
    }
}
