using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// 状态接口类
    /// </summary>
    public interface ICarState
    {
        /// <summary>
        /// 启动
        /// </summary>
        void Drive(Car car);

        /// <summary>
        /// 停车
        /// </summary>
        void Stop(Car car);

        /// <summary>
        /// 加速
        /// </summary>
        /// <param name="car"></param>
        void SpeedUp(Car car);

        /// <summary>
        /// 减速
        /// </summary>
        /// <param name="car"></param>
        void SpeedDown(Car car);
    }
}