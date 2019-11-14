using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honor
{
    public class CheckHonor
    {
       
        public static bool Check (double GPA) {
            if (GPA > 3.5)
                return true;
            else
                return false;

        }

    }
}
