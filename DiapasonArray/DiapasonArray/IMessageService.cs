﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiapasonArray
{
  public  interface IMessageService
    {
       void ShowMessage(string message);
        void ShowError(string error);
    }
}
