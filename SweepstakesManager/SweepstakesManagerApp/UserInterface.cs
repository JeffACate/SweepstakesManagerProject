using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    public static class UserInterface
    {
        public static Random rng = new Random();
        public static string GetUserInputFor(string prompt)
        {
            Console.Write(prompt);
            string response = ValidateInput();
            return response;
        }
        public static string ValidateInput() { return Console.ReadLine(); }
        public static string PickManager() { return GetUserInputFor("How would you like to manage your sweepstakes (FIFO or LILO): "); }
        public static string NameSweepstake() { return GetUserInputFor("What is the name of this Sweepstake? "); }
        public static int GetNumberOfContestants(string name)
        {
            {
                bool isInvalidInput = false;
                int contestants = -1;
                while (isInvalidInput == false || contestants < 0) { isInvalidInput = Int32.TryParse(GetUserInputFor("How many contestants allowed for " + name +"? "), out contestants); }
                return contestants;
            }
        }

            //private static string ValidateInput(string prompt, int response) 
            //{
            //    bool isInvalidInput = false;
            //    int numberOfItems = -1;

            //    while (isInvalidInput == false || numberOfItems < 0)
            //    {
            //        Console.WriteLine("How many " + itemToUse + " would you like to use?");
            //        Console.Write("Please enter a positive integer: ");
            //        Console.WriteLine();

            //        isInvalidInput = Int32.TryParse(Console.ReadLine(), out numberOfItems);
            //    }
            //    return numberOfItems;
            //}

    }
}
