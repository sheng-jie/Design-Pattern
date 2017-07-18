using System;

namespace BridgePattern
{
    /// <summary>
    /// 项目经理
    /// </summary>
    public class ProjectManager : Manager
    {
        public ProjectManager(Project currentProject) : base(currentProject)
        {
        }

        public override void SchedulePlan()
        {
            base.CurrentProject.MakePlan();
        }

        public override void AssignTasks()
        {
            base.CurrentProject.ScheduleTask();
        }

        public override void ControlProcess()
        {
            base.CurrentProject.ControlProcess();
        }

        public override void ManageProject()
        {
            Console.WriteLine($"项目经理负责【{base.CurrentProject.ProjectName}】：");
            base.ManageProject();
        }
    }
}