using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Players
    {


        //backing fields
        string pName;
        int pWins;

        public static Players player1
            ;

        public Players(string Name)
        {
            pName = Name;
            pWins = 0;

        }

        public Players(string Name, int Wins)
        {
            pName = Name;
            pWins = Wins;
        }


        public string Name
        {
            get
            {
                return pName;
            }
            set
            {
                pName = value;
            }
        }
        
        public static Players GetPlayers1()
        {
            return player1;
        }
         
        
        
          
        
    }
}
