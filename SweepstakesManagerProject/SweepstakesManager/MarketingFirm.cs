using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class MarketingFirm
    {
        private ISweepstakesManager _manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }
        public void CreateSweepstakes() { }
    }
}
