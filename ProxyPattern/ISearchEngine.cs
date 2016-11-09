using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public interface ISearchEngine
    {
        void Search(string searchStr);
    }

    public class Google : ISearchEngine
    {
        public void Search(string searchStr)
        {
            string url = "https://www.google.com/search?q=";
            var request = (HttpWebRequest)WebRequest.Create(url + searchStr);

            var response = (HttpWebResponse)request.GetResponse();

            if (response != null)
            {
                Console.WriteLine(string.Format("搜索【{0}】并成功返回！", searchStr));
            }
        }
    }

    public class GoogleProxy : ISearchEngine
    {
        private readonly ISearchEngine _vpn = null;

        public GoogleProxy()
        {
            _vpn = new Google();
        }

        public void Search(string searchStr)
        {
            try
            {
                _vpn.Search(searchStr);
            }
            catch (Exception)
            {
                string url = "https://www.baidu.com/search?q=";
                var request = (HttpWebRequest)WebRequest.Create(url + searchStr);

                try
                {
                    var response = (HttpWebResponse)request.GetResponse();

                    if (response != null)
                    {
                        Console.WriteLine(string.Format("搜索【{0}】并成功返回！", searchStr));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
