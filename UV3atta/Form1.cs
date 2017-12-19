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
using _Room;

namespace UV3atta
{
    public partial class Form1 : Form
    {
        Base newbase;
        public Form1()
        {
            InitializeComponent();
            newbase = new Base();
        }
        int k = 1;
        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (k < dataGridView1.RowCount)
            {
                k++;
                Room room = new Room("", -1, -1, -1, -1);
                newbase.Add(room);
            }

        }


        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {


        }
    }
}
