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
        public static string GetUserInputFor(string prompt, string response)
        {
            response = ValidateInput(prompt, response); // INCOMPLETE
            return response;
        }
        public static string ValidateInput(string prompt, string response) 
        {
            Console.Write(prompt);
            return Console.ReadLine();
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
