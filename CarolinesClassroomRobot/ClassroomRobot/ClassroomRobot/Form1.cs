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
            EditPopup test = new EditPopup((Students)GridPosition.StudentList[0], (Colours)GridPosition.itemlist[0], 0,0);
            //test.Tag = GridPosition.StudentList[0];
            test.ShowDialog();
            //{
              //  MessageBox.Show(myStudent.Names);
            //}
            GridPosition.DisplayGrid(dataGridClass);

        }
    }
}
