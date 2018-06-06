using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Players
    {

        //Backing fields
        public string Name;
        public int Wins;


        // Constrctor uno
        public Players(string name)
        {
            this.Name = name;
            this.Wins = 0;
        }

        // Constructor dos
        public Players(string name, int wins)
        {
            this.Name = name;
            this.Wins = wins;
        }

    }
}


//    }
//}
