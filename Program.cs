using System;
using ATM.Services;

namespace ATM
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ATMService bankService = new ATMService();

            ILoggerService logger = new VOneLoggerService();

            ILoggerService loggerError = new VThreeLoggerService();




            decimal balance = 1000.00m;

            var userInput = ShowMenu(logger);

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
                        logger.Info("Thank you for using the ATM. Goodbye!");
                        break;
                    default:
                        loggerError.Info("Invalid option. Please try again.");
                        break;

                }
                userInput = ShowMenu(logger);
            }
            while (userInput != "exit");
        }

        private static string ShowMenu(ILoggerService logger)
        {

            Console.Clear();
            logger.Info("Welcome to the ATM");
            logger.Info("1. Check Balance");
            logger.Info("2. Deposit Money");
            logger.Info("3. Withdraw Money");
            logger.Info("4. Exit");
            logger.Info("Please select an option: ");

            return Console.ReadLine();
        }
    }




}
