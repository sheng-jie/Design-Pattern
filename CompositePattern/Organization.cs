using System;
using System.Collections.Generic;

namespace CompositePattern
{
    /// <summary>
    ///     组织架构
    /// </summary>
    public abstract class Organization
    {
        /// <summary>
        ///     成员姓名
        /// </summary>
        public string MemberName { get; set; }

        /// <summary>
        ///     成员职位
        /// </summary>
        public string MemberPosition { get; set; }

        /// <summary>
        ///     直接上级
        /// </summary>
        public Organization ParentNode { get; set; }

        public void Display()
        {
            var basicInfo = string.Format("姓名：{0},职位：{1}", MemberName, MemberPosition);
            var parentInfo = ParentNode == null
                ? ""
                : string.Format("，直接上级：『姓名：{0},职位：{1}』", ParentNode.MemberName, ParentNode.MemberPosition);
            Console.WriteLine(basicInfo + parentInfo);
        }
    }

    /// <summary>
    ///     部门
    /// </summary>
    public class Department : Organization
    {
        private readonly List<Organization> _organizationInfo = new List<Organization>();

        public Department(string departmentName, string charge)
        {
            MemberPosition = departmentName;
            MemberName = charge;
        }

        public void Add(Organization org)
        {
            _organizationInfo.Add(org);
            org.ParentNode = this;
        }

        public void Remove(Organization org)
        {
            _organizationInfo.Remove(org);
        }

        public List<Organization> GetDepartmentMembers()
        {
            return _organizationInfo;
        }
    }


    /// <summary>
    ///     员工
    /// </summary>
    public class Member : Organization
    {
    }
}