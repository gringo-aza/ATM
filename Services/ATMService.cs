using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Services
{

    internal class ATMService
    {

        private ILoggerService loggerService;

        private ILoggerService loggerServiceError;


        public ATMService()
        {
            this.loggerService = new VTwoLoggerService();
            this.loggerServiceError = new VThreeLoggerService();


        }

        internal void CheckBalance(decimal currentBalance)
        {
            this.loggerService.Info($"Your current balance is: {currentBalance}");
            Console.ReadKey();
        }


        internal void DepositMoney(decimal currentBalance)
        {
            Console.Write("Enter the amount to deposit: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            if (depositAmount > 0)
            {
                currentBalance += depositAmount;
                this.loggerService.Info($"You have successfully deposited {depositAmount}. Your new balance is {currentBalance}.");
                Console.ReadKey();

            }
            else
            {
                this.loggerServiceError.Info("Invalid deposit amount.");
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
                this.loggerService.Info($"You have successfully withdrawn {withdrawAmount}. Your new balance is {currentBalance}.");
                Console.ReadKey();

            }
            else if (withdrawAmount > currentBalance)
            {
                this.loggerService.Info("Insufficient funds...");
                Console.ReadKey();

            }
            else
            {
                this.loggerService.Info("Invalid withdrawal amount...");
                Console.ReadKey();

            }

        }




    }

}
