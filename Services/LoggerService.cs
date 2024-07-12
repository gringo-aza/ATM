using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Services
{
    public abstract class Logger
    {
        public abstract void Info(string Text);

    }

    public class Print: Logger
    {
        public override void Info(string Text)
        {
            Console.WriteLine(Text);
        }

    }


}
