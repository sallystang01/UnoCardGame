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

        public Players Parse(string str)
        {
            var player = new Players();
            player.Name = str;

            return player;
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
