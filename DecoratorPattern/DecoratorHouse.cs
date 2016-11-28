using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 装修房
    /// </summary>
    public abstract class DecoratorHouse : AbstractHouse
    {
        private readonly AbstractHouse house;

        public DecoratorHouse(AbstractHouse house)
        {
            this.house = house;
        }
        public override void Show()
        {
            this.house.Show();
        }
    }

    /// <summary>
    /// 装修房--样板房
    /// </summary>
    public class ModelHouse : DecoratorHouse
    {
        public ModelHouse(AbstractHouse house) : base(house)
        {
        }

        /// <summary>
        /// 展示样板房细节
        /// </summary>
        private void ShowDetail()
        {
            Console.WriteLine(@"
* 首先，您看到的是我们大概5平方的简单实用的入户花园。
* 样板间的整体按欧式风格装修，精致温馨。
* 进门右看是我们的餐厨一体化设计，客厅与餐厅动线相连，扩大了整个的空间视野。
* 与客厅无缝连接的是超大的观景阳台，东南朝向，阳光充沛。
* 动静分离的设计，将客厅与卧室进行有效的分离，保证了私密性及舒适度。
* 主卧的落地窗设计，提供了足够的室内的采光度。
* 主卧旁边的是干湿分离的卫生间。
* 再旁边就是两个紧挨的房间，可按居家情况设计为儿童房、老人房或书房。");
        }

        public override void Show()
        {
            base.Show();
            ShowDetail();
        }
    }
}
