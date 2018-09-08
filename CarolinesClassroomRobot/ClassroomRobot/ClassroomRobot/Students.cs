

///-------------------------------------------------------------------------------------------------
// file:	Students.cs
//
// summary:	Implements the students class
///-------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomRobot
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A students. </summary>
    ///
    /// <remarks>   Jaege, 6/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------

    public class Students
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the names. </summary>
        ///
        /// <value> The names. </value>
        ///-------------------------------------------------------------------------------------------------

        public string Names { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the row. </summary>
        ///
        /// <value> The row. </value>
        ///-------------------------------------------------------------------------------------------------

        public int Row { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the column. </summary>
        ///
        /// <value> The column. </value>
        ///-------------------------------------------------------------------------------------------------

        public int Column { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the size of the record. </summary>
        ///
        /// <value> The size of the record. </value>
        ///-------------------------------------------------------------------------------------------------

        public int RecSize { get; set; } = 2 * 15 + 2 * 2 + 2 * 2;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="name">     The name. </param>
        /// <param name="row">      The row. </param>
        /// <param name="column">   The column. </param>
        ///-------------------------------------------------------------------------------------------------

        public Students(string name, int row, int column)
        {
            Names = name;
            Row = row;
            Column = column;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Sets student name. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="name"> The name. </param>
        ///-------------------------------------------------------------------------------------------------

        public void SetStudentName(string name)
        {
            Names = name;
        }

    }
}
