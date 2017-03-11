using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// 备忘录
    /// </summary>
    public class ContactMemento
    {
        private readonly List<ContactPerson> _backupContactPersons;

        public List<ContactPerson> GetMemento()
        {
            return _backupContactPersons;
        }

        public ContactMemento(List<ContactPerson> backupContactPersons)
        {
            _backupContactPersons = backupContactPersons;
        }
    }
}
