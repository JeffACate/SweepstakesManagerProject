using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    public static class UserInterface<T>
    {
        public static string GetUserInputFor(string prompt, T requirements)
        {
            bool invalidInput = false;
            string response = null;
            while (invalidInput)
            {
                Console.Write(prompt);
                response = Console.ReadLine();
                invalidInput = ValidateInput(response, requirements); // INCOMPLETE
            }
            return response;
        }
        static bool ValidateInput(string response, T requirements)
        {
            Console.WriteLine("Setup Data Validation");
            return true;
        }
        
    }
}
