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
    public partial class RandomAccessPopup : Form
    {
        public RandomAccessPopup()
        {
            InitializeComponent();
        }
        public RandomAccessPopup(Students student)
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(txtName.Text);
            RandomAccess.FindFromFile("Student.txt", index);
            this.Close();
        }

        private void RandomAccessPopup_Load(object sender, EventArgs e)
        {

        }
    }
}
