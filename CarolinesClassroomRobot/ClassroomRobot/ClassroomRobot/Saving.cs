using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomRobot
{
    class Saving : Main
    {
        public static void  SaveToFile()
        {
            var csv = new StringBuilder();

            foreach(Students student in GridPosition.StudentList)
            {
                var studentNames = student.Names;

                if (studentNames == null)
                {
                    studentNames = "Empty";
                }

                var studentRow = student.Row;
                var studentColumn = student.Column;
                var csvStudentFormat = string.Format("{0},{1},{2}", studentColumn, studentRow, studentNames);
                csv.AppendLine(csvStudentFormat);
            }

            foreach(Colours colour in GridPosition.itemlist)
            {
                var colourColumn = colour.Column;
                var colourRow = colour.Row;
                var myColour = colour.Colour;

                var csvColourFormat = string.Format("{0},{1},{2},{3}", colourColumn, colourRow, "BKGRND FILL", myColour);
                csv.AppendLine(csvColourFormat);
            }
            File.WriteAllText("UpdatedClassRoomLayout.csv", csv.ToString());
            MessageBox.Show("New layout successfully saved as UpdatedClassRoomLayout.csv.");
        }

    }
}
