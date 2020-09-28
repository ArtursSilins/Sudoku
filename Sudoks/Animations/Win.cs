using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Sudoks.Animations
{
    public class Win:MainWindow
    {
       
        private static Label DrawLabelWin(Grid grid, string text, int font_size, int row, int col)
        {
            // Make the label.

            var properties = typeof(Brushes).GetProperties();
            var property = properties.FirstOrDefault(p => p.Name == "Red");
            var brush = property.GetValue(null, null); // Contains Brushes.Red


            Label label = new Label();
            label.Content = text;
            label.FontSize = font_size;

            label.FontWeight = FontWeights.Black;
            label.Opacity = 0;

            grid.Children.Add(label);

            Grid.SetRow(label, row);    
            Grid.SetColumn(label, col); 
            Grid.SetColumnSpan(label, 3);
            Grid.SetRowSpan(label, 2);

            return label;
        }
        private Label DrawLabelWin(Grid grid, string text, int font_size, int row, int col, int rowSpan, int colSpan)
        {
            // Make the label.

            Label label = new Label();
            label.Content = text;
            label.FontSize = font_size;
            label.Foreground = Brushes.Red;
            label.FontWeight = FontWeights.Black;
            label.Opacity = 0;

            grid.Children.Add(label);

            Grid.SetRow(label, row);    
            Grid.SetColumn(label, col); 
            Grid.SetColumnSpan(label, colSpan);
            Grid.SetRowSpan(label, rowSpan);

            return label;
        }
        public void Animate(int row, int col, int time, TextBox[,] textBoxes, Grid SudokuGrid)
        {
            double counter = 0;

            Task.Run(() =>
            {

                var label = Dispatcher.Invoke(() => DrawLabelWin(SudokuGrid, "Win!", 25, row, col));

                for (int a = 0; a < textBoxes.GetLength(0); a++)
                {

                    for (int b = 0; b < textBoxes.GetLength(1); b++)
                    {

                        Dispatcher.Invoke(() => label.Foreground = Brushes.Red);
                        counter += 0.0009;
                        Dispatcher.Invoke(() => label.Opacity += counter);

                        Thread.Sleep(time);
                        Dispatcher.Invoke(() => label.Foreground = Brushes.Black);
                        Thread.Sleep(time);
                    }
                }

                Dispatcher.Invoke(() => SudokuGrid.Children.Remove(label));


            });
        }
        public void Animate(int fontSize, int rowSpan, int colSpan, int row, int col, int time, TextBox[,] textBoxes, Grid SudokuGrid)
        {
            double counter = 0;
            Task.Run(() =>
            {

                var label = Dispatcher.Invoke(() => DrawLabelWin(SudokuGrid, " Win!", fontSize, row, col, rowSpan, colSpan));

                for (int a = 0; a < textBoxes.GetLength(0); a++)
                {

                    for (int b = 0; b < textBoxes.GetLength(1); b++)
                    {

                        counter += 0.01;
                        Dispatcher.Invoke(() => label.Opacity += counter);

                        Thread.Sleep(time);

                    }
                }

                Dispatcher.Invoke(() => SudokuGrid.Children.Remove(label));

            });

        }
      
    }
}
