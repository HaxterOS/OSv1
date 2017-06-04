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
        private string[] cmds = {"help","about","gui","meme","tree"};
        List<String> x = new List<string>();

        public CommandProcessor()
        {}

        public bool commandChecker(string cmd)
        {
            for (int x = 0;x<=cmds.Length; x++)
            {
                if(cmd.IndexOf(cmds[x]) != 0)
                {
                    return true;
                }
            }
            return false;
        }
        private TextCommands txtCmd = new TextCommands();
        public void runCommand(string cmd)
        {
            
            switch (cmd.Trim().Split(' ')[0])
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
                        Console.WriteLine("GUI is not functional and has been removed until fixed");
                        break;
                    }
                case "meme":
                    {
                        Console.WriteLine(txtCmd.meme());   
                        break;
                    }
                case "tree":
                    {
                        Console.WriteLine(txtCmd.Ftree(cmd));

                        break;
                    }
            }
        }
    }
}
