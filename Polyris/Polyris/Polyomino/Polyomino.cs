using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyris.Polyomino
{
    /// <summary>
    /// This abstract polyomino class defines the necessary methods and properties that all inherited polyomino classes must
    /// have to function in this game. All polyomino subclasses should inherit this class.
    /// </summary>
    public abstract class Polyomino
    {
        internal char[,] peice;

        /// <summary>
        /// The rotate method takes in a polyomino peice represented by a 2D char array and rotates it 90 degrees clockwise.
        /// </summary>
        public void Rotate(char[,] peice) 
        {
            //TODO: Use techniques from algorithms and data structures book to figure out the process of rotating a 2D matrix .
        }

    }
}
