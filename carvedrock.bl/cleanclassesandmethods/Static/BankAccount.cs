using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.cleanclassesandmethods.Static
{
    public class BankAccount
    {
        public string AccountName = null!; // Instance member

        public decimal Balance; // Instance member

        public static decimal InterestRate; // Shared member
    }
}
