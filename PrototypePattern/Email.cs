using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Email : ICloneable
    {
        public string Receiver { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Name { get; set; }

        public string Content { get; set; }

        public string Footer { get; set; }


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
