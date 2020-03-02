using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        int numberOfContestants;
        string name;
        public string Name { get => name; }

        public Sweepstakes(string name, int numberOfContestants)
        {
            this.name = name;
            this.numberOfContestants = numberOfContestants;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestant.RegistrationNumber = GetRegistrationNumber();
            contestants.Add(contestant.RegistrationNumber, contestant);
        }
        private int GetRegistrationNumber()
        {
            int registrationNumber = -1;
            int count = 1; // ***
            if (contestants.Count == 0)
            {
                registrationNumber = UserInterface.rng.Next(numberOfContestants);
                Console.WriteLine("Registration number: " + registrationNumber);
                Console.WriteLine("registration count: " + count); // *** 
                count++;
            }
            else
            {
                while (contestants.ContainsKey(registrationNumber) || registrationNumber < 0)
                {
                    registrationNumber = UserInterface.rng.Next(numberOfContestants);
                    Console.WriteLine("Registration number: " + registrationNumber);
                    Console.WriteLine((contestants.Count + 1) + " registration count: " + count); // *** 
                    count++;
                }
            }
            return registrationNumber;
        }
        public Contestant PickWinner()
        {
            int winnerId = -1;
            Contestant winner;
            int count = 1;// ***
            while (!contestants.ContainsKey(winnerId))
            {
                winnerId = UserInterface.rng.Next(numberOfContestants);
                Console.WriteLine("WinnerID: " + winnerId);//***
                Console.WriteLine("Pick winner count: " + count); // ***
                count++;
            }
            contestants.TryGetValue(winnerId, out winner);
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("  Contestant name: " + contestant.FirstName + " " + contestant.LastName + "\n" +
                              " Contestant email: " + contestant.EmailAddress                          + "\n" +
                              "    Contestant ID: " + contestant.RegistrationNumber                    + "\n");
        }
    }
}
