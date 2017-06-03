using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// 汽车
    /// </summary>
    public class Car
    {
        public string Name { get; set; }

        public Car()
        {
            this.CurrentCarState = StopState;//初始状态为停车状态
        }

        internal static ICarState StopState = new StopState();
        internal static ICarState RunState = new RuningState();
        internal static ICarState SpeedDownState = new SpeedDownState();
        internal static ICarState SpeedUpState = new SpeedUpState();

        public ICarState CurrentCarState { get; set; }

        public void Run()
        {
            this.CurrentCarState.Drive(this);
        }

        public void Stop()
        {
            this.CurrentCarState.Stop(this);
        }

        public void SpeedUp()
        {
            this.CurrentCarState.SpeedUp(this);
        }
        public void SpeedDown()
        {
            this.CurrentCarState.SpeedDown(this);
        }
    }
}
