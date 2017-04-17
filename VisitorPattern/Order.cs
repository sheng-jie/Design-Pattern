using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    /// <summary>
    /// 订单抽象类
    /// </summary>
    public abstract class Order
    {
        public int Id { get; set; }

        public Customer Customer { get; set; }

        public DateTime CreatorDate { get; set; }

        /// <summary>
        /// 单据品相
        /// </summary>
        public List<OrderLine> OrderItems { get; set; }

        public abstract void Accept(Visitor visitor);

    }
}
