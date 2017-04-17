namespace VisitorPattern
{
    /// <summary>
    /// 退货单
    /// </summary>
    public class ReturnOrder : Order
    {
        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
