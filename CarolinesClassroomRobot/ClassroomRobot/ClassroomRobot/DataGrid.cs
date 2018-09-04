using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomRobot
{
    public class DataGrid
    {
        public static DataTable Classroom()
        {
            DataTable csvTable = new DataTable();

            for (int i = 0; i < 10; i++)
            {
                csvTable.Columns.Add(i.ToString());
            }
            for (int i = 0; i < 19; i++)
            {
                csvTable.Rows.Add();
            }
                return csvTable;
        }
        public void SizeDGV(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].HeaderCell.Value = (i).ToString();
            }
        }
    }
}
