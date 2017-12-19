using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using System.Drawing;

namespace ClassLibrary
{
    public class PlateAndDGV
    {
        public static Color ConvertColorCellToColor (Cell.ColorCell color)
        {
            if (color == Cell.ColorCell.Blue)
            {
                return Color.Blue;
            }
            if (color == Cell.ColorCell.Green)
            {
                return Color.Green;
            }
            if (color == Cell.ColorCell.Orange)
            {
                return Color.Orange;
            }
            if (color == Cell.ColorCell.Pink)
            {
                return Color.Pink;
            }
            if (color == Cell.ColorCell.Red)
            {
                return Color.Red;
            }
            return Color.White;    
        }
        
        public static Point ConvertGamePointToPoint (GamePoint point)
        {
            return new Point(point.X, point.Y);
        }
        public static GamePoint ConvertPointToGamePoint(Point point)
        {
            return new GamePoint(point.X, point.Y);
        }
        public static Cell.ColorCell ConvertColorToColorCell(Color color)
        {
            if (color == Color.Blue)
            {
                return Cell.ColorCell.Blue;
            }
            if (color == Color.Green)
            {
                return Cell.ColorCell.Green;
            }
            if (color == Color.Orange)
            {
                return Cell.ColorCell.Orange;
            }
            if (color == Color.Pink)
            {
                return Cell.ColorCell.Pink;
            }
            if (color == Color.Red)
            {
                return Cell.ColorCell.Red;
            }
            return Cell.ColorCell.White;
        }
        public static DataGridView ConvertPlateToDGV(DataGridView dataGridView, Game Place)
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    dataGridView[i, j].Style.BackColor = ConvertColorCellToColor(Place.Place[i, j].GetColor); 
                }
            }
            return dataGridView;
        }

    }
}
