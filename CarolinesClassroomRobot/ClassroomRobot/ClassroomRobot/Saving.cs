///-------------------------------------------------------------------------------------------------
// file:	Saving.cs
//
// summary:	Implements the saving class
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
    /// <summary>   A saving. </summary>
    ///
    /// <remarks>   Jaege, 6/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------

    class Saving
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Saves to file. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="teacher">  The teacher. </param>
        /// <param name="classNo">  The class no. </param>
        /// <param name="room">     The room. </param>
        /// <param name="date">     The date. </param>
        ///-------------------------------------------------------------------------------------------------

        public static void  SaveToFile(string teacher, string classNo, string room, string date)
        {
            var csv = new StringBuilder();

            var Teacher = teacher;
            var ClassNo = classNo;
            var Room = room;
            var Date = date;

            var csvTeacherFormat = string.Format("{0},{1}", "Teacher:", Teacher);
            csv.AppendLine(csvTeacherFormat);

            var csvClassNoFormat = string.Format("{0},{1}", "Class:", ClassNo);
            csv.AppendLine(csvClassNoFormat);

            var csvRoomFormat = string.Format("{0},{1}", "Room:", Room);
            csv.AppendLine(csvRoomFormat);

            var csvDateFormat = string.Format("{0},{1}", "Date:", Date);
            csv.AppendLine(csvDateFormat);

            foreach (Students student in GridPosition.StudentList)
            {
                var studentNames = student.Names;

                if (studentNames == null)
                {
                    studentNames = "Empty Desk";
                }

                var studentRow = student.Row;
                var studentColumn = student.Column;
                var csvStudentFormat = string.Format("{0},{1},{2}", studentColumn, studentRow, studentNames);
                csv.AppendLine(csvStudentFormat);
            }

            foreach(Colours colour in GridPosition.ColourList)
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
