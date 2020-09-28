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
    public class NumberColorsOnEnter:MainWindow
    {
        public NumberColorsOnEnter(TextBox[,] textBoxes, TextBox textBox, int[,] sudokuMap)
        {
            for (int i = 0; i < textBoxes.GetLength(0); i++)
            {

                for (int j = 0; j < textBoxes.GetLength(1); j++)
                {
                    if (textBoxes[i, j].Text == textBox.Text)
                    {

                        if (textBoxes[i, j].Text != sudokuMap[i, j].ToString() && textBoxes[i, j].Text != "")
                        {
                            Dispatcher.Invoke(() => textBoxes[i, j].Background = Brushes.Crimson);
                            Dispatcher.Invoke(() => textBoxes[i, j].Foreground = Brushes.White);
                            Dispatcher.Invoke(() => textBoxes[i, j].FontWeight = FontWeights.ExtraBlack);
                        }

                        else if (textBoxes[i, j].Text == sudokuMap[i, j].ToString())
                        {
                            Dispatcher.Invoke(() => textBoxes[i, j].Background = Brushes.SeaGreen);
                            Dispatcher.Invoke(() => textBoxes[i, j].Foreground = Brushes.White);
                            Dispatcher.Invoke(() => textBoxes[i, j].FontWeight = FontWeights.ExtraBlack);

                        }



                    }

                }

            }
        }
    }
}
