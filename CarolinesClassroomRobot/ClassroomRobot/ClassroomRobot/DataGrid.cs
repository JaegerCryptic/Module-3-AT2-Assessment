///-------------------------------------------------------------------------------------------------
// file:	DataGrid.cs
//
// summary:	Implements the data grid class
///-------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomRobot
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A data grid. </summary>
    ///
    /// <remarks>   Jaege, 6/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------

    public class DataGrid
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets the classroom. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <returns>   A DataTable. </returns>
        ///-------------------------------------------------------------------------------------------------

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

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Size dgv. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="dgv">  The dgv. </param>
        ///-------------------------------------------------------------------------------------------------

        public static void SizeDGV(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].HeaderCell.Value = (i).ToString();
            }
        }
    }
}
