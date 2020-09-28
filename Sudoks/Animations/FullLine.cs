using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Sudoks.Animations
{
    public class FullLine:MainWindow
    {
        public void AnimateVertical(TextBox[,] textBoxes, int j, Brush[] brushes)
        {


            int count = 0;

            int count_j = 0;

            int countMorEndColor = 0;

            int countStoper = 0;
            int countStoperEnd = 0;
            int maxAnimIndex = 0;


            Task.Run(() =>
            {


                while (count < 27)
                {

                    countStoper = count;

                    if (countStoper < 18)
                    {
                        countStoper = 0;
                    }
                    else
                    {
                        countStoper = count - 18;
                    }

                    maxAnimIndex = MaxAnimIndex(count);

                    countStoperEnd = count;

                    if (countStoperEnd > 8)
                    {

                        countMorEndColor++;

                        if (countMorEndColor < 11)
                        {
                            ColorSpotsEnd(j, 8 + countMorEndColor, countStoper, 9, textBoxes);
                        }
                        else
                        {
                            ColorSpotsEnd(j, 18, countStoper, 9, textBoxes);
                        }


                    }
                    else
                    {
                        ColorSpots(j, 0 + count, countStoper, maxAnimIndex, textBoxes);
                    }



                    count++;
                    if (count > 18)
                    {

                        Dispatcher.Invoke(() => textBoxes[count_j, j].Background = brushes[count_j]);

                        if (Dispatcher.Invoke(() => textBoxes[count_j, j].Background == Brushes.SeaGreen))
                        {

                            Dispatcher.Invoke(() => textBoxes[count_j, j].Foreground = Brushes.White);
                            Dispatcher.Invoke(() => textBoxes[count_j, j].FontWeight = FontWeights.ExtraBlack);
                        }
                        else
                        {
                            Dispatcher.Invoke(() => textBoxes[count_j, j].Foreground = Brushes.Black);
                            Dispatcher.Invoke(() => textBoxes[count_j, j].FontWeight = FontWeights.Bold);
                        }

                        count_j++;
                    }

                    Thread.Sleep(40);

                }
            });


        }
        public void AnimateHorizontal(TextBox[,] textBoxes, int j, Brush[] brushes)
        {

            int count = 0;
            int count_j = 0;

            int countMorEndColor = 0;

            int countStoper = 0;
            int countStoperEnd = 0;
            int maxAnimIndex = 0;


            Task.Run(() =>
            {


                while (count < 27)
                {

                    countStoper = count;

                    if (countStoper < 18)
                    {
                        countStoper = 0;
                    }
                    else
                    {
                        countStoper = count - 18;
                    }

                    maxAnimIndex = MaxAnimIndex(count);



                    countStoperEnd = count;

                    if (countStoperEnd > 8)
                    {

                        countMorEndColor++;

                        if (countMorEndColor < 11)
                        {
                            Dispatcher.Invoke(() => ColorSpotsEndHorizontal(j, 8 + countMorEndColor, countStoper, 9, textBoxes));
                        }
                        else
                        {
                            Dispatcher.Invoke(() => ColorSpotsEndHorizontal(j, 18, countStoper, 9, textBoxes));
                        }


                    }
                    else
                    {
                        Dispatcher.Invoke(() => ColorSpotsHorizontal(j, 0 + count, countStoper, maxAnimIndex, textBoxes));
                    }


                    count++;
                    if (count > 18)
                    {

                        Dispatcher.Invoke(() => textBoxes[j, count_j].Background = brushes[count_j]);

                        if (Dispatcher.Invoke(() => textBoxes[j, count_j].Background == Brushes.SeaGreen))
                        {
                            Dispatcher.Invoke(() => textBoxes[j, count_j].Foreground = Brushes.White);
                            Dispatcher.Invoke(() => textBoxes[j, count_j].FontWeight = FontWeights.ExtraBlack);
                        }
                        else
                        {
                            Dispatcher.Invoke(() => textBoxes[j, count_j].Foreground = Brushes.Black);
                            Dispatcher.Invoke(() => textBoxes[j, count_j].FontWeight = FontWeights.Bold);
                        }

                        count_j++;
                    }

                    Thread.Sleep(40);


                }
            });

        }

        private void ColorSpots(int j, int brushIndex, int startIndex, int maxAnimIndex, TextBox[,] textBoxes)
        {
            if (startIndex == maxAnimIndex) return;

            if (Dispatcher.Invoke(() => textBoxes[startIndex, j].Background != Brushes.SeaGreen))
            {
                Dispatcher.Invoke(() => textBoxes[startIndex, j].Background = RGBContainer.RGB(brushIndex));
                Dispatcher.Invoke(() => textBoxes[startIndex, j].FontWeight = FontWeights.ExtraBlack);
                Dispatcher.Invoke(() => textBoxes[startIndex, j].Foreground = Brushes.White);
            }


            ColorSpots(j, brushIndex - 1, startIndex + 1, maxAnimIndex, textBoxes);
        }
        private void ColorSpotsEnd(int j, int brushIndex, int startIndex, int maxAnimIndex, TextBox[,] textBoxes)
        {
            if (startIndex == maxAnimIndex) return;

            if (Dispatcher.Invoke(() => textBoxes[startIndex, j].Background != Brushes.SeaGreen))
            {
                Dispatcher.Invoke(() => textBoxes[startIndex, j].Background = RGBContainer.RGB(brushIndex));
                Dispatcher.Invoke(() => textBoxes[startIndex, j].FontWeight = FontWeights.ExtraBlack);
                Dispatcher.Invoke(() => textBoxes[startIndex, j].Foreground = Brushes.White);
            }


            ColorSpotsEnd(j, brushIndex - 1, startIndex + 1, maxAnimIndex, textBoxes);
        }
        private void ColorSpotsHorizontal(int j, int brushIndex, int startIndex, int maxAnimIndex, TextBox[,] textBoxes)
        {
            if (startIndex == maxAnimIndex) return;

            if (Dispatcher.Invoke(() => textBoxes[j, startIndex].Background != Brushes.SeaGreen))
            {
                Dispatcher.Invoke(() => textBoxes[j, startIndex].Background = RGBContainer.RGB(brushIndex));
                Dispatcher.Invoke(() => textBoxes[j, startIndex].FontWeight = FontWeights.ExtraBlack);
                Dispatcher.Invoke(() => textBoxes[j, startIndex].Foreground = Brushes.White);
            }


            ColorSpotsHorizontal(j, brushIndex - 1, startIndex + 1, maxAnimIndex, textBoxes);
        }
        private void ColorSpotsEndHorizontal(int j, int brushIndex, int startIndex, int maxAnimIndex, TextBox[,] textBoxes)
        {
            if (startIndex == maxAnimIndex) return;

            if (Dispatcher.Invoke(() => textBoxes[j, startIndex].Background != Brushes.SeaGreen))
            {
                Dispatcher.Invoke(() => textBoxes[j, startIndex].Background = RGBContainer.RGB(brushIndex));
                Dispatcher.Invoke(() => textBoxes[j, startIndex].FontWeight = FontWeights.ExtraBlack);
                Dispatcher.Invoke(() => textBoxes[j, startIndex].Foreground = Brushes.White);
            }


            ColorSpotsEndHorizontal(j, brushIndex - 1, startIndex + 1, maxAnimIndex, textBoxes);
        }
        private int MaxAnimIndex(int count)
        {
            int maxAnimIndex = 0;

            switch (count)
            {
                case 0:
                    maxAnimIndex = 1;
                    break;
                case 1:
                    maxAnimIndex = 2;
                    break;
                case 2:
                    maxAnimIndex = 3;
                    break;
                case 3:
                    maxAnimIndex = 4;
                    break;
                case 4:
                    maxAnimIndex = 5;
                    break;
                case 5:
                    maxAnimIndex = 6;
                    break;
                case 6:
                    maxAnimIndex = 7;
                    break;
                case 7:
                    maxAnimIndex = 8;
                    break;
                case 8:
                    maxAnimIndex = 9;
                    break;

            }

            return maxAnimIndex;
        }
    }
}
