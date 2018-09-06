///-------------------------------------------------------------------------------------------------
// file:	GridPosition.cs
//
// summary:	Implements the grid position class
///-------------------------------------------------------------------------------------------------

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
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A grid position. </summary>
    ///
    /// <remarks>   Jaege, 6/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------

    public static class GridPosition
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the across. </summary>
        ///
        /// <value> The across. </value>
        ///-------------------------------------------------------------------------------------------------

        public static int Across { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the down. </summary>
        ///
        /// <value> The down. </value>
        ///-------------------------------------------------------------------------------------------------

        public static int Down { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the name. </summary>
        ///
        /// <value> The name. </value>
        ///-------------------------------------------------------------------------------------------------

        public static string Name { get; set; }
        /// <summary>   List of students. </summary>
        public static ArrayList StudentList = new ArrayList();
        /// <summary>   The itemlist. </summary>
        public static ArrayList itemlist = new ArrayList();

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Reads students from file. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="FilePath"> Full pathname of the file. </param>
        ///-------------------------------------------------------------------------------------------------

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
                    if (values[2] == "Empty Desk")
                    {
                        Name = null;
                    }

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

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Displays a grid described by dgv. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="dgv">  The dgv. </param>
        ///-------------------------------------------------------------------------------------------------

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
 
    
  
