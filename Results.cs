// difficutly setting should probably be done during the INITIALIZE game state.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGuessing
{
    public struct Result
    {
        public bool isCorrect;
        public string rankMessage;
        public int offBy;
    }
}
