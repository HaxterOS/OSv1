using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using HaxterOS.SystemFiles;
using HaxterOS.SystemFiles.Command;
using Cosmos.System.FileSystem.VFS;
using HaxterOS.Drivers;
namespace HaxterOS
{
    public class Kernel : Sys.Kernel
    {


        #region Variables

        Sys.FileSystem.CosmosVFS fs;
        //Declare all the drivers (load 'em like linux)
        bool isConsole = true; bool firstTImeUser = true;
        MouseDriver m; 
        int usergroup = 1; bool isLoggedIn = false; string user = "", ps = ""; //IDK if storing pswd in ram is ok?

        public static string cd = @"0:\";
        //private List<string> commandHistory = new List<string>();
        static string s1 = "                  HaxterOS created by mat2567, using COSMOS";
        static string s2 = "          Currently under development. Not responsible for any damages";
        static string s3 = "                            Proceed at your own risk";
        static string s4 = "            Welcome to HaxterOS. Type help for a list of commands";

        #endregion

        Desktop desktop = new Desktop();
        CommandProcessor cmd = new CommandProcessor();
        protected override void BeforeRun()
        {
            //Init the filesystem
            fs = new Sys.FileSystem.CosmosVFS();
            VFSManager.RegisterVFS(fs);
            fs.Initialize();
            //Power.enableACPI();
            //Display welcome message
            Cosmos.System.Kernel.PrintDebug("Kernel loaded sucessfully!");
            Console.WriteLine("Loading complete...");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(s1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(s4 + "\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        protected override void Run()
        {
            //desktop.Logo();
            Console.WriteLine("Press any key to begin OS");
            Console.ReadKey();
            Console.Clear();
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
        public static void clear()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(s1);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s4);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
