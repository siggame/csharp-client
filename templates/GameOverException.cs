using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaMinerAI.Client
{
    class GameOverException : Exception
    {
        public int Winner { get; set; }
        public String Reason { get; set; }

        public GameOverException(int winner, string reason)
        {
            Winner = winner;
            Reason = reason;
        }
    }
}
