using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _DataGridView
{
    public class MyDataGridView
    {
        public static int[,] ConvertDataGridViewToArrInt(DataGridView dataGrid)
        {
            int[,] Arr = new int[dataGrid.Rows.Count, dataGrid.Columns.Count];
            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                for (int j = 0; j < dataGrid.Rows.Count; j++)
                {
                    Arr[j, i] = Convert.ToInt32(dataGrid[i, j].Value);
                }
            }
            return Arr;
        }
        public static DataGridView ConvertAttIntToDataGridView(DataGridView dataGrid, int[,] value)
        {

            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                for (int j = 0; j < dataGrid.Rows.Count; j++)
                {
                    dataGrid[i, j].Value = Convert.ToString(value[j, i]);
                }
            }
            return dataGrid;
        }
        public static DataGridView ClearDataGridView(DataGridView dataGrid)
        {
            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                dataGrid.Columns.Clear();
            }
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                dataGrid.Rows.RemoveAt(i);
            }
            return dataGrid;
        }
        public static DataGridView CreatNewDataGridView(DataGridView dataGrid, int size_x, int size_y)
        {
            string s;
            for (int i = 0; i < size_x; i++)
            {
                s = Convert.ToString(i);
                dataGrid.Columns.Add(s, s);
                dataGrid.Columns[s].Width = 30;
            }
            dataGrid.RowCount = size_y;
            return dataGrid;
        }
    }
}
