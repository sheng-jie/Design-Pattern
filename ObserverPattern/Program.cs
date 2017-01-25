using System;
using System.Threading;
using ObserverPattern.SimpleImplement;

namespace ObserverPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SimpleObserverTest();
            Console.ReadLine();
            Console.WriteLine("=======================");
            DelegateObserverTest();
            Console.ReadLine();
        }

        /// <summary>
        ///     测试简单实现的观察者模式
        /// </summary>
        private static void SimpleObserverTest()
        {
            Console.WriteLine("简单实现的观察者模式：");
            Console.WriteLine("=======================");
            //1、初始化鱼竿
            var fishingRod = new FishingRod();

            //2、声明垂钓者
            var jeff = new FishingMan("圣杰");

            //3、将垂钓者观察鱼竿
            fishingRod.AddSubscriber(jeff);

            //4、循环钓鱼
            while (jeff.FishCount < 5)
            {
                fishingRod.Fishing();
                Console.WriteLine("-------------------");
                //睡眠5s
                Thread.Sleep(5000);
            }
        }

        /// <summary>
        ///     测试委托实现的观察者模式
        /// </summary>
        private static void DelegateObserverTest()
        {
            Console.WriteLine("委托实现的观察者模式：");
            Console.WriteLine("=======================");
            //1、初始化鱼竿
            var fishingRod = new DelegateImplement.FishingRod();

            //2、声明垂钓者
            var jeff = new DelegateImplement.FishingMan("圣杰");

            //3、注册观察者
            fishingRod.FishingEvent += jeff.Update;

            //4、循环钓鱼
            while (jeff.FishCount < 5)
            {
                fishingRod.Fishing();
                Console.WriteLine("-------------------");
                //睡眠5s
                Thread.Sleep(5000);
            }
        }
    }
}