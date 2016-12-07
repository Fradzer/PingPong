using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    class Platform
    {
        public static int Height = 50;
        public static int Width = 10;

        public Rectangle Figure { get; set; }

        public Platform(int x, int y)
        {
            Figure = new Rectangle(x, y, Width, Height);
        }
    }
}
