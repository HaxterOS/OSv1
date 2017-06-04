using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaxterOS.SystemFiles.Command.Commands
{
    public interface ICommand
    {
        string getCmdArgs();
        string getCmdArgs(int argNum);
        void exec(string args);
    }
}
