﻿using DiapassonArray.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiapasonArray
{
    class Program
    {    

        static void Main(string[] args)
        {
          
            Manager manager = new Manager(new ArrayManager(),new RandomNumberService(),
                new View(new ConsoleMessageService(), new ConsoleCommunicator()));

            manager.DoWork();
    }


}
}
