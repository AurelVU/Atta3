using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace _13._30._30
{
    public partial class Form1 : Form
    {
        /*62. http://www.min2win.ru/gm.php?id=1682 */
        enum Type
        {
            Game, Pause
        }
        Type GameType = Type.Pause;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
           
            for (int i = -4; i < 12; i++)
            {
                dataGridView1.Columns.Add(Convert.ToString(i), "");
                
            }
            for (int i = -4; i < 11; i++)
            {
                dataGridView1.Rows.Add(Convert.ToString(i), "");
            }
            for (int i = -4; i < 12; i++)
            {
                dataGridView1.Columns[i + 4].Width = 30;
                dataGridView1.Rows[i + 4].Height = 30;
            }
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            // dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    dataGridView1[i, j].ReadOnly = true;
                    dataGridView1[i, j].Value = "";
                }
            }

        }
        ClassLibrary.Game game = new Game();
        private void buttonStart_Click(object sender, EventArgs e)
        {
            GameType = Type.Game;   
            dataGridView1 = ClassLibrary.PlateAndDGV.ConvertPlateToDGV(dataGridView1, game);
            buttonStart.Enabled = true;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (GameType == Type.Game)
            {
                System.Drawing.Point CoordPoint;
                CoordPoint = dataGridView1.CurrentCellAddress;
                game.ChangePlate(ClassLibrary.PlateAndDGV.ConvertPointToGamePoint(CoordPoint));
                dataGridView1 = ClassLibrary.PlateAndDGV.ConvertPlateToDGV(dataGridView1, game);
                labelWrite.Text = Convert.ToString(game.Score);
            }
        }

        private void buttonRetry_Click(object sender, EventArgs e)
        {
            if (GameType == Type.Game)
            {
                game = new Game();
                dataGridView1 = ClassLibrary.PlateAndDGV.ConvertPlateToDGV(dataGridView1, game);
                labelWrite.Text = Convert.ToString(game.Score);
            }
        }
    }
}
