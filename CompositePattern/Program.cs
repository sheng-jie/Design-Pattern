using System;

namespace CompositePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("组合模式：");
            Console.WriteLine("-------------------");

            var organzation = new Department("CEO", "老总");
            var developDepart = new Department("研发部经理", "研哥");

            organzation.Add(developDepart);

            var projectA = new Department("Erp项目组长", "E哥");

            developDepart.Add(projectA);

            var memberX = new Member {MemberPosition = "开发工程师", MemberName = "开发X"};
            var memberY = new Member {MemberPosition = "开发工程师", MemberName = "开发Y"};
            var memberZ = new Member {MemberPosition = "测试工程师", MemberName = "测试Z"};

            projectA.Add(memberX);
            projectA.Add(memberY);
            projectA.Add(memberZ);

            Console.WriteLine("组合模式：从上往下遍历");
            DisplayStructure(organzation);
            Console.WriteLine("-------------------");
            Console.WriteLine();

            Console.WriteLine("组合模式：从下往上遍历");
            FindParent(memberX);
            Console.WriteLine("-------------------");
            Console.ReadLine();
        }

        /// <summary>
        ///     正序排序
        /// </summary>
        /// <param name="org"></param>
        private static void DisplayStructure(Organization org)
        {
            if (org.ParentNode == null)
                org.Display();

            var departMent = (Department) org;

            foreach (var depart in departMent.GetDepartmentMembers())
            {
                depart.Display();
                if (!(depart is Member))
                    DisplayStructure((Department) depart);
            }
        }

        /// <summary>
        ///     倒序排序
        /// </summary>
        /// <param name="member"></param>
        private static void FindParent(Organization member)
        {
            member.Display();
            while (member.ParentNode != null)
            {
                member.ParentNode.Display();
                member = member.ParentNode;
            }
        }
    }
}