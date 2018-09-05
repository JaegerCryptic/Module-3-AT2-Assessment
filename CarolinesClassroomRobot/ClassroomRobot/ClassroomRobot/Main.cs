using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomRobot
{

    public partial class Main : Form
    {
        DataTable table =  DataGrid.Classroom();

        public Main()
        {
            InitializeComponent();
            dataGridClass.DataSource = table;

            GridPosition.ReadFromFile();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var DataGrid = new DataGrid();
            DataGrid.SizeDGV(dataGridClass);

            GridPosition.DisplayGrid(dataGridClass);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int columnHeader = Convert.ToInt32(dataGridClass.SelectedCells[0].OwningColumn.HeaderCell.ColumnIndex);
            int rowHeader = Convert.ToInt32(dataGridClass.SelectedCells[0].OwningRow.HeaderCell.RowIndex);
            int studentIndex = 0;
            bool found = false;

            foreach (Students student in GridPosition.StudentList)
            {
                if(student.Column == columnHeader && student.Row == rowHeader)
                {
                    studentIndex = GridPosition.StudentList.IndexOf(student);
                    found = true;
                }
            }
            
            if (found == false)
            {
                MessageBox.Show("This is not a person.");
            }
            else
            {
                EditPopup test = new EditPopup((Students)GridPosition.StudentList[studentIndex]);
                test.ShowDialog();
                GridPosition.DisplayGrid(dataGridClass);
            }
        }
    }
}
