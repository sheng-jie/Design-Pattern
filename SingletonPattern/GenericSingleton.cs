using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 泛型单例模式的实现
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericSingleton<T> where T : class//,new ()
    {
        private static T instance;

        private static readonly object Locker = new object();

        public static T GetInstance()
        {
            //没有第一重 instance == null 的话，每一次有线程进入 GetInstance()时，均会执行锁定操作来实现线程同步，
            //非常耗费性能 增加第一重instance ==null 成立时的情况下执行一次锁定以实现线程同步
            if (instance == null)
            {
                //Double-Check Locking 双重检查锁定
                lock (Locker)
                {
                    if (instance == null)
                    {
                        //instance = new T();
                        //需要非公共的无参构造函数，不能使用new T() ,new不支持非公共的无参构造函数 
                        instance = Activator.CreateInstance(typeof(T), true) as T;//第二个参数防止异常：“没有为该对象定义无参数的构造函数。”
                    }
                }
            }
            return instance;
        }

        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.", this.GetType().Name));
        }
    }
}
