using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassroomRobot
{
    public static class GridPosition
    {
        public static int Across { get; set; }
        public static int Down { get; set; }
        public static string Name { get; set; }
        public static ArrayList StudentList = new ArrayList();
        public static ArrayList itemlist = new ArrayList();

        public static void ReadStudentsFromFile(string FilePath)
        {
            var lines = System.IO.File.ReadAllLines(FilePath).Skip(4);
            int i = 0;
            foreach (string item in lines)
            {
                var values = item.Split(',');

                if (values[2] != "BKGRND FILL")
                {
                    Across = Convert.ToInt32(values[0]);
                    Down = Convert.ToInt32(values[1]);
                    Name = values[2];
                    
                    Students myStudent = new Students(Name, Down, Across);
                    StudentList.Add(myStudent);
                } 
                else
                {
                    itemlist.Add(new Colours(values[3], Convert.ToInt32(values[1]), Convert.ToInt32(values[0])));
                    Colours myColour = (Colours)itemlist[i];
                    i++;
                }
            }
        }
        public static void DisplayGrid(DataGridView dgv)
        {

            foreach (Students student in StudentList)
            {
                dgv.Rows[student.Row].Cells[student.Column].Value = student.Names; 
            }
            foreach (Colours colour in itemlist)
            {
                dgv.Rows[colour.Row].Cells[colour.Column].Style.BackColor = System.Drawing.Color.CornflowerBlue;
            }
        }
    }
}
 
    
  
