using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 指挥者（采购经理）
    /// </summary>
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildMainFramePart();
            builder.BuildScreenPart();
            builder.BuildInputPart();
        }
    }

    /// <summary>
    /// 建造者（模拟装机过程）
    /// 也可通过接口实现
    /// </summary>
    public abstract class Builder
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
        /// 获取组装电脑
        /// </summary>
        /// <returns></returns>
        public abstract Computer GetComputer();
    }

    /// <summary>
    /// 惠普电脑组装商
    /// </summary>
    public class HpBulider : Builder
    {
        Computer hp = new Computer() { Band = "惠普" };

        public override void BuildMainFramePart()
        {
            hp.AssemblePart("主机");
        }

        public override void BuildScreenPart()
        {
            hp.AssemblePart("显示器");
        }

        public override void BuildInputPart()
        {
            hp.AssemblePart("键鼠");
        }

        public Computer GetComputer()
        {
            return hp;
        }
    }

    /// <summary>
    /// 戴尔电脑组装商
    /// </summary>
    public class DellBulider : Builder
    {
        Computer dell = new Computer() { Band = "戴尔" };

        public override void BuildMainFramePart()
        {
            dell.AssemblePart("主机");
        }

        public override void BuildScreenPart()
        {
            dell.AssemblePart("显示器");
        }

        public override void BuildInputPart()
        {
            dell.AssemblePart("键鼠");
        }

        public Computer GetComputer()
        {
            return dell;
        }
    }

    /// <summary>
    /// 产品类
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// 品牌
        /// </summary>
        public string Band { get; set; }

        /// <summary>
        /// 电脑组件列表
        /// </summary>
        private List<string> assemblyParts = new List<string>();

        /// <summary>
        /// 组装部件
        /// </summary>
        /// <param name="partName">部件名称</param>
        public void AssemblePart(string partName)
        {
            this.assemblyParts.Add(partName);
        }

        public void ShowProcess()
        {
            Console.WriteLine("开始组装『{0}』电脑:", Band);
            foreach (var part in assemblyParts)
            {
                Console.WriteLine(string.Format("组装『{0}』;", part));
            }

            Console.WriteLine("组装『{0}』电脑完毕！", Band);
        }
    }
}