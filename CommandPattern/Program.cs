using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //申明和平收复台湾命令
            Command focusCommand = new RecaptureTaiwanByPeaceCommand();

            //申明调用者
            Invoker invoker = new Invoker(focusCommand);
            invoker.InovkerName = "习大大";

            //下达命令
            invoker.Invoke();

            Console.WriteLine("-------------------------------");

            //申明武力收复台湾命令
            Command peaceCommand = new RecaptureTaiwanByFocusCommand();

            invoker = new Invoker(peaceCommand);
            invoker.InovkerName = "习大大";

            invoker.Invoke();

            Console.ReadLine();
        }
    }
}
