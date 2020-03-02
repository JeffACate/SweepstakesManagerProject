using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants;
        string name;
        public string Name { get => name; }

        public Sweepstakes(string name)
        {
            this.name = name;
        }
        public void RegisterContestant(Contestant contestant){ }
        public Contestant PickWinner() { throw new NotImplementedException(); }
        public void PrintContestantInfo(Contestant contestant) { }
    }
}
