using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _Room;
using ClassLibrary;
using _FileString;
using VisualeClasses;
//using Utils;
//using _DataGridView;

namespace _101._30._30
{ /*30. В базе данных недвижимости хранится информация о квартирах – район города (строка), количество комнат, общая площадь, 
    площадь кухни, стоимость. Для каждого района города найти самую дешевую квартиру с указанным кол-вом комнат N (задается) 
    и площадью не меньше S (также задается).*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Newbase.Add(new Room("", -1, -1, -1, -1));
        }
        Base Newbase = new Base();
        List<Room> res;
        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Newbase.Add(new Room("", -1, -1, -1, -1));
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Point x = dataGridView231.CurrentCellAddress;
            if (x.X == 0)
            {
                Newbase.MainBase[x.Y].name = Convert.ToString(dataGridView231[x.X, x.Y].Value);
            }
            if (x.X == 1)
            {
                Newbase.MainBase[x.Y].Nroom = Convert.ToInt32(dataGridView231[x.X, x.Y].Value);
            }
            if (x.X == 2)
            {
                Newbase.MainBase[x.Y].Smax = Convert.ToDouble(dataGridView231[x.X, x.Y].Value);
            }
            if (x.X == 3)
            {
                Newbase.MainBase[x.Y].Scook = Convert.ToDouble(dataGridView231[x.X, x.Y].Value);
            }
            if (x.X == 4)
            {
                Newbase.MainBase[x.Y].Price = Convert.ToDouble(dataGridView231[x.X, x.Y].Value);
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            dataGridView1 = VisualeClasses.MyDataGridView.ClearDataGridView(dataGridView1);
            res = Newbase.Find(Convert.ToInt32(textBoxReadN.Text), Convert.ToDouble(textBoxReadS.Text));
            dataGridView1.Columns.Add("Name", "Название района");
            dataGridView1.Columns.Add("Nroom", "Количество комнат");
            dataGridView1.Columns.Add("Smax", "Общая площадь");
            dataGridView1.Columns.Add("Scook", "Площадь кухни");
            dataGridView1.Columns.Add("Price", "Цена");
            for (int i = 0; i < res.Count; i++)
            {
                dataGridView1.Rows.Add(res[i].name, Convert.ToString(res[i].Nroom), Convert.ToString(res[i].Smax), Convert.ToString(res[i].Scook), Convert.ToString(res[i].Price));
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;
                string File = _FileString.MyFileString.ReadF(name);
                string[] arrstring = File.Split(new char[] { ' ', ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < arrstring.Length; i += 5)
                {
                    Newbase.Add(new Room(arrstring[i], Convert.ToInt32(arrstring[i + 1]), Convert.ToDouble(arrstring[i + 2]), Convert.ToDouble(arrstring[i + 3]), Convert.ToDouble(arrstring[i + 4])));
                }
                dataGridView231 = VisualeClasses.MyDataGridView.ClearDataGridView(dataGridView231);
                dataGridView231.Columns.Add("Название района", "Название района");
                dataGridView231.Columns.Add("Количество комнат", "Количество комнат");
                dataGridView231.Columns.Add("Общая площадь", "Общая площадь");
                dataGridView231.Columns.Add("Площадь кухни", "Площадь кухни");
                dataGridView231.Columns.Add("Цена", "Цена");
                for (int i = 0; i < Newbase.MainBase.Count; i++)
                {
                    dataGridView231.Rows.Add(Newbase.MainBase[i].name, Convert.ToString(Newbase.MainBase[i].Nroom), Convert.ToString(Newbase.MainBase[i].Smax), Convert.ToString(Newbase.MainBase[i].Scook), Convert.ToString(Newbase.MainBase[i].Price));
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = saveFileDialog1.FileName;
                _FileString.MyFileString.ClearF(name);
                for (int i = 0; i < res.Count; i++)
                {
                    _FileString.MyFileString.WriteF(name, ("Район: " + res[i].name + " кол -во комнат: " + Convert.ToString(res[i].Nroom) + " площадь: " + Convert.ToString(res[i].Smax) + " площадь кухни: " + Convert.ToString(res[i].Scook) + " цена: " + Convert.ToString(res[i].Price) + '\r' + '\n'));

                }
            }
        }
    }
}
