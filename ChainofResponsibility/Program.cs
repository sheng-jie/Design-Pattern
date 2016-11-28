using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            PurchaseBill bill = new PurchaseBill()
            {
                BilNo = "CGDD001",
                MaterialName = "惠普电脑",
                Qty = 50,
                Price = 5000,
                BillMaker = new Purchaser("采购员--小责")
                //BillMaker = new Manager("经理--任经理")
                //BillMaker = new CEO("CEO--链总")
            };

            Console.WriteLine(string.Format("创建采购申请单：{0};申请购买{1}台{2}", bill.BilNo, bill.Qty, bill.MaterialName));

            bill.BillMaker.HandleBill(bill);

            Console.ReadLine();
        }
    }
}
