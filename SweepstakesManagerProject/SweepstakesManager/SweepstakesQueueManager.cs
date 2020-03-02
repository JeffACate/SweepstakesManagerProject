using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        private Queue<Sweepstakes> queue;
        
        public void InsertSweepstakes(Sweepstakes sweepstakes){ }
        public Sweepstakes GetSweepstakes() { throw new NotImplementedException(); }
    }
}
