using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sudoks
{
    public static class RowsOrColumnIsFull
    {
        public static bool CheckForHorizontalMach(TextBox[,] textBoxes, int[,] sudokuMap, int column_i, TextBox textBox)
        {
           
            bool isMatch = true;

            int i = column_i;
            int j = 0;

            while (j < 9)
            {
                if (textBoxes == null)
                {
                    throw new ArgumentNullException("textBoxes");
                }


                if (textBoxes[i, j].Text != sudokuMap[i, j].ToString())
                {

                    return isMatch = false;
                }

                j++;
            }

            return isMatch;
        }
        public static bool CheckForVerticalMach(TextBox[,] textBoxes, int[,] sudokuMap, int column_j, TextBox textBox)
        {
            bool isMatch = true;

            int i = 0;
            int j = column_j;

            while (i < 9)
            {

                if (textBoxes == null)
                {
                    throw new ArgumentNullException("textBoxes");
                }

                if (textBoxes[i, j].Text != sudokuMap[i, j].ToString())
                {
                    
                    return isMatch = false;
                }

                i++;
            }

            return isMatch;
        }
    }
}
