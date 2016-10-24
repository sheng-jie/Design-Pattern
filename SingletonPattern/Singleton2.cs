using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 单例模式实现方式二：
    /// 延迟初始化
    /// </summary>
    public class Singleton2
    {
        /// <summary>
        /// 定义为static，可以保证变量为线程安全的，即每个线程一个实例
        /// </summary>
        private static Singleton2 _instance;

        private Singleton2()
        {
            
        }

        public static Singleton2 Instance()
        {
            return _instance ?? (_instance = new Singleton2());
        }

        /// <summary>
        /// 使用此方法销毁已创建的实例
        /// </summary>
        public void Reset()
        {
            _instance = null;
        }

        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.",this.GetType().Name));
        }
    }
}
