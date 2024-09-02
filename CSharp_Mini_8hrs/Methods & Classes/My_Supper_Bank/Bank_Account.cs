using System;

namespace My_Supper_Bank

{

public class Bank_Account
    {
        // properties ----
        public string Number { get; } // 1. 10 digit number 
        public string Onwer { get; set;  } // 2. It has a string that stores the name or names of the owners.
        public Decimal Balance { // 3.  The balance can be retrieved.

            get
                {
                    decimal balance = 0;
                    foreach (var item in allTransactions)
                    {
                        //balance = balance + item.Amount;
                        balance += item.Amount;
                    }
                    return balance;

                }
             } 
        
        //Method and Member
        private static int Account_Number_Seed = 1234567890; // static can share inside the class Bank_Account & private to only be use inside this classs

            // 2. make a private list 
        private List<Transaction> allTransactions = new List<Transaction>(); // = new List<Transaction>(); this is the list of transactions

        // 1. is to create Functions _ to make deposit and withdraw
        // then create a constructor for a bank account
        public Bank_Account(string name, int InnitalBalance) // This is a constructor
        {
            Onwer = name;
            MakeDeposit(InnitalBalance, DateTime.Now, "Innital balance");
            // Balance = InnitalBalance; // remove THIS Line since we add a new Balance above. 
            // New balance will be 0 - so, I need create a new MakeDeposit function and the first deposit will five is a new balance

            //set Bank_Account to that Seed 
            Number = Account_Number_Seed.ToString();
            Account_Number_Seed += 1; // increment the seed by 1 for the next account


        }

        // 1. Deposit

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        // 2. WithDraw
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
}
        // ----

    }

 }
