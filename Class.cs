using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace حقوق_خالص
{
    class Class
    {
        public string name;
        public string last;
        public string number;
        public int payment;
        int maliat;

        public int Income(int a)
        {
            
            int bime = a * 7 / 100;
            if (a > 6500)
                maliat = a / 10;
            else
                maliat = 0;

            return a - (bime + maliat);
            
        }


    }
}
