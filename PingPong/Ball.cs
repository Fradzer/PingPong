using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    static class Ball
    {
        public const int Size = 10;

        public static int SpeedX = 10;

        public static int SpeedY = 10;

        public static int CoordX { get; set; }
        public static int CoordY { get; set; }
       
        public static void MoveByX()
        {
            CoordX += SpeedX;
        }

        public static void MoveByY()
        {
            CoordY += SpeedY;
        }

        public static void SetParams(int speedX, int speedY, int coordX, int coordY)
        {
            SpeedX = speedX;
            SpeedY = speedY;
            CoordX = coordX;
            CoordY = coordY; 
        }
    }
}
