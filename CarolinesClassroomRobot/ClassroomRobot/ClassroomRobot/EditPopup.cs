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
        
        public EditPopup()
        {
            InitializeComponent();
        }
        public EditPopup(Students student)
        {
            InitializeComponent();
            myStudent = student;
        }

        private void EditPopup_Load(object sender, EventArgs e)
        {
            txtName.Text = myStudent.Names;
            Text = "Editing " + myStudent.Names;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            myStudent.Names = txtName.Text;
            myStudent = (Students)GridPosition.StudentList[0];
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
