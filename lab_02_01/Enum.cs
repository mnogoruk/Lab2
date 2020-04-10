using System;

namespace lab_02_01
{
    public enum AccountType { Checking, Deposit };
    class Enum
    {
        static void Main(string[] args)
        {
            AccountType goldAccount; 
            AccountType platinumAccount;
            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;
            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);

        }
    }
}
