using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomRobot
{
    public class Colours
    {
        public string Colour { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        
        public Colours(string colour, int row, int column)
        {
            Colour = colour;
            Row = row;
            Column = column;
        }
    }
}
