using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Project webProject = new WebProject("Web项目");
            Manager manager = new ProjectManager(webProject);

            manager.ManageProject();

            Console.ReadLine();
        }
    }
}
