using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        private Queue<Sweepstake> queue;
        
        public void InsertSweepstakes(Sweepstake sweepstakes){ }
        public Sweepstake GetSweepstakes() { throw new NotImplementedException(); }
    }
}
