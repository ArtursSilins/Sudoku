using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Sudoks
{
    static class RGBContainer
    {
        public static SolidColorBrush RGB(int index)
        {

            int[,] bruchHolder = new int[,] { { 135,195,144 }, { 141,198,149 }, { 146,201,154 }, { 152,203,159 }, { 157,206,164 },
                { 163,209,170 }, { 168,212,175 }, { 174,214,180 }, { 179,217,185 }, { 185,220,190 }, { 191,223,195 }, { 196,226,200 },
                { 202,228,205 }, { 207,231,210 }, { 213,234,216 }, { 218,237,221 }, { 224,239,226 }, { 229,242,231 }, { 235,245,236 }};


            var brush = new SolidColorBrush(Color.FromArgb(255, (byte)0, (byte)0, (byte)0));

            for (int i = 0; i < bruchHolder.GetLongLength(0); i++)
            {
                for (int j = 0; j < bruchHolder.GetLongLength(0); j++)
                {
                    if(i == index)
                    {
                        return brush = new SolidColorBrush(Color.FromArgb(255, (byte)bruchHolder[i, 0], (byte)bruchHolder[i, 1], (byte)bruchHolder[i, 2]));

                    }
                }
            }
            return brush;
        }
    }
}
