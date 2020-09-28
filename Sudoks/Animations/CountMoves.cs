using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sudoks.Animations
{
    public class CountMoves : MainWindow
    {

        public void Animate(Label label, int labelText)
        {


            new Thread(() =>
            {
                string text = labelText.ToString();
                Dispatcher.Invoke(() => label.Content = text);

                double num = 2.6;
                int count = 0;
                while (count < 6)
                {
                    Dispatcher.Invoke(() => label.FontSize += num);
                    Thread.Sleep(30);
                    count++;
                }
                count = 0;
                while (count < 6)
                {
                    Dispatcher.Invoke(() => label.FontSize -= num);
                    Thread.Sleep(30);
                    count++;
                }

            }).Start();
        }
    }
}
