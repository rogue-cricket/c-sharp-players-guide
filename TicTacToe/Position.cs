using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Position
    {
        public int Row { get; }
        public int Col { get; }
        public char Content { get; set; }
        public bool Filled { get; set; }

        public Position(int row, int col, char content)
        {
            Row = row;
            Col = col;
            Content = content;
            Filled = false;
        }

        /// <summary>
        /// Attempts to place a marker in the position.
        /// </summary>
        /// <param name="marker">The marker to place.</param>
        /// <returns>Returns true if the placement succeeded, false if it didn't</returns>
        public bool PlaceMarker(char marker)
        {
            if (!Filled)
            {
                Content = marker;
                Filled = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetContent()
        {
            return Content;
        }
    }
}
