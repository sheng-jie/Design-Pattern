using System.Collections.Generic;

namespace MementoPattern
{
    /// <summary>
    /// 备忘录管理
    /// </summary>
    public class Caretaker
    {
        // 存储多个备份
        public Dictionary<string, ContactMemento> ContactMementoes { get; set; }
        public Caretaker()
        {
            ContactMementoes = new Dictionary<string, ContactMemento>();
        }
    }
}