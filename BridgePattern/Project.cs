using System;

namespace BridgePattern
{
    public abstract class Project
    {
        public string ProjectName { get; set; }

        protected Project(string projectName)
        {
            ProjectName = projectName;
        }

        public abstract void MakePlan();

        public abstract void ScheduleTask();

        public abstract void ControlProcess();

    }

    public class WebProject : Project
    {
        public WebProject(string projectName) : base(projectName)
        {
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
    }
}