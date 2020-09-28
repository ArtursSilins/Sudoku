using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoks
{
    public class NumberCorectorValueTypes
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public int Num { get; set; }

        public NumberCorectorValueTypes(int row, int column, int num)
        {
            Row = row;
            Column = column;
            Num = num;
        }
    }
}
