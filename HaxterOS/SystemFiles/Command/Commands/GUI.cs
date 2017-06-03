using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys =  Cosmos.System;
using Cosmos.System.Graphics;
namespace HaxterOS.SystemFiles.Command.Commands
{
    class GUI
    {

        Canvas canvas;


        public GUI()
        {
            Mode mo = new Mode(800, 600,ColorDepth.ColorDepth32);
            canvas = FullScreenCanvas.GetFullScreenCanvas(mo);
            canvas.Clear(Sys.Graphics.Color.Blue);
            Next();
        }

        public void Init()
        {
            //Init the GUI
        }
        public void Next()
        {
            //Refresh the GUI. Run all commands
            Sys.Graphics.Pen RED = new Sys.Graphics.Pen(Sys.Graphics.Color.Red);
            Sys.Graphics.Pen GREEN = new Sys.Graphics.Pen(Sys.Graphics.Color.Green);
            canvas.DrawFilledRectangle(RED, 0, 0, 30, 600);
            canvas.DrawFilledRectangle(GREEN, 0, 0, 30, 30);
            System.Drawing.Brush br = System.Drawing.Brushes.Green;
            
            System.Drawing.Font font = new System.Drawing.Font("Ariel", 12f);
            canvas.DrawString("Text here",font,br,0,0);
        }
    }
}
