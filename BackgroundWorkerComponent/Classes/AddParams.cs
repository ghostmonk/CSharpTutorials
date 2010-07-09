using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackgroundWorkerComponent.Classes
{
    class AddParams
    {
        public AddParams( int numb1, int numb2)
        {
            Numb1 = numb1;
            Numb2 = numb2;
        }

        public int Numb1
        {
            get; set;
        }

        public int Numb2
        {
            get; set;
        }
    }
}
