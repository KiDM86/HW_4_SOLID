using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_SOLID
{
    public class User
    {
        IGameConfig _settingsGetter;
        ITryInput _answerReader;

        public User(IGameConfig settingsGetter, ITryInput answerReader)
        {
            _settingsGetter = settingsGetter;
            _answerReader = answerReader;
        }

        public IGameScore Play(IGame gameToPlay)
        {
            return gameToPlay.Play(_settingsGetter, _answerReader);
        }
    }
}
