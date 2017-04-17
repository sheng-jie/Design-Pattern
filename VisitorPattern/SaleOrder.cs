namespace VisitorPattern
{
    /// <summary>
    /// 销售订单
    /// </summary>
    public class SaleOrder : Order
    {
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
