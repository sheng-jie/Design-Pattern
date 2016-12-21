using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelStrategy travelPlan = null;

            Weather weather = (Weather)(new Random().Next(1,3));
            switch (weather)
            {
                case Weather.Rain:
                    Console.WriteLine("天气糟糕");
                    travelPlan = new BackupTravel() ;
                    break;
                case Weather.Sunny:
                    Console.WriteLine("天气晴好");
                    travelPlan = new GuangxiTravel() { Budget = 3000 };
                    break;
            }

            travelPlan.TravelPlan();

            Console.ReadLine();

        }
    }

    enum Weather
    {
        Sunny =1,
        Rain = 2
    }
}
