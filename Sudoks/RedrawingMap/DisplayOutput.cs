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
    public class DisplayOutput:MainWindow
    {
        public void ShowStartMap(int[] randomArray, TextBox[,] textBoxes, int[,] sudokuMap)
        {
            for (int i = 0; i < textBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < textBoxes.GetLength(1); j++)
                {

                    if (randomArray == null)
                    {
                        throw new ArgumentNullException("randomArray");
                    }

                    foreach (var item in randomArray)
                    {
                        Dispatcher.Invoke(() => textBoxes[i, j].Opacity = 1);

                        if (i == 0)
                        {
                            if (j.ToString() == item.ToString())
                            {
                               Dispatcher.Invoke(()=> textBoxes[i, j].Text = sudokuMap[i, j].ToString());
                               Dispatcher.Invoke(() => textBoxes[i, j].IsReadOnly = true);
                               Dispatcher.Invoke(() => textBoxes[i, j].Background = Brushes.GhostWhite);
                               Dispatcher.Invoke(() => textBoxes[i, j].FontWeight = FontWeights.Bold);

                            }
                        }
                        else
                        {
                            if (i.ToString() + j.ToString() == item.ToString())
                            {
                                Dispatcher.Invoke(() => textBoxes[i, j].Text = sudokuMap[i, j].ToString());
                                Dispatcher.Invoke(() => textBoxes[i, j].IsReadOnly = true);
                                Dispatcher.Invoke(() => textBoxes[i, j].Background = Brushes.GhostWhite);
                                Dispatcher.Invoke(() => textBoxes[i, j].FontWeight = FontWeights.Bold);

                            }

                        }

                    }

                }
            }
        }
    }
}
