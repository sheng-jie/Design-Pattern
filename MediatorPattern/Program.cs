using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractMediator mediator = new Mediator();

            //声明参与的角色
            HomeBuyer buyer = new HomeBuyer(mediator);
            Builder build = new Builder(mediator);
            ControlCenter center = new ControlCenter(mediator);

            //将需要的角色注入到中介
            mediator.HouseBuilder = build;
            mediator.HomeBuyer = buyer;
            mediator.ControlCenter = center;

            int initRequirement = mediator.GetBuyRequirement();
            int initHousenum = mediator.GetCurrentHouseNumber();

            Console.WriteLine(string.Format("目前购房需求为：{0}套;现有房源：{1}套。", initRequirement, initHousenum));

            //买房300套
            buyer.BuyHouse(300);
            
            build.SaleHouse(300);            

            //国家住建局，考察市场
            center.Limit();

            //再买房1000套
            buyer.BuyHouse(1000);

            Console.ReadLine();
        }
    }
}
