///-------------------------------------------------------------------------------------------------
///	Author: Kyle Kent
/// 
/// Student Number: 465510139
///	
/// Purpose: Displays clasroom desks and students in a grid format
///-------------------------------------------------------------------------------------------------

///-------------------------------------------------------------------------------------------------
// file:	Main.cs
//
// summary:	Implements the main class
///-------------------------------------------------------------------------------------------------

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
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A main. </summary>
    ///
    /// <remarks>   Jaege, 6/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------

    public partial class Main : Form
    {
        /// <summary>   The table. </summary>
        DataTable table = DataGrid.Classroom();

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public Main()
        {
            InitializeComponent();
            dataGridClass.DataSource = table;

            txtDate.Text = DateTime.Now.ToString();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by Form1 for load events. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            FileDialog.OpenFile(dialog);

            var DataGrid = new DataGrid();
            DataGrid.SizeDGV(dataGridClass);

            GridPosition.DisplayGrid(dataGridClass);
            dataGridClass.ClearSelection();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnEdit for click events. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int columnHeader = Convert.ToInt32(dataGridClass.SelectedCells[0].OwningColumn.HeaderCell.ColumnIndex);
            int rowHeader = Convert.ToInt32(dataGridClass.SelectedCells[0].OwningRow.HeaderCell.RowIndex);
            int studentIndex = 0;
            bool found = false;

            foreach (Students student in GridPosition.StudentList)
            {
                if (student.Column == columnHeader && student.Row == rowHeader)
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

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnClear for click events. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Students student in GridPosition.StudentList)
            {
                if (student.Names != "Front Desk")
                {
                    student.Names = null;
                }
            }
            GridPosition.DisplayGrid(dataGridClass);

        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnSave for click events. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnSave_Click(object sender, EventArgs e)
        {
            Saving.SaveToFile(txtTeacher.Text.ToString(), txtClass.Text.ToString(), txtRoom.Text.ToString(), txtDate.Text.ToString());
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnSort for click events. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortAndSearchPopup sort = new SortAndSearchPopup();
            sort.ShowDialog();

        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnFind for click events. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnFind_Click(object sender, EventArgs e)
        {
            string userName = txtSearch.Text;
            SortAndSearchPopup search = new SortAndSearchPopup(userName);
            search.Show();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnRAF for click events. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnRAF_Click(object sender, EventArgs e)
        {
            int columnHeader = Convert.ToInt32(dataGridClass.SelectedCells[0].OwningColumn.HeaderCell.ColumnIndex);
            int rowHeader = Convert.ToInt32(dataGridClass.SelectedCells[0].OwningRow.HeaderCell.RowIndex);
            int studentIndex = 0;
            string name = "";

            foreach (Students student in GridPosition.StudentList)
            {
                if (student.Column == columnHeader && student.Row == rowHeader)
                {
                    studentIndex = GridPosition.StudentList.IndexOf(student);
                    name = student.Names;
                }
            }
            RandomAccess.MainMethod(name, rowHeader, columnHeader, studentIndex);
            GridPosition.DisplayGrid(dataGridClass);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
