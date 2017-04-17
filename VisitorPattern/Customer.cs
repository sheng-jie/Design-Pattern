using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{

    /// <summary>
    /// 客户类
    /// </summary>
    public class Customer
    {
        public int Id { get; set; }

        public string NickName { get; set; }

        public string RealName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Zip { get; set; }
    }
}
