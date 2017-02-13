using System;
using System.Collections.Generic;

namespace ObserverPattern.SimpleImplement
{
    /// <summary>
    ///     钓鱼工具抽象类
    ///     用来维护订阅者列表，并通知订阅者
    /// </summary>
    public abstract class FishingTool
    {
        private readonly List<ISubscriber> _subscribers;

        protected FishingTool()
        {
            _subscribers = new List<ISubscriber>();
        }

        public void AddSubscriber(ISubscriber subscriber)
        {
            if (!_subscribers.Contains(subscriber))
                _subscribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            if (_subscribers.Contains(subscriber))
                _subscribers.Remove(subscriber);
        }

        public void Notify(FishType type)
        {
            foreach (var subscriber in _subscribers)
                subscriber.Update(type);
        }
    }

    /// <summary>
    ///     鱼竿
    /// </summary>
    public class FishingRod : FishingTool
    {
        public void Fishing()
        {
            Console.WriteLine("开始下钩！");

            //用随机数模拟鱼咬钩，若随机数为偶数，则为鱼咬钩
            if (new Random().Next() % 2 == 0)
            {
                var type = (FishType) new Random().Next(0, 5);
                Console.WriteLine("铃铛：叮叮叮，鱼儿咬钩了");
                Notify(type);
            }
        }
    }

    /// <summary>
    ///     订阅者（观察者）接口
    ///     由具体的订阅者实现Update()方法
    /// </summary>
    public interface ISubscriber
    {
        void Update(FishType type);
    }

    /// <summary>
    ///     垂钓者实现观察者接口
    /// </summary>
    public class FishingMan : ISubscriber
    {
        public FishingMan(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int FishCount { get; set; }

        public void Update(FishType type)
        {
            FishCount++;
            Console.WriteLine("{0}：钓到一条[{2}]，已经钓到{1}条鱼了！", Name, FishCount, type);
        }
    }
}