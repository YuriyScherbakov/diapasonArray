using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiapassonArray.BL
{
   public class RandomNumberService : IRandomNumberService
    {
        int fn;
        int sn;

        int randomNumber;
        public int GetNewRandomFromDiapason(string s1, string s2)
        {
            try
            {
                fn = Convert.ToInt32(s1);
                sn = Convert.ToInt32(s2);
            }
            catch (Exception)
            {

                throw;
            }
            SwapIfNeeded();
            Random random = new Random();
            randomNumber = random.Next(fn, sn);
            return randomNumber;
        }

        private void SwapIfNeeded()
        {
            if (fn > sn)
            {
                int buffer = sn;
                sn = fn;
                fn = buffer;

            }
        }
    }
}
