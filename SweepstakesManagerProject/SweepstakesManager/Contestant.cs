using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManager
{
    class Contestant
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private int registrationNumber;
        public string FirstName { get => firstName; }
        public string LastName { get => lastName; }
        public string EmailAddress { get => emailAddress; }

        public int RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }
        public Contestant(string firstName, string lastName, string emailAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
        }
    }
}
