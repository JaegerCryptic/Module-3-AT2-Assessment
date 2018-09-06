///-------------------------------------------------------------------------------------------------
// file:	Colours.cs
//
// summary:	Implements the colours class
///-------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomRobot
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A colours. </summary>
    ///
    /// <remarks>   Jaege, 6/09/2018. </remarks>
    ///-------------------------------------------------------------------------------------------------

    public class Colours
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the colour. </summary>
        ///
        /// <value> The colour. </value>
        ///-------------------------------------------------------------------------------------------------

        public string Colour { get; set; }

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
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Jaege, 6/09/2018. </remarks>
        ///
        /// <param name="colour">   The colour. </param>
        /// <param name="row">      The row. </param>
        /// <param name="column">   The column. </param>
        ///-------------------------------------------------------------------------------------------------

        public Colours(string colour, int row, int column)
        {
            Colour = colour;
            Row = row;
            Column = column;
        }
    }
}
