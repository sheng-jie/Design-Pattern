using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 单例模式实现方式一：
    /// 静态变量初始化
    /// </summary>
    public class Singleton1
    {
        /// <summary>
        /// 定义为static，可以保证变量为线程安全的，即每个线程一个实例
        /// </summary>
        private static Singleton1 instance = new Singleton1();

        private Singleton1()
        {
            
        }

        public static Singleton1 Instance()
        {
            return instance;
        }

        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.",this.GetType().Name));
        }
    }
}
