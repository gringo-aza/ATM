using System;

namespace ATM.Services
{
    public class VOneLoggerService : ILoggerService
    {
        public void Info(string Text)
        {
            Console.WriteLine(Text);
        }

    }
}