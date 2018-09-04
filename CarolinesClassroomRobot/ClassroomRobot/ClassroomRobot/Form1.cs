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

    public partial class Form1 : Form
    {
        DataTable table =  DataGrid.Classroom();

        public Form1()
        {
            InitializeComponent();

            //table = myInfo.

            dataGridClass.DataSource = table;

            GridPosition.ReadFromFile();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var DataGrid = new DataGrid();
            DataGrid.SizeDGV(dataGridClass);

            GridPosition.DisplayGrid(dataGridClass);

            //GridPosition grid = new GridPosition();
            //grid.ReadFromFile();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string columnHeader = dataGridClass.SelectedCells[0].OwningColumn.HeaderCell.ToString();
            string rowHeader = dataGridClass.SelectedCells[0].OwningRow.HeaderCell.ToString();
            int studentIndex = 0;

            foreach (Students student in GridPosition.StudentList)
            {
                if(student.Column.ToString() == columnHeader && student.Row.ToString() == rowHeader)
                {
                    studentIndex = GridPosition.StudentList.IndexOf(student);
                }
            }

            EditPopup test = new EditPopup((Students)GridPosition.StudentList[studentIndex], (Colours)GridPosition.itemlist[0]);
            //test.Tag = GridPosition.StudentList[0];
            test.ShowDialog();
            //{
              //  MessageBox.Show(myStudent.Names);
            //}
            GridPosition.DisplayGrid(dataGridClass);

        }
    }
}
