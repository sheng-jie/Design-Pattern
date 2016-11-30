using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 通过继承泛型单例来获取实例
    /// </summary>
    public class Singleton4
    {
        /// <summary>
        /// 非公共无参构造函数，确保该类无法在其他地方实例化
        /// </summary>
        private Singleton4()
        {

        } 

        /// <summary>
        /// 也可以通过暴露属性获取实例
        /// </summary>
        public static Singleton4 Instance
        {
            get
            {
                return GenericSingleton<Singleton4>.GetInstance();
            }
        }

        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.", this.GetType().Name));
        }

    }
   
}
