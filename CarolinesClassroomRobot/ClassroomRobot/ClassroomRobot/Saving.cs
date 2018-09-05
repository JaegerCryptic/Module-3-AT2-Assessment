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
                var studentRow = student.Row;
                var studentColumn = student.Column;
                var csvFormat = string.Format("{0},{1},{2}", studentColumn, studentRow, studentNames);
                csv.AppendLine(csvFormat);
            }
            File.WriteAllText("UpdatedClassRoomLayout.csv", csv.ToString());

        }

    }
}
