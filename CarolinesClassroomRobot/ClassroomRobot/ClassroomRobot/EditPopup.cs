///-------------------------------------------------------------------------------------------------
// file:	EditPopup.cs
//
// summary:	Implements the edit popup class
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
    /// <summary>   Popup for displayng the edit. </summary>
    ///
    /// <remarks>   Jaege, 6/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------

    public partial class EditPopup : Form
    {
        /// <summary>   my student. </summary>
        public Students myStudent;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Default constructor. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///-------------------------------------------------------------------------------------------------

        public EditPopup()
        {
            InitializeComponent();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="student">  The student. </param>
        ///-------------------------------------------------------------------------------------------------

        public EditPopup(Students student)
        {
            InitializeComponent();
            myStudent = student;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by EditPopup for load events. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void EditPopup_Load(object sender, EventArgs e)
        {
            txtName.Text = myStudent.Names;
            Text = "Editing " + myStudent.Names;
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
            myStudent.Names = txtName.Text;
            myStudent = (Students)GridPosition.StudentList[0];
            this.Close();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Event handler. Called by btnCancel for click events. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="sender">   Source of the event. </param>
        /// <param name="e">        Event information. </param>
        ///-------------------------------------------------------------------------------------------------

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
