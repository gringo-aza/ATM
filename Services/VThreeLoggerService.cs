using System;

namespace ATM.Services
{
    public class VThreeLoggerService : ILoggerService
    {
        public void Info(string Text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"second version {Text}");
        }

    }
}