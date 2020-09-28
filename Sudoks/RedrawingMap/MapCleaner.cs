using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Sudoks
{
    static class MapCleaner
    {
        public static void Clean(TextBox[,] textBoxes, TextBox textBox)
        {
            for (int i = 0; i < textBoxes.GetLength(0); i++)
            {

                for (int j = 0; j < textBoxes.GetLength(1); j++)
                {
                    if (textBoxes[i, j].Text != "" && textBox.Text != "")
                    {
                        if (textBoxes[i, j].IsReadOnly)
                        {
                            textBoxes[i, j].Background = Brushes.GhostWhite;
                            textBoxes[i, j].Foreground = Brushes.Black;
                            textBoxes[i, j].FontSize = 25;
                            textBoxes[i, j].FontWeight = FontWeights.Bold;
                        }
                        else
                        {
                            textBoxes[i, j].Background = Brushes.White;
                            textBoxes[i, j].Foreground = Brushes.Black;
                            textBoxes[i, j].FontSize = 25;
                            textBoxes[i, j].FontWeight = FontWeights.Bold;
                        }
                    }

                }

            }
        }
      
    }
}
