using System;

namespace BridgePattern
{
    public abstract class Manager
    {
        protected Project CurrentProject { get; }

        protected Manager(Project currentProject)
        {
            CurrentProject = currentProject;
        }

        public virtual void ManageProject()
        {
            CurrentProject.MakePlan();
            CurrentProject.ScheduleTask();
            CurrentProject.ControlProcess();
        }
    }


    public class ProjectManager : Manager
    {
        public ProjectManager(Project currentProject) : base(currentProject)
        {
        }

        public override void ManageProject()
        {
            Console.WriteLine($"负责[{base.CurrentProject.ProjectName}]开发：");
            base.ManageProject();
            Console.WriteLine($"[{base.CurrentProject.ProjectName}] 开发完成。");
        }
    }
}