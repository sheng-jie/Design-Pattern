using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// 充电线
    /// 最终要适配成的目标角色
    /// </summary>
    public interface IChargingLine
    {
        /// <summary>
        /// 充电方法
        /// </summary>
        void Charging();
    }

    /// <summary>
    /// USB数据线（支持USB-Micro端口的设备）
    /// </summary>
    public class USBMicroLine : IChargingLine
    {
        public void Charging()
        {
            Console.WriteLine("为支持USB-Micro端口的设备充电！");
        }
    }

    /// <summary>
    /// 原装数据线
    /// 未定义充电标准的充电方法
    /// </summary>
    public class USBLine
    {
        public void Charge()
        {
            Console.WriteLine("为设备充电！");
        }
    }

    /// <summary>
    /// 苹果充电线适配器
    /// 类适配器模式
    /// </summary>
    public class USBlightingLineAdapter : USBLine, IChargingLine
    {
        public void Charging()
        {
            Console.WriteLine("对USB-Lighting端口的数据线进行适配！");
            base.Charge();
        }
    }

    /// <summary>
    /// 小米5充电线适配器
    /// 对象适配器模式
    /// </summary>
    public class USBTypecLineAdapter: IChargingLine
    {
        private readonly USBLine _usbLine;
        public USBTypecLineAdapter(USBLine usbLine)
        {
            this._usbLine = usbLine;
        }

        public void Charging()
        {
            Console.WriteLine("对USB-TypeC端口的数据线进行适配！");
            this._usbLine.Charge();
        }
    }
}
