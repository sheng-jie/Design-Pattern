using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 抽象角色（模块）
    /// 主要实现中介的依赖注入
    /// </summary>
    public abstract class Role
    {
        protected AbstractMediator mediator;

        public Role(AbstractMediator mediator)
        {
            this.mediator = mediator;
        }
    }

    /// <summary>
    /// 购房（者）市场
    /// </summary>
    public class HomeBuyer : Role
    {
        private readonly string name = "购房市场：";
        public HomeBuyer(AbstractMediator mediator)
            : base(mediator)
        {

        }
        private static int requirement = 800;//购房需求

        public void BuyHouse(int num)
        {
            string rule = mediator.GetRule();

            Console.WriteLine(name + "需要买房：" + num + "套");

            if (rule != "LimitBuy")
            {
                requirement += num;
            }
            else
            {
                Console.WriteLine(name + "国家实例了限购政策，不允许购买");
            }
        }

        /// <summary>
        /// 签订购房合同
        /// </summary>
        /// <param name="num"></param>
        public void SignAgreement(int num)
        {
            requirement -= num;
            Console.WriteLine(string.Format("{0}成功购房{1}套", name, num));
        }

        public int GetRequirement()
        {
            return requirement;
        }
    }

    /// <summary>
    /// 房地产商
    /// </summary>
    public class Builder : Role
    {
        private readonly string name = "房地产商：";
        public Builder(AbstractMediator mediator)
            : base(mediator)
        {

        }

        private static int houseNum = 1000;

        public void BuildHouse()
        {
            int requirement = mediator.GetBuyRequirement();
            if (houseNum < requirement)
            {
                //房源不够，立马新建
                int needBuild = requirement - houseNum + 100;
                Console.WriteLine(name + "建房：" + needBuild + "套");
                houseNum += needBuild;
            }
        }

        public void SaleHouse(int num)
        {
            if (houseNum < num)
            {
                string rule = mediator.GetRule();

                if (rule != "LimitBuild")
                {
                    Console.WriteLine(name + "房源不够，正在建设中");
                    this.BuildHouse();
                }
            }
            else
            {
                houseNum -= num;
                Console.WriteLine(name + "卖房：" + num + "套");
                //告诉购房者签订合同
                mediator.HomeBuyer.SignAgreement(num);
            }
        }

        public int ShowHouseNum()
        {
            return houseNum;
        }
    }

    /// <summary>
    /// 住建局
    /// </summary>
    public class ControlCenter : Role
    {
        public ControlCenter(AbstractMediator mediator)
            : base(mediator)
        {

        }
        private readonly string name = "住建局：";
        private static string rule;

        /// <summary>
        /// 当需大于供，限购
        /// 当供大于需，限建
        /// </summary>
        public void Limit()
        {
            int requirement = mediator.GetBuyRequirement();
            int buildingNum = mediator.GetCurrentHouseNumber();

            string strs = string.Format("{0}目前购房需求为：{1}套;现有房源：{2}套。", name,requirement, buildingNum);

            if (requirement > buildingNum)
            {
                Console.WriteLine(strs + "供小于需，开始实施限购政策");
                rule = "LimitBuy";
            }
            else
            {
                Console.WriteLine(strs + "供大于需，开始实施限建政策");
                rule = "LimitBuild";
            }
        }

        public string ShowRule()
        {
            return rule;
        }

    }

    /// <summary>
    /// 抽象中介，定义各模块依赖的功能
    /// </summary>
    public abstract class AbstractMediator
    {
        /// <summary>
        /// 使用属性注入
        /// 因为中介可能只需要和部分角色（模块）交互
        /// </summary>
        public HomeBuyer HomeBuyer { get; set; }
        public Builder HouseBuilder { get; set; }
        public ControlCenter ControlCenter { get; set; }

        /// <summary>
        /// 获取购房需求
        /// </summary>
        /// <returns></returns>
        public abstract int GetBuyRequirement();

        /// <summary>
        /// 获取房源数目
        /// </summary>
        /// <returns></returns>
        public abstract int GetCurrentHouseNumber();

        /// <summary>
        /// 获取楼市政策
        /// </summary>
        /// <returns></returns>
        public abstract string GetRule();

    }

    /// <summary>
    /// 具体中介，实现各模块依赖的功能
    /// </summary>
    public class Mediator : AbstractMediator
    {
        public override int GetBuyRequirement()
        {
            return base.HomeBuyer.GetRequirement();
        }

        public override int GetCurrentHouseNumber()
        {
            return base.HouseBuilder.ShowHouseNum();
        }

        public override string GetRule()
        {
            return base.ControlCenter.ShowRule();
        }
    }
}
