using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomRobot
{
    public class Students
    {
        public string Names { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public int RecSize { get; set; } = 2 * 15 + 2 * 2 + 2 * 2;

        public Students(string name, int row, int column)
        {
            Names = name;
            Row = row;
            Column = column;
        }

        public void SetStudentName(string name)
        {
            Names = name;
        }

    }
}
