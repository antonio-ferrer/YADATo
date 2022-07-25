using System;
using System.Collections.Generic;
using System.Text;

namespace YADATo.DAO.Interfaces
{
    public interface ICMParameter
    {
        string Name { get; set; }    
        object Value { get; set; }

        bool? IsOut { get; set; }
        
    }
}
