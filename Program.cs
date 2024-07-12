using System;
using ATM.Services;
using Logger.Services;

namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATMService bankService = new ATMService();

            Print logger = new Print();

            decimal balance = 1000.00m;

            var userInput = ShowMenu();
            // int selectedOption = int.Parse(userInput);

            do
            {
                switch (userInput)
                {
                    case "1":
                        bankService.CheckBalance(currentBalance: balance);
                        break;
                    case "2":
                        bankService.DepositMoney(currentBalance: balance);
                        break;
                    case "3":
                        bankService.WithdrawMoney(currentBalance: balance);
                        break;
                    case "4":
                        Print("Thank you for using the ATM. Goodbye!");
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;

                }
                userInput = ShowMenu();
            }
            while (userInput != "exit");
        }

        private static string ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Please select an option: ");

            return Console.ReadLine();
        }
    }




}
