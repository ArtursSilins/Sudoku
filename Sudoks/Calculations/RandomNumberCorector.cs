using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoks
{
    public class RandomNumberCorector
    {

        public void AddNumbersHorizontal(int row, int column, int num, ref List<NumberCorectorValueTypes> numberCorectorsList)
        {
            if (!numberCorectorsList.Exists(x => x.Row == row && x.Column == column && x.Num == num))
            {
                int counter = 0;
                while (counter < 3)
                {
                    counter++;
                    numberCorectorsList.Add(new NumberCorectorValueTypes(row, counter, num));
                }
            }
                        
        }
        public void AddNumbersVertical(int row, int column, int num, ref List<NumberCorectorValueTypes> NumberCorectorsList)
        {
            if (!NumberCorectorsList.Exists(x => x.Row == row && x.Column == column && x.Num == num))
            {
                int counter = 0;
                while (counter < 3)
                {
                    counter++;
                    NumberCorectorsList.Add(new NumberCorectorValueTypes(counter, column, num));
                }
            }
            
        }
        public void AddNumbersSquare(int row, int column, int num, ref List<NumberCorectorValueTypes> numberCorectorsList)
        {         
            if(!numberCorectorsList.Exists(x=>x.Row == row && x.Column == column && x.Num == num))
                numberCorectorsList.Add(new NumberCorectorValueTypes(row, column, num));
        }
        public void RemoveSquareNumbers(ref List<NumberCorectorValueTypes> numberCorectorsList)
        {
            numberCorectorsList.RemoveAll(x => x.Column == 666);
        }
        public void GetRandomNumlist(int row, int column, int num, List<int> randomHolder, List<NumberCorectorValueTypes> numberCorectorsList, ref List<int> randomHolderForIndex)
        {

            foreach (var item in numberCorectorsList)
            {
                if( item.Row == row && item.Column == column && item.Num == num )
                {
                    randomHolderForIndex.Remove(num);
                }
                if (item.Row == 666 && item.Column == 666 && item.Num == num)
                {
                    randomHolderForIndex.Remove(num);
                }
                                
            }

        }
        public void DeleteAddedNumbers(int num, ref List<NumberCorectorValueTypes> numberCorectorsList)
        {
            foreach (var item in numberCorectorsList)
            {
                numberCorectorsList.RemoveAll(x => x.Num == num);
            }
        }
        public bool TotalImposibleFromHolderList(int num, List<NumberCorectorValueTypes> numberCorectorsList)
        {
            int match = 0;
            bool numberImposible = false;
            if (numberCorectorsList.Exists(x => x.Row == 666 && x.Column == 666 && x.Num == num)) return numberImposible = true;

            foreach (var item in numberCorectorsList)
            {
                if (num == item.Num && 1 == item.Row && 1 == item.Column) match++;
                if (num == item.Num && 2 == item.Row && 1 == item.Column) match++;
                if (num == item.Num && 3 == item.Row && 1 == item.Column) match++;

                if (num == item.Num && 1 == item.Row && 2 == item.Column) match ++;
                if (num == item.Num && 2 == item.Row && 2 == item.Column) match ++;
                if (num == item.Num && 3 == item.Row && 2 == item.Column) match ++;

                if (num == item.Num && 1 == item.Row && 3 == item.Column) match ++;
                if (num == item.Num && 2 == item.Row && 3 == item.Column) match ++;
                if (num == item.Num && 3 == item.Row && 3 == item.Column) match ++;
            }

            if (match == 9)
            {              
                return numberImposible = true;
            }
        
            match = 0;

            foreach (var item in numberCorectorsList)
            {
                if (num == item.Num && 1 == item.Row && 1 == item.Column) match++;
                if (num == item.Num && 1 == item.Row && 2 == item.Column) match++;
                if (num == item.Num && 1 == item.Row && 3 == item.Column) match++;

                if (num == item.Num && 2 == item.Row && 1 == item.Column) match ++;
                if (num == item.Num && 2 == item.Row && 2 == item.Column) match ++;
                if (num == item.Num && 2 == item.Row && 3 == item.Column) match ++;

                if (num == item.Num && 3 == item.Row && 1 == item.Column) match ++;
                if (num == item.Num && 3 == item.Row && 2 == item.Column) match ++;
                if (num == item.Num && 3 == item.Row && 3 == item.Column) match ++;
            }

            if (match == 9)
            {              
                return numberImposible = true;
            }
          
            return numberImposible;
        }

    }
}
