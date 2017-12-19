using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassLibrary
{
    public class Cell
    {
        public ColorCell GetColor { get; set; }
        public enum ColorCell
        {
            Blue,
            Green,
            Orange,
            Pink,
            Red,
            White
        }
    //Dictionary<int, Color> NumColor = new Dictionary<int, Color>();
        
        
      /*  public Cell()
        {
            NumColor.Add(0, Color.Blue);
            NumColor.Add(1, Color.Green);
            NumColor.Add(2, Color.Orange);
            NumColor.Add(3, Color.Pink);
            NumColor.Add(4, Color.Red);
            NumColor.Add(5, Color.White);

        }*/
        public void ChangeColotInt(int n)
        {
            this.GetColor = (ColorCell) n;
        }
    }
}
