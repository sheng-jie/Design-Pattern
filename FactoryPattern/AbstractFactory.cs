using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// 抽象工厂模式：
    /// 抽象工厂是应对产品族概念的，比如说，每个汽车公司可能要同时生产轿车，货车，客车，那么每一个工厂都要有创建轿车，货车和客车的方法。
    /// 应对产品族概念而生，增加新的产品线很容易，但是无法增加新的产品。
    /// </summary>
    public interface IAbstractFactory
    {
        AbstractCar CreateCar();
        AbstractBus CreateBus();
    }

    /// <summary>
    /// 宝马工厂
    /// </summary>
    public class BMWFactory:IAbstractFactory
    {
        public AbstractCar CreateCar()
        {
            return new ConcreateCarA();
        }

        public AbstractBus CreateBus()
        {
            return new ConcreateBusA();
        }
    }

    /// <summary>
    /// 比亚迪工厂
    /// </summary>
    public class BYDFactory : IAbstractFactory
    {
        public AbstractCar CreateCar()
        {
            return new ConcreateCarB();
        }

        public AbstractBus CreateBus()
        {
            return new ConcreateBusB();
        }
    }
}
