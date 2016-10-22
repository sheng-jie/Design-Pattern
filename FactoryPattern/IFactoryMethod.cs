namespace FactoryPattern
{
    /// <summary>
    /// 工厂方法模式：
    /// 工厂方法是针对每一种产品提供一个工厂类。通过不同的工厂实例来创建不同的产品实例。
    /// 在同一等级结构中，支持增加任意产品。
    /// 符合【开放封闭原则】，但随着产品类的增加，对应的工厂也会随之增多
    /// </summary>
    public interface IFactoryMethod
    {
        AbstractCar Create();
    }

    public class ConcreateFactoryA:IFactoryMethod
    {
        public AbstractCar Create()
        {
            return new ConcreateCarA();
        }
    }

    public class ConcreateFactoryB : IFactoryMethod
    {
        public AbstractCar Create()
        {
            return new ConcreateCarB();
        }
    }
}