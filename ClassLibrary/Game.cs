using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace ClassLibrary
{
    public class Game
    {
        public int Score { get; set; }
        public Cell[,] Place = new Cell[16, 16];

        public Game()
        {
            Score = 0;
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Cell NewCell = new Cell();
                    Place[i, j] = NewCell;
                    Place[i, j].ChangeColotInt(5);
                }
            }
            Random random = new Random();
            for (int i = 1; i < 15; i++)
            {

                Place[0, i].ChangeColotInt(random.Next(5));
                Place[15, i].ChangeColotInt(random.Next(5));
                Place[i, 0].ChangeColotInt(random.Next(5));
                Place[i, 15].ChangeColotInt(random.Next(5));
            }
            for (int i = 4; i < 12; i++)
            {
                for (int j = 4; j < 12; j++)
                {
                    Place[i, j].ChangeColotInt(random.Next(5));
                }
            }
        }
        bool ProverkaLine(GamePoint point)
        {
            bool Type = true;
            if ((point.X == 0 || point.X == 15) && (point.Y == 0 || point.Y == 15)) { return false; }
            if (!((point.X == 0 || point.X == 15) || (point.Y == 0 || point.Y == 15))) { return false; }
            if (point.X == 0 || point.X == 15)
            {
                Type = true;
            }
            else { Type = false; }
            for (int i = 1; i < 16; i++)
            {
                if (i == 15) { return false; }
                if (!Type)
                {
                    if (point.Y == 0)
                    {
                        if (Place[point.X, point.Y].GetColor == Place[point.X, i].GetColor)
                        {
                            return true;
                        }
                        if (Place[point.X, i].GetColor != Cell.ColorCell.White)
                        {
                            if (Place[point.X + 1, i - 1].GetColor == Place[point.X, point.Y].GetColor || Place[point.X - 1, i - 1].GetColor == Place[point.X, point.Y].GetColor)
                            {
                                return true;
                            }
                            Place[point.X, i - 1].GetColor = Place[point.X, point.Y].GetColor;
                            return false;
                        }
                    }
                    else
                    {
                        if (Place[point.X, point.Y].GetColor == Place[point.X, 15 - i].GetColor)
                        {
                            return true;
                        }
                        if (Place[point.X, 15 - i].GetColor != Cell.ColorCell.White)
                        {
                            if (Place[point.X - 1, i - 1].GetColor == Place[point.X, point.Y].GetColor || Place[point.X + 1, i - 1].GetColor == Place[point.X, point.Y].GetColor)
                            {
                                return true;
                            }
                            Place[point.X, 16 - i].GetColor = Place[point.X, point.Y].GetColor;
                            return false;
                        }
                    }
                }
                else
                {
                    if (point.X == 0)
                    {
                        if (Place[i, point.Y].GetColor == Place[point.X, point.Y].GetColor)
                        {
                            return true;
                        }
                        if (Place[i, point.Y].GetColor != Cell.ColorCell.White)
                        {
                            if (Place[i - 1, point.Y + 1 ].GetColor == Place[point.X, point.Y].GetColor || Place[i - 1, point.Y - 1 ].GetColor == Place[point.X, point.Y].GetColor)
                            {
                                return true;
                            }
                            Place[i - 1, point.Y].GetColor = Place[point.X, point.Y].GetColor;
                            return false;
                        }
                    }
                    else
                    {
                        if (Place[point.X, point.Y].GetColor == Place[15 - i, point.Y].GetColor)
                        {
                            return true;
                        }
                        if (Place[15 - i, point.Y].GetColor != Cell.ColorCell.White)
                        {

                            if (Place[i - 1, point.Y + 1 ].GetColor == Place[point.X, point.Y].GetColor || Place[i - 1, point.Y - 1 ].GetColor == Place[point.X, point.Y].GetColor)
                            {
                                return true;
                            }
                            Place[16 - i, point.Y].GetColor = Place[point.X, point.Y].GetColor;
                            return false;
                        }
                    }
                }
            }
            return false;
        }

        GamePoint FindPoint(GamePoint point)
        {
            
            GamePoint res = new GamePoint();
            res.X = point.X;
            res.Y = point.Y;
            if (point.X == 0)
            {
                res.X++;
                while (Cell.ColorCell.White == Place[res.X + 1, res.Y].GetColor)
                {
                    
                    res.X++;
                }
            } else 
            if (point.X == 15)
            {
                res.X--;
                while (Cell.ColorCell.White == Place[res.X - 1, res.Y].GetColor)
                {
                    res.X--;
                }
            } else 
            if (point.Y == 0)
            {
                res.Y++;
                while (Cell.ColorCell.White == Place[res.X, res.Y + 1].GetColor)
                {
                    res.Y++;
                }
            } else
            {
                res.Y--;
                while (Cell.ColorCell.White == Place[res.X, res.Y - 1].GetColor)
                {
                    res.Y--;
                }
            }
            /*if (Place[res.X + 1, res.Y].GetColor == Place[point.X, point.Y].GetColor || Place[res.X - 1, res.Y].GetColor == Place[point.X, point.Y].GetColor ||
                Place[res.X, res.Y + 1].GetColor == Place[point.X, point.Y].GetColor || Place[res.X, res.Y - 1].GetColor == Place[point.X, point.Y].GetColor)
            */Place[res.X, res.Y].GetColor = Place[point.X, point.Y].GetColor;
            return res;
        }

        int Change(GamePoint point, Cell.ColorCell color)
        {
            if (point.X < 0 || point.X > 15 || point.Y < 0 || point.Y > 15) { return 0; }
            if (Place[point.X, point.Y].GetColor != color) { return 0; }
            Cell.ColorCell color1 = Place[point.X, point.Y].GetColor;
            Place[point.X, point.Y].GetColor = Cell.ColorCell.White;
            return 1 + Change(new GamePoint(point.X + 1, point.Y), color1) + Change(new GamePoint(point.X - 1, point.Y), color1) + Change(new GamePoint(point.X, point.Y + 1), color1) + Change(new GamePoint(point.X, point.Y - 1), color1);
        }


        public void ChangePlate(GamePoint point)
        {
            GamePoint point1 = new GamePoint(point.X,point.Y);
            if (ProverkaLine(point))
            {
                Cell.ColorCell color = Place[point1.X, point1.Y].GetColor;
                GamePoint res = FindPoint(point);
                Score += (int)Math.Pow(Change(res, Place[point.X, point.Y].GetColor), 2);
                Random random = new Random();
                Place[point1.X, point1.Y].ChangeColotInt(random.Next(5));
            }
        }
    }
}
