using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("装饰模式：");
            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("先看毛坯房：");
            //未经装修的毛坯房
            var withoutDecoratorHouse = new WithoutDecoratorHouse()
            {
                Area = 80.0,
                Specification="三室一厅一卫",
                Price = 8000
            };

            withoutDecoratorHouse.Show();

            Console.WriteLine("-------------------------------------------------");

            Console.WriteLine("再看样板房：");

            //对毛坯房进行装修
            var decoratorHouse = new ModelHouse(withoutDecoratorHouse);

            decoratorHouse.Show();
            Console.WriteLine("-------------------------------------------------");


            Console.ReadLine();

        }
    }
}
