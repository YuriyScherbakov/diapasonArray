using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiapasonArray
{
   public class EventArguments : EventArgs
    {
        public EventArguments(string str)
        {
            this.str = str;   
        }
        readonly string str;
        public string Str { get {
                return this.str;
            } }
    }
}
