using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Uno
{
    class Players
    {
        

        public string NewPlayerOne(string PlayerName, int Wins)
        {
            string pName = PlayerName;
            int pWins = Wins;
            using (StreamWriter sw = new StreamWriter("Players.txt"))
            {
                sw.WriteLine(pName, pWins);
            }

                return pName;
            
        }

        public string NewPlayerTwo(string PlayerName, int Wins)
        {
            

            string pName = PlayerName;
            int pWins = Wins;
            using (StreamWriter sw = new StreamWriter("Players.txt"))
            {
                sw.WriteLine(pName, pWins);
            }


            return pName;

        }

        public string NewPlayerThree(string PlayerName, int Wins)
        {
            string pName = PlayerName;
            int pWins = Wins;
            using (StreamWriter sw = new StreamWriter("Players.txt"))
            {
                sw.WriteLine(pName, pWins);
            }

            return pName;

        }

        public string NewPlayerFour(string PlayerName, int Wins)
        {
            string pName = PlayerName;
            int pWins = Wins;
            using (StreamWriter sw = new StreamWriter("Players.txt"))
            {
                sw.WriteLine(pName, pWins);
                
            }

            return pName;

        }

        
        
    }
}
