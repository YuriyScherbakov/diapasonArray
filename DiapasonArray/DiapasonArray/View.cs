using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiapasonArray
{
   public class View : IView
    {
        IMessageService messageService;
        ICommunicationService communicationService;
        public event EventHandling<EventArguments> StringEntered;
        public View(IMessageService messageService,ICommunicationService communicationService)
        {
            this.communicationService = communicationService;
            this.messageService = messageService;
        }
       public string Str { get; set; }
       
        
        public void AskForString()
        {
            if (StringEntered!=null)
            {               
                StringEntered(new EventArguments(this.communicationService.GetString()));
            }           
        }
        public void Print(string str)
        {
            messageService.ShowMessage(str);
        }
    }
}
