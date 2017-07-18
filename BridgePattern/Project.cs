namespace BridgePattern
{
    public abstract class Project
    {
        public string ProjectName { get; set; }

        protected Project(string projectName)
        {
            ProjectName = projectName;
        }

        /// <summary>
        /// 需求分析
        /// </summary>
        public abstract void AnalyzeRequirement();

        /// <summary>
        /// 产品设计
        /// </summary>
        public abstract void DesignProduct();

        /// <summary>
        /// 制定计划
        /// </summary>
        public abstract void MakePlan();

        /// <summary>
        /// 任务分解
        /// </summary>
        public abstract void ScheduleTask();

        /// <summary>
        /// 进度把控
        /// </summary>
        public abstract void ControlProcess();

        /// <summary>
        /// 产品发布
        /// </summary>
        public abstract void ReleaseProduct();

        /// <summary>
        /// 后期运维
        /// </summary>
        public abstract void MaintainProduct();

    }
}