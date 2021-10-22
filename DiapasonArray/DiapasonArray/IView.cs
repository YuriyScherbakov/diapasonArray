using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiapasonArray
{
    interface IView
    {
        string Str { get; set; }
       
        void Print(string str);
        void AskForString();
        event EventHandling<EventArguments> StringEntered;

    }
}
