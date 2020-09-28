using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sudoks.Animations
{
    public class Menu:MainWindow
    {
        public void MenuHide(Grid SudokuGrid, Panel panel, Canvas menuCanvas, double top)
        {

            Canvas.SetTop(panel, top);
            Canvas.SetLeft(panel, 0);
            Dispatcher.Invoke(() => SudokuGrid.Children.Remove(panel));
            Dispatcher.Invoke(() => menuCanvas.Children.Remove(panel));
            Dispatcher.Invoke(() => menuCanvas.Children.Add(panel));

        }
      
    }
}
