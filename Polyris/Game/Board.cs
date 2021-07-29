using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyris
{
    public class Board
    {
        private char[,] gameBoard;
        private char[,] currentPolyomino;
        private char[,] nextPolyomino;
        private int currentPolyominoXAxis;
        private int currentPolyominoYAxis;

        public char[,] GameBoard
        {
            get
            {
                return gameBoard;
            }
            set 
            { 
            
            }
        }

        public char[,] CurrentPolyomino
        {
            get
            {
                return currentPolyomino;
            }
            set
            {

            }
        }

        public char[,] NextPolyomino
        {
            get
            {
                return nextPolyomino;
            }
            set
            {

            }
        }

        private void CreateBoard(int size)
        {

        }

        public void UpdateBoard(Board board)
        {

        }

        private char[,] NewPolyomino()
        {
            return null;
        }

        private char[,] RotatePolyomino(char[,] originalPolyomino)
        {
            /* 
             * TODO: should have really created test scenarios in advance before 
             * writing this function, so go back and create test scenarios to ensure
             * that this function works for all scenarios. Will also need error handling
             * added for obscure scenarios.
             * 
             * This should include:
             * arrays of large sizes
             * rectangular arrays
             * arrays of size 0
             * 
             */

            int[] test = new int[0];

            int arrayLength = originalPolyomino.GetLength(0);
            char[,] rotatedPolyomino = new char[arrayLength, arrayLength];

            for(int i = 0; i<arrayLength; i++)
            {
                for(int j = 0; j<arrayLength; j++)
                {
                    rotatedPolyomino[i, j] =
                        originalPolyomino[arrayLength - 1 - j, i];
                }
            }

            return rotatedPolyomino;
        }

        

        private void DeleteRow()
        {

        }
 
    }
}
