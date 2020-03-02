using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstake> stack;
        public Sweepstake GetSweepstake() { return stack.Pop(); }
        public void InsertSweepstake(Sweepstake sweepstake) { stack.Push(sweepstake); }
    }
}
