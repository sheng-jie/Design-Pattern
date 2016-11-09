using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("直接访问Google：");
            Google google = new Google();
            try
            {
                google.Search("特朗普");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("使用代理访问Google：");
            ISearchEngine searchEngine = new GoogleProxy();
            searchEngine.Search("特朗普");

            Console.ReadLine();
        }
    }
}
