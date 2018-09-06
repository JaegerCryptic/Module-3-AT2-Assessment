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

    public partial class SortAndSearchPopup : Form
        
    {
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

        private void SortAndSearchPopup_Load(object sender, EventArgs e)
        {

        }
    }
}
