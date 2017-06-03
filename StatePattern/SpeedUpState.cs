using System;

namespace StatePattern
{
    /// <summary>
    /// 加速状态
    /// </summary>
    public class SpeedUpState : ICarState
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
            Console.WriteLine("车辆正在加速行驶！");
        }

        public void SpeedDown(Car car)
        {
            Console.WriteLine("路况一般，减速行驶！");
            car.CurrentCarState = Car.SpeedDownState;
        }
    }
}