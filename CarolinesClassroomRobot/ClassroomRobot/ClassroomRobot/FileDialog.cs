///-------------------------------------------------------------------------------------------------
// file:	FileDialog.cs
//
// summary:	Implements the file Dialog
///-------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomRobot
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Dialog for setting the file. </summary>
    ///
    /// <remarks>   Jaege, 6/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------

    class FileDialog
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Opens a file. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="openFile"> The open file. </param>
        ///-------------------------------------------------------------------------------------------------

        public static void OpenFile(OpenFileDialog openFile)
        {

            MessageBox.Show("Please enter a classroom layout");

            DialogResult result = openFile.ShowDialog();

            if(result == DialogResult.OK)
            {
                string file = openFile.FileName;
                try
                {
                    GridPosition.ReadStudentsFromFile(file);
                }
                catch(IOException)
                {

                }
            }
        }


    }
}
