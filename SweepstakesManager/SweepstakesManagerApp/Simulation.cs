using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class Simulation
    {
        MarketingFirm marketingFirm;
        public void Run()
        {
            CreateMarketingFirmWithManager();
            marketingFirm.CreateSweepstakes();
        }
        public void CreateMarketingFirmWithManager()
        {
            string manager = UserInterface.PickManager();
           
            switch (manager)
            { 
                case "FIFO":
                case "FOFI":
                     marketingFirm = new MarketingFirm(new SweepstakesQueueManager());
                    break;
                case "LILO":
                case "LOLI":
                    marketingFirm = new MarketingFirm(new SweepstakesStackManager());
                    break;
            }
        }
    }
}
