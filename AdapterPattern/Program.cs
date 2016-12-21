using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //在未定义充电标准之前，各个厂家充电线的实现各不相同，但都可以为自家品牌设备充电
            USBLine usbLine = new USBLine();
            usbLine.Charge();

            Console.WriteLine("-------------------");
            //随着电器设备越来越多，各家的充电设备不能通用，造成很多不便，为了共用，厂家联合推出标准充电接口。

            //USB-Micro实现标准接口。
            IChargingLine microLine = new USBMicroLine();
            microLine.Charging();

            Console.WriteLine("-------------------");

            //现在手里有一个未实现充电标准的充电线，通过适配器，为小米5设备充电
            Console.WriteLine("对象适配器模式：");
            IChargingLine typeCLineAdapter = new USBTypecLineAdapter(usbLine);
            typeCLineAdapter.Charging();

            Console.WriteLine("-------------------");

            //现在手里有一个未实现充电标准的充电线，通过适配器，为苹果设备充电
            Console.WriteLine("类适配器模式：");
            IChargingLine lightingLineAdapter = new USBlightingLineAdapter();
            lightingLineAdapter.Charging();

            Console.ReadLine();
        }
    }
}
