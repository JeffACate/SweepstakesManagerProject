using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class Simulation
    {

        public void Run()
        {
            CreateMarketingFirmWithManager();
        }
        public void CreateMarketingFirmWithManager()
        {
            string manager = UserInterface.PickManager();
           
            switch (manager)
            { 
                case "FIFO":
                case "FOFI":
                    SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
                    break;
                case "LILO":
                case "LOLI":
                    SweepstakesStackManager stackManager = new SweepstakesStackManager();
                    break;
            }
        }
    }
}
