using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Players
    {

        public string Name;
        public int Wins;

        public Players(string name)
        {
            this.Name = name;
        }

        public Players(string name, int wins)
        {
            this.Name = name;
            this.Wins = wins;
        }

    }
}

//        //backing fields
//        string pName;
//        int pWins;

               
        
//        public Players(string Name)
//        {
//            pName = Name;
//            pWins = 0;

//        }

//        public Players(string Name, int Wins)
//        {
//            pName = Name;
//            pWins = Wins;
//        }


//        public string Name
//        {
//            get
//            {
//                return pName;
//            }
//            set
//            {
//                pName = value;
//            }

//        }



        


//    }
//}
