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
        public SweepstakesQueueManager() { queue = new Queue<Sweepstake>(); }
        public void InsertSweepstake(Sweepstake sweepstake){ queue.Enqueue(sweepstake); }
        public Sweepstake GetSweepstake() { return queue.Dequeue(); }
    }
}
