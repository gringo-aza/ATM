using System;

namespace ATM.Services
{
    public class VTwoLoggerService : ILoggerService
    {
        public void Info(string Text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"second version {Text}");
        }

    }
}