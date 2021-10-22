using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiapassonArray.BL
{
   public interface IRandomNumberService
    {
        int GetNewRandomFromDiapason(string s1,string s2);
    }
}
