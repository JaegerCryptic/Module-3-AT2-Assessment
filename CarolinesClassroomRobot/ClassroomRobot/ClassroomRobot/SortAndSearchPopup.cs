///-------------------------------------------------------------------------------------------------
// file:	SortAndSearchPopup.cs
//
// summary:	Implements the sort and search popup class
///-------------------------------------------------------------------------------------------------

using System;
using System.Collections;
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
    /// <summary>   Popup for displayng the sort and search. </summary>
    ///
    /// <remarks>   Jaege, 6/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------

    public partial class SortAndSearchPopup : Form
       
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the zero-based index of this object. </summary>
        ///
        /// <value> The index. </value>
        ///-------------------------------------------------------------------------------------------------

        public int Index { set; get; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public SortAndSearchPopup()
        {
            InitializeComponent();
            ArrayList StudentPopupList = new ArrayList();

            foreach (Students student in GridPosition.StudentList)
            {
                if (student.Names != "Empty Desk" && student.Names != null && student.Names != "Front Desk" )
                {
                    string myStudent = student.Names;
                    int myRow = student.Row;
                    int myColumn = student.Column;


                    Students allStudents = new Students(myStudent, myRow, myColumn);
                    StudentPopupList.Add(allStudents);
                }
            }
            DataTable sortedStudents = new DataTable();
            sortedStudents.Columns.Add("Student");
            sortedStudents.Columns.Add("Row");
            sortedStudents.Columns.Add("Column");

            var sortedList = StudentPopupList.Cast<Students>().OrderBy(student => student.Names);
            foreach (Students student in sortedList)
            {
                sortedStudents.Rows.Add(student.Names, student.Row, student.Column);
            }

            dataGridStudentsList.DataSource = sortedStudents;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="searchValue">  The search value. </param>
        ///-------------------------------------------------------------------------------------------------

        public SortAndSearchPopup(string searchValue)
        {
            InitializeComponent();
            ArrayList StudentPopupList = new ArrayList();

            foreach (Students student in GridPosition.StudentList)
            {
                if (student.Names != "Empty Desk" && student.Names != null && student.Names != "Front Desk")
                {
                    string myStudent = student.Names;
                    int myRow = student.Row;
                    int myColumn = student.Column;


                    Students allStudents = new Students(myStudent, myRow, myColumn);
                    StudentPopupList.Add(allStudents);
                }
            }
            DataTable sortedStudents = new DataTable();
            sortedStudents.Columns.Add("Student");
            sortedStudents.Columns.Add("Row");
            sortedStudents.Columns.Add("Column");

            var sortedList = StudentPopupList.Cast<Students>().OrderBy(student => student.Names);
            foreach (Students student in sortedList)
            {
                sortedStudents.Rows.Add(student.Names, student.Row, student.Column);
            }

            List<string> rows = new List<string>();
            dataGridStudentsList.DataSource = sortedStudents;
            foreach (Students student in sortedList)
            {
                rows.Add(student.Names);
            }
            try
            {
                int index = rows.BinarySearch(searchValue);
                Index = index;
            }
            catch(System.ArgumentOutOfRangeException e)
            {
                MessageBox.Show("Student not found.");
                this.Close();
            }

          
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by SortAndSearchPopup for load events. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void SortAndSearchPopup_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridStudentsList.ClearSelection();
                dataGridStudentsList.Rows[Index].Selected = true;
            }
            catch (System.ArgumentOutOfRangeException a)
            {
                MessageBox.Show("Student not found.");
                this.Close();
            }
        }
    }
}
