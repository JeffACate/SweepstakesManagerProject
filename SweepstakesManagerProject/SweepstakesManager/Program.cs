using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sweepstake sweepstake1 = new Sweepstake("First Sweepstake", 500);
            //Contestant contestantMe = new Contestant("Jeff", "Cate", "jcate207@gmail.com");
            //Contestant contestantNotMe = new Contestant("NOT", "ME", "NOTMINE@YAHOO.COM");
            //sweepstake1.RegisterContestant(contestantMe);
            //sweepstake1.RegisterContestant(contestantNotMe);
            //Contestant winner = sweepstake1.PickWinner();
            //sweepstake1.PrintContestantInfo(winner);
            //Console.ReadKey();
            Simulation simulation = new Simulation();
            simulation.Run();
        }
    }
}
