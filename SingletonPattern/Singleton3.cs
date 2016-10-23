using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 单例模式实现方式三：
    /// 锁机制，确保多线程只产生一个实例
    /// </summary>
    public class Singleton3
    {
        private static Singleton3 _instance;

        private static readonly object Locker =new object();

        private Singleton3() { }

        public static Singleton3 Instance()
        {
            if (_instance==null)
            {
                lock (Locker)
                {
                    if (_instance==null)
                    {
                        _instance = new Singleton3();
                    }
                }
            }

            return _instance;
        }

        public void GetInfo()
        {
            Console.WriteLine($"I am {this.GetType().Name}.");
        }
    }
}
