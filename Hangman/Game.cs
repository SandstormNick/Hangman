using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Game
    {
        private bool gameRun = true;

        #region Methods
        public bool GetGameStatus()
        {
            return gameRun;
        }
        #endregion
    }
}
