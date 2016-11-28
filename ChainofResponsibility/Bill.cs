using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /// <summary>
    /// 单据状态枚举
    /// </summary>
    public enum BillStatus
    {
        Open,
        Saved,
        Submitted,
        Audited
    }

    public abstract class Bill
    {
        public string BillName { get; set; }

        public string BilNo { get; set; }

        public BillStatus Status { get; set; }

        public string MaterialName { get; set; }

        public int Qty { get; set; }

        public decimal Price { get; set; }

        public decimal Amount
        {
            get
            {
                return Qty * Price;
            }
        }

        /// <summary>
        /// 做单员
        /// </summary>
        public BillHandler BillMaker { get; set; }
    }

    public class PurchaseBill : Bill
    {
        public PurchaseBill()
        {
            base.Status = BillStatus.Open;
            base.BillName = "采购申请单";
        }
    }

   

}
