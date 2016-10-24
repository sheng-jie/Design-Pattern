using System;

namespace FactoryPattern
{
    public abstract class AbstractBus
    {
        protected abstract void DoOperation();

        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.",this.GetType().Name));
        }
    }

    public class ConcreateBusA : AbstractBus
    {

        protected override void DoOperation()
        {

            throw new System.NotImplementedException();
        }
    }

    public class ConcreateBusB : AbstractBus
    {
        protected override void DoOperation()
        {
            throw new System.NotImplementedException();
        }
    }
}