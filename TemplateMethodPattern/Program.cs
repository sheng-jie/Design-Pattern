using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //组装HP电脑
            Console.WriteLine("开始组织Hp电脑:");
            AssembleComputer assembleHpComputer = new AssembleHpComputer();

            assembleHpComputer.Assemble();

            Console.ReadLine();

            //组装DELL电脑
            Console.WriteLine("开始组织DELL电脑:");
            AssembleComputer assembleDellComputer = new AssembleDellComputer();

            assembleDellComputer.Assemble();

            Console.ReadLine();
        }
    }
}
