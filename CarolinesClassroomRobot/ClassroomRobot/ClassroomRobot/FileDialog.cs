using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomRobot
{
    class FileDialog
    {
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
