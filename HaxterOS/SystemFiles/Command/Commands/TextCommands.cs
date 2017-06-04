using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaxterOS.SystemFiles.Command.Commands
{
    class TextCommands
    {
        public void about()
        {
            Console.WriteLine(@"
Credits:
   - Dev team:
    - Lead: Mat2567
    - Gfx: 
      - No one :(
    - Coding: 
      - Mat2567
   - Marketing:
    - No one :( 
   - Concept:
    - No one :(               
                ");
        }
        public string meme()
        {
            Memes m = new Memes();
            return m.getMeme();
        }
        public string Ftree(int num )
        {
            Tree tree = new Tree();
            return tree.getCmdArgs(num);
        }
        public string Ftree(string input)
        {
            Tree tree = new Tree();
            tree.exec(input);
            return "Tree executed";
        }
        public TextCommands()
        {

        }


    }
}
