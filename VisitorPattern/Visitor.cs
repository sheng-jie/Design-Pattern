namespace VisitorPattern
{
    /// <summary>
    /// 访问者
    /// </summary>
    public abstract class Visitor
    {
        public abstract void Visit(SaleOrder saleOrder);
        public abstract void Visit(ReturnOrder returnOrder);
    }
}
