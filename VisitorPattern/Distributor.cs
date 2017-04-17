using System;
using System.Linq;

namespace VisitorPattern
{
    /// <summary>
    /// 收发货员
    /// 对销售订单，进行发货处理
    /// 对退货订单，进行收货处理
    /// </summary>
    public class Distributor : Visitor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override void Visit(SaleOrder saleOrder)
        {
            Console.WriteLine($"开始为销售订单【{saleOrder.Id}】进行发货处理：", saleOrder.Id);

            Console.WriteLine($"一共打包{saleOrder.OrderItems.Sum(line => line.Qty)}件商品。");
            Console.WriteLine($"收货人：{saleOrder.Customer.RealName}");
            Console.WriteLine($"联系电话：{saleOrder.Customer.Phone}");
            Console.WriteLine($"收货地址：{saleOrder.Customer.Address}");
            Console.WriteLine($"邮政编码：{saleOrder.Customer.Zip}");

            Console.WriteLine($"订单【{saleOrder.Id}】发货完毕！" );
            Console.WriteLine("==========================");
        }

        public override void Visit(ReturnOrder returnOrder)
        {
            Console.WriteLine($"收到来自【{returnOrder.Customer.NickName}】的退货订单【{returnOrder.Id}】，进行退货收货处理：");

            foreach (var item in returnOrder.OrderItems)
            {
                Console.WriteLine($"【{item.Product.Name}】商品* {item.Qty}" );
            }

            Console.WriteLine($"退货订单【{returnOrder.Id}】收货处理完毕！" );
            Console.WriteLine("==========================");
        }
    }
}
