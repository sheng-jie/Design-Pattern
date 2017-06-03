using System;

namespace StatePattern
{
    /// <summary>
    /// 减速状态
    /// </summary>
    public class SpeedDownState : ICarState
    {
        public void Drive(Car car)
        {
            Console.WriteLine("车辆正在自动驾驶！");
        }

        public void Stop(Car car)
        {
            Console.WriteLine("车辆已停止！");
            car.CurrentCarState = Car.StopState;
        }

        public void SpeedUp(Car car)
        {
            Console.WriteLine("路况良好，加速行驶！");
            car.CurrentCarState = Car.SpeedUpState;
        }

        public void SpeedDown(Car car)
        {
            Console.WriteLine("车辆正在减速行驶！");
        }
    }
}