using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class GamePoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        public GamePoint(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public GamePoint()
        {
        }
    }
}
