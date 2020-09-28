using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sudoks.Animations
{
    public class AnimateCellClick:MainWindow
    {
        Task task1;

        public async void AnimateKeyUp(bool changeLevelButton, object sender, TextBox[,] textBoxes)
        {
            if (changeLevelButton)
            {
                TextBox textBox = sender as TextBox;
                for (int i = 0; i < textBoxes.GetLength(0); i++)
                {

                    for (int j = 0; j < textBoxes.GetLength(1); j++)
                    {

                        if (textBoxes[i, j] == textBox)
                        {

                            task1 = Task.Run(() => deleteTransparentCells(textBoxes));


                            double opoc = 0.85;
                            int counter = j;
                            int counterV = i;

                            int counterhh = j;

                            await task1.ContinueWith((Action) => {


                                Parallel.Invoke(() =>
                                {
                                    getHLeft(counterhh, i, opoc, textBoxes);
                                },

                                () =>
                                {
                                    getHRight(counter, i, opoc, textBoxes);
                                },

                                () =>
                                {
                                    getVDown(counterV, j, opoc, textBoxes);
                                },
                                 () =>
                                 {
                                     getVUpForKeyUp(counterV, j, opoc, textBoxes);
                                 }

                            );
                            });



                        }


                    }

                }
            }
        }
        private void getHLeft(int counterhh, int i, double opoc, TextBox[,] textBoxes)
        {
            new Thread(() => {
                int countSteps = 0;
                while (counterhh > -1)
                {
                    countSteps++;
                    if (countSteps == 1)
                        Dispatcher.Invoke(() => textBoxes[i, counterhh].Opacity = 1);
                    else
                        Dispatcher.Invoke(() => textBoxes[i, counterhh].Opacity = opoc);
                    opoc += 0.02;
                    Thread.Sleep(50);
                    counterhh--;
                }
            }).Start();
        }
        private void getHRight(int counter, int i, double opoc, TextBox[,] textBoxes)
        {
            new Thread(() => {
                int countSteps = 0;
                while (counter < 9)
                {
                    countSteps++;
                    if (countSteps == 1)
                        Dispatcher.Invoke(() => textBoxes[i, counter].Opacity = 1);
                    else
                        Dispatcher.Invoke(() => textBoxes[i, counter].Opacity = opoc);
                    opoc += 0.02;
                    Thread.Sleep(50);
                    counter++;
                }
            }).Start();
        }
        private void getVDown(int counterV, int j, double opoc, TextBox[,] textBoxes)
        {
            new Thread(() => {
                int countSteps = 0;
                while (counterV > -1)
                {
                    countSteps++;
                    if (countSteps == 1)
                        Dispatcher.Invoke(() => textBoxes[counterV, j].Opacity = 1);
                    else
                        Dispatcher.Invoke(() => textBoxes[counterV, j].Opacity = opoc);
                    opoc += 0.02;
                    Thread.Sleep(50);
                    counterV--;
                }
            }).Start();
        }
        private void getVUpForKeyUp(int counterV, int j, double opoc, TextBox[,] textBoxes)
        {
            new Thread(() =>
            {
                int countSteps = 0;

                while (counterV < 9)
                {
                    countSteps++;
                    if (countSteps == 1)
                        Dispatcher.Invoke(() => textBoxes[counterV, j].Opacity = 1);
                    else
                        Dispatcher.Invoke(() => textBoxes[counterV, j].Opacity = opoc);


                    opoc += 0.02;
                    Thread.Sleep(50);
                    counterV++;
                }
            }).Start();
        }

        private void deleteTransparentCells(TextBox[,] textBoxes)
        {
            Task.Factory.StartNew(() => {
                for (int i = 0; i < textBoxes.GetLength(0); i++)
                {
                    for (int j = 0; j < textBoxes.GetLength(1); j++)
                    {

                        Dispatcher.Invoke(() => textBoxes[i, j].Opacity = 1);

                    }
                }
            });
        }
    }
}
