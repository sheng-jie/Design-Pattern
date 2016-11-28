using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 抽象房类
    /// </summary>
    public abstract class AbstractHouse
    {
        /// <summary>
        /// 面积
        /// </summary>
        public double Area { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        public string Specification { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 定义抽象方法--展示
        /// </summary>
        public abstract void Show();
    }

    /// <summary>
    /// 未装修房 -- 毛坯房
    /// </summary>
    public class WithoutDecoratorHouse : AbstractHouse
    {
        /// <summary>
        /// 毛坯房就做简要展示
        /// </summary>
        public override void Show()
        {
            Console.WriteLine(string.Format("该户型为{0}㎡，户型设计为{1}，目前均价为{2}元/㎡。", this.Area, this.Specification, this.Price));
        }
    }
}
