using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiapasonArray
{
   public class ConsoleMessageService : IMessageService
    {
        public void ShowError(string error)
        {
            Console.WriteLine(error);
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
