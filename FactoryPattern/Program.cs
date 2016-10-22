using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        //简单工厂：简单实用，但违反开放封闭；
        //工厂方法：开放封闭，单一产品；
        //抽象工厂：开放封闭，多个产品；
        //反射工厂：可以最大限度的解耦。 
        static void Main(string[] args)
        {
            TestSimpleFactory();
            TestFactoryMethod();
            TestReflectFactory();
            TestAbstractFactory();
        }

        /// <summary>
        /// 测试简单工厂模式
        /// </summary>
        private static void TestSimpleFactory()
        {
            Console.WriteLine("简单工厂模式：");
            var productA = SimpleFactory.Create(ProductEnum.ConcreateProductA);
            productA.GetInfo();
            Console.ReadLine();
        }

        /// <summary>
        /// 测试工厂方法模式
        /// </summary>
        private static void TestFactoryMethod()
        {
            Console.WriteLine("工厂方法模式：");
            IFactoryMethod factoryB =new ConcreateFactoryB();
            var productB = factoryB.Create();
            productB.GetInfo();

            Console.ReadLine();
        }

        /// <summary>
        /// 测试反射工厂模式
        /// </summary>
        private static void TestReflectFactory()
        {
            Console.WriteLine("反射工厂模式：");
            var productB = ReflectFactory.Create("FactoryPattern.ConcreateCarB");

            productB.GetInfo();
            Console.ReadLine();
        }

        /// <summary>
        /// 测试抽象工厂模式
        /// </summary>
        private static void TestAbstractFactory()
        {
            Console.WriteLine("抽象工厂模式：");

            var bmwFactory = new BMWFactory();
            bmwFactory.CreateCar().GetInfo();
            bmwFactory.CreateBus().GetInfo();

            var bydFactory = new BYDFactory();
            bydFactory.CreateCar().GetInfo();
            bydFactory.CreateBus().GetInfo();

            Console.ReadLine();
        }


    }
}
