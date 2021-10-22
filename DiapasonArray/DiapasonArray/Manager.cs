using DiapassonArray.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiapasonArray
{
    class Manager
    {
        private readonly IArrayManager arrayManager;
        private readonly IRandomNumberService randomNumberService;
        private readonly IView view;

        string[] strArr;
        bool enterIsCorrect = false;
        public Manager(IArrayManager arrayManager, IRandomNumberService randomNumberService, IView view)
        {
            this.arrayManager = arrayManager;
            this.randomNumberService = randomNumberService;
            this.view = view;
           

            this.strArr = new string[2];

            this.view.StringEntered += View_StringEntered;
        }

        private void View_StringEntered(EventArguments eventArgs)
        {
            if (String.IsNullOrEmpty(strArr[0]))
            {
                strArr[0] = eventArgs.Str;
                try
                {
                    Convert.ToInt32(strArr[0]);
                    enterIsCorrect = true;
                }
                catch (Exception)
                {
                    enterIsCorrect = false;
                    strArr[0] = null;
                }
                return;
            }
            if (String.IsNullOrEmpty(strArr[1]))
            {
                strArr[1] = eventArgs.Str;
                try
                {
                    Convert.ToInt32(strArr[1]);
                    enterIsCorrect = true;
                }
                catch (Exception)
                {
                    enterIsCorrect = false;
                    strArr[1] = null;

                }
                return;
            }

        }


        public void DoWork() 
        {
            while (true) {

                while (!enterIsCorrect)
                {
                    view.Print("Введите число начала диапазона");
                    view.AskForString();
                    if (!enterIsCorrect)
                    {
                        view.Print("Вы ввели некорректный символ");
                    }
                }
                enterIsCorrect = false;
                while (!enterIsCorrect)
                {
                    view.Print("Введите число конца диапазона");
                    view.AskForString();
                    if (!enterIsCorrect)
                    {
                        view.Print("Вы ввели некорректный символ");
                    }
                }
              
                    arrayManager.SaveNewNumber(
                        randomNumberService.GetNewRandomFromDiapason(strArr[0], strArr[1]));

             
               
                view.Print(arrayManager.StringCurrentView);
                this.strArr = new string[2];
                enterIsCorrect = false;
            }


        }

       
    }
}
