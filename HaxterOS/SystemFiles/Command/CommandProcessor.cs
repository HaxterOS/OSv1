using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaxterOS.SystemFiles.Command.Commands;

namespace HaxterOS.SystemFiles.Command
{
    class CommandProcessor
    {
        private string[] cmds = {"help","about","gui","meme"};


        public CommandProcessor()
        {}



        public bool commandChecker(string cmd)
        {
            for (int x = 0;x<=cmds.Length; x++)
            {
                if(cmds[x] == cmd)
                {
                    return true;
                }
            }
            return false;
        }
        private TextCommands txtCmd = new TextCommands();
        public void runCommand(string cmd)
        {
            
            switch (cmd)
            {
                case "help":
                    {
                        for (int x=0;x<cmds.Length;x++)
                        {
                            Console.WriteLine(cmds[x]);
                        }
                        break;
                    }
                case "about":
                    {
                        txtCmd.about();
                        break;
                    }
                case "gui":
                    {
                        break;
                    }
                case "meme":
                    {
                        Console.WriteLine(txtCmd.meme());   
                        break;
                    }
            }
        }
    }
}
