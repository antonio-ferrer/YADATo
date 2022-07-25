using System;
using System.Collections.Generic;
using System.Text;
using YADATo.DAO.Interfaces;

namespace YADATo.DAO.Implementations
{
    public class CMParameter : ICMParameter
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public bool? IsOut { get; set; }
    }
}
