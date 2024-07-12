using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services
{
    internal class ATMService
    {


        internal void CheckBalance(decimal currentBalance)
        {
            Console.WriteLine($"Your current balance is: {currentBalance}");
            Console.ReadKey();

        }


        internal void DepositMoney(decimal currentBalance)
        {
            Console.Write("Enter the amount to deposit: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            if (depositAmount > 0)
            {
                currentBalance += depositAmount;
                Console.WriteLine($"You have successfully deposited {depositAmount}. Your new balance is {currentBalance}.");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
                Console.ReadKey();
            }

        }

        internal void WithdrawMoney(decimal currentBalance)
        {
            Console.Write("Enter the amount to withdraw: ");
            decimal withdrawAmount = decimal.Parse(Console.ReadLine());
            if ((withdrawAmount > 0) && (withdrawAmount <= currentBalance))
            {
                currentBalance -= withdrawAmount;
                Console.WriteLine($"You have successfully withdrawn {withdrawAmount}. Your new balance is {currentBalance}.");
                Console.ReadKey();

            }
            else if (withdrawAmount > currentBalance)
            {
                Console.WriteLine("Insufficient funds...");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount...");
                Console.ReadKey();

            }

        }




    }

}
