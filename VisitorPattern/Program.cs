using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 访问者模式
/// </summary>
namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                NickName = "圣杰",
                RealName = "圣杰",
                Address = "深圳市南山区",
                Phone = "135****9358",
                Zip = "518000"
            };

            Product productA = new Product { Id = 1, Name = "小米5", Price = 1899 };
            Product productB = new Product { Id = 2, Name = "小米5手机防爆膜", Price = 29 };
            Product productC = new Product { Id = 3, Name = "小米5手机保护套", Price = 69 };

            OrderLine line1 = new OrderLine { Id = 1, Product = productA, Qty = 1 };
            OrderLine line2 = new OrderLine { Id = 1, Product = productB, Qty = 2 };
            OrderLine line3 = new OrderLine { Id = 1, Product = productC, Qty = 3 };

            //先买了个小米5和防爆膜
            SaleOrder order1 = new SaleOrder { Id = 1, Customer = customer, CreatorDate = DateTime.Now, OrderItems = new List<OrderLine> { line1, line2 } };

            //又买了个保护套
            SaleOrder order2 = new SaleOrder { Id = 2, Customer = customer, CreatorDate = DateTime.Now, OrderItems = new List<OrderLine> { line3 } };

            //把保护套都退了
            ReturnOrder returnOrder = new ReturnOrder { Id = 3, Customer = customer, CreatorDate = DateTime.Now, OrderItems = new List<OrderLine> { line3 } };

            OrderCenter orderCenter = new OrderCenter { order1, order2, returnOrder };


            Picker picker = new Picker { Id = 110, Name = "捡货员110" };

            Distributor distributor = new Distributor { Id = 111, Name = "发货货员111" };

            //捡货员访问订单中心
            orderCenter.Accept(picker);

            //发货员访问订单中心
            orderCenter.Accept(distributor);

            Console.ReadLine();
        }
    }
}
