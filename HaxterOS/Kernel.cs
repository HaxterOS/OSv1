using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using HaxterOS.SystemFiles;
using HaxterOS.SystemFiles.Command;
namespace HaxterOS
{
    public class Kernel : Sys.Kernel
    {
        
        Desktop desktop = new Desktop();
        CommandProcessor cmd = new CommandProcessor();
        protected override void BeforeRun()
        {
            Console.WriteLine("HaxterOS booted successfully. Type 'help' for commands.");
           
        }

        protected override void Run()
        {           
            desktop.Logo();
            
            while (true)
            {
                Console.Write("> ");
                string Key = Console.ReadLine();
                if (cmd.commandChecker(Key))
                {
                    cmd.runCommand(Key);
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                }
            }
        }
    }
}
