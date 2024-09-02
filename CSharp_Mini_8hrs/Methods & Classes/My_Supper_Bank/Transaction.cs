using System;

namespace My_Supper_Bank
{

    public class Transaction
    {
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Notes { get; }


    public Transaction(decimal amount, DateTime date, string note) // 1. Create a constructor for Transaction
    {
        Amount = amount;
        Date = date;
        Notes = note;
    }

    }
}