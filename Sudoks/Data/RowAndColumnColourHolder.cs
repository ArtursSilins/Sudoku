using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Sudoks
{
    public class RowAndColumnColourHolder:MainWindow
    {
        private Brush[] Holder { get; set; }
        private Brush[] Holder2 { get; set; }

        public void AddColumn(TextBox[,] textBoxes, int column)
        {
            Holder = new Brush[9];
            int counter = 0;
            while (counter <9)
            {
                if (Dispatcher.Invoke(() => textBoxes[counter, column].Background == Brushes.SeaGreen))
                    Dispatcher.Invoke(() => Holder[counter] = Brushes.SeaGreen);
                else
                    Dispatcher.Invoke(() => Holder[counter] = Brushes.GhostWhite);

                counter++;
            }

        }
        public Brush[] GetColumn()
        {
            return Holder;
        }
        public void AddRow(TextBox[,] textBoxes, int row)
        {
            Holder2 = new Brush[9];
            int counter = 0;
            while (counter < 9)
            {
                if (Dispatcher.Invoke(() => textBoxes[row, counter].Background == Brushes.SeaGreen))
                    Dispatcher.Invoke(() => Holder2[counter] = Brushes.SeaGreen);
                else
                    Dispatcher.Invoke(() => Holder2[counter] = Brushes.GhostWhite);

                counter++;
            }

        }
        public Brush[] GetRow()
        {
            return Holder2;
        }
    }
}
