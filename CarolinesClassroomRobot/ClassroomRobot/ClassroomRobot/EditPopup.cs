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
    public partial class EditPopup : Form
    {
        public Students myStudent;
        public Colours myColour;
        public int ColourIndex;
        public int StudentIndex;

        public EditPopup()
        {
            InitializeComponent();
        }
        public EditPopup(Students student, Colours colour)
        {
            InitializeComponent();

            myStudent = student;
            myColour = colour;
        }

        private void EditPopup_Load(object sender, EventArgs e)
        {
            txtName.Text = myStudent.Names;
            Text = "Editing " + myStudent.Names;
            txtColour.Text = myColour.Colour;
            //GridPosition.StudentList.
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //ArrayList aStudentList = GridPosition.StudentList;
          //  myStudent.Names = txtName.Text;
           // aStudentList.Insert(StudentIndex, myStudent);
            myStudent = (Students)GridPosition.StudentList[0];
            MessageBox.Show("Student " + myStudent.Names);
            myStudent.Names = txtName.Text;
            myStudent = (Students)GridPosition.StudentList[0];
            MessageBox.Show("Student " + myStudent.Names);
            
        }
    }
}
