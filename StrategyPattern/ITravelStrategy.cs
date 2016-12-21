using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 旅行策略类
    /// </summary>
    public abstract class TravelStrategy
    {
        /// <summary>
        /// 目的地
        /// </summary>
        public string PlanName { get; set; }

        /// <summary>
        /// 预算
        /// </summary>
        public int Budget { get; set; }
        /// <summary>
        /// 旅游计划
        /// </summary>
        public abstract void TravelPlan();
    }

    public class GuangxiTravel : TravelStrategy
    {
        public GuangxiTravel()
        {
            this.PlanName = "广西桂林山水甲天下，心向往之！";
        }
        public override void TravelPlan()
        {
            Console.WriteLine("广西旅游计划：");
            Console.WriteLine(string.Format("计划名称：{0}预算：{1}", this.PlanName, this.Budget));
            if (this.Budget >= 4000)
            {
                Console.WriteLine("选择高铁出行！");
            }
            else
            {
                Console.WriteLine("选择大巴出行！");
            }
        }
    }

    public class BackupTravel : TravelStrategy
    {
        public BackupTravel()
        {
            this.PlanName = "逛街看电影包饺子！";
        }
        public override void TravelPlan()
        {
            Console.WriteLine("备用计划：");
            Console.WriteLine(string.Format("计划名称：{0}", this.PlanName));
        }
    }
}
