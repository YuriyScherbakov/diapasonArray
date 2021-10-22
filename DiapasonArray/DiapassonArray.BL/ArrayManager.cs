using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiapassonArray.BL
{
    public class ArrayManager : IArrayManager
    {
        int[] numbers = new int[2];
        int len = 0;

        public string StringCurrentView { get ; set ; }

        public void SaveNewNumber(int newNumber)
        {          
            TryPutInArray(newNumber);
        }

        private bool TryPutInArray(int newNumber)
        {
            StringCurrentView = "";
            bool flag = false;
            

            for (int i = 0; i < len; i++)
            {
                if (numbers[i] == newNumber)
                {
                    flag = true;
                }
                if (i>0)
                {
                    StringCurrentView += ", ";
                }
                StringCurrentView += numbers[i].ToString();
                
            }
            if (flag == false)
            {
                ExtendArrayIfNeeded();
                numbers[len] = newNumber;
                
                if (len > 0)
                {
                    StringCurrentView += ", ";
                }
                StringCurrentView += newNumber.ToString();
                len++;
            }
            return !flag;
        }

        private void ExtendArrayIfNeeded()
        {
            if (numbers.Length == len)
            {
                int[] extendedNumbers = new int[len*2];
                for (int i = 0; i < numbers.Length; i++)
                {
                    extendedNumbers[i] = numbers[i];
                }
                numbers = extendedNumbers;
                GC.Collect(1);
            }
        }
    }
}
