using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 组装电脑
    /// </summary>
    public abstract class AssembleComputer
    {
        /// <summary>
        /// 组装主机
        /// </summary>
        public abstract void BuildMainFramePart();

        /// <summary>
        /// 组装显示器
        /// </summary>
        public abstract void BuildScreenPart();

        /// <summary>
        /// 组装输入设备（键鼠）
        /// </summary>
        public abstract void BuildInputPart();

        /// <summary>
        /// 组装起来
        /// </summary>
        public void Assemble()
        {
            BuildMainFramePart();
            BuildScreenPart();
            BuildInputPart();
        }

    }

    /// <summary>
    /// 组装HP电脑
    /// </summary>
    public class AssembleHpComputer : AssembleComputer
    {
        public override void BuildMainFramePart()
        {
            Console.WriteLine("组装HP电脑的主板");
        }

        public override void BuildScreenPart()
        {
            Console.WriteLine("组装HP电脑的显示器");
        }

        public override void BuildInputPart()
        {
            Console.WriteLine("组装HP电脑的键盘鼠标");
        }
    }

    /// <summary>
    /// 组装HP电脑
    /// </summary>
    public class AssembleDellComputer : AssembleComputer
    {
        public override void BuildMainFramePart()
        {
            Console.WriteLine("组装Dell电脑的主板");
        }

        public override void BuildScreenPart()
        {
            Console.WriteLine("组装Dell电脑的显示器");
        }

        public override void BuildInputPart()
        {
            Console.WriteLine("组装Dell电脑的键盘鼠标");
        }
    }


}
