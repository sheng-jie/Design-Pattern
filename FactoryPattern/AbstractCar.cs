using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public abstract class AbstractCar
    {
        protected abstract void DoOperation();

        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.",this.GetType().Name));
        }
    }

    public class ConcreateCarA : AbstractCar
    {

        protected override void DoOperation()
        {
            
            throw new System.NotImplementedException();
        }
    }

    public class ConcreateCarB : AbstractCar
    {
        protected override void DoOperation()
        {
            throw new System.NotImplementedException();
        }
    }
}
