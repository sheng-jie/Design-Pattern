namespace VisitorPattern
{
    /// <summary>
    /// 产品类
    /// </summary>
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual decimal Price { get; set; }
    }
}
