using System;

namespace BridgePattern
{
    public class WebProject : Project
    {
        public WebProject(string projectName) : base(projectName)
        {
        }

        public override void AnalyzeRequirement()
        {
            Console.WriteLine($"[{base.ProjectName}]：进行需求分析");

        }

        public override void DesignProduct()
        {
            Console.WriteLine($"[{base.ProjectName}]：进行产品设计");
        }

        public override void MakePlan()
        {
            Console.WriteLine($"[{base.ProjectName}]：制定项目计划");
        }

        public override void ScheduleTask()
        {
            Console.WriteLine($"[{base.ProjectName}]：制作任务清单");
        }

        public override void ControlProcess()
        {
            Console.WriteLine($"[{base.ProjectName}]：把控项目进度");
        }

        public override void ReleaseProduct()
        {
            Console.WriteLine($"[{base.ProjectName}]：产品发布");
        }

        public override void MaintainProduct()
        {
            Console.WriteLine($"[{base.ProjectName}]：后期运维");
        }
    }
}