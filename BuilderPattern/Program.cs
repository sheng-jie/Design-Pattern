using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            HpBulider hpBuilder = new HpBulider();
            DellBulider dellBuilder =new DellBulider();

            //组装一批惠普电脑
            director.Construct(hpBuilder);
            Computer hp =  hpBuilder.GetComputer();
            hp.ShowProcess();

            Console.ReadLine();

            //组装一批戴尔电脑
            director.Construct(dellBuilder);
            Computer dell = dellBuilder.GetComputer();
            dell.ShowProcess();

            Console.ReadLine();
        }
    }
}
