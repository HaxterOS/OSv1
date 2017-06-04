using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaxterOS.SystemFiles.Command.Commands
{
    class Tree : ICommand
    {
        string[] args = { "Hello", "I", "Am", "An", "Arg" };
        string CurrentArg = "";
        public string getCmdArgs()
        {
            string argsI = "ARGS: ";
            for (int x = 0; x < args.Length;x++)
            {
                argsI += args[x] + "; "; 
            }
            return argsI;
        }
        public string getCmdArgs(int ArgNum)
        {
            return args[ArgNum];
        }
        public void exec(string input)
        {
            CurrentArg = input.Trim().Split(' ')[1];
            Console.WriteLine(CurrentArg);
        }
    }
}
