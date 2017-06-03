using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaxterOS.SystemFiles.Command.Commands
{
    class Memes
    {
        private string[] memeList = {"Dat boi","One does not simply", "It takes a boss to"};
        private string[] memeDesc = {"like trains", "go to norway", "be a boss",};
        public Memes()
        {
            
        }
        public string getMeme()
        {
            Random rand = new Random();
            int x = rand.Next(0, memeList.Length);
            return memeList[x] + " " +memeDesc[rand.Next(0,memeDesc.Length)];
        }
    }
}
