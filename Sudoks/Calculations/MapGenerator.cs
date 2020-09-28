using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoks
{
    public class MapGenerator
    {
        private List<int> RandomHolder { get; set; }
        public int CountTry { get; set; }
        public int[,] SudokuMapBuilder()
        {
            Start:

            int[,] Map = new int[9, 9];
            int mapCounter = 1;

            List<int[,]> mapHolder = new List<int[,]>();

            RandomNumberCorector randomNumberCorector = new RandomNumberCorector();
            List<NumberCorectorValueTypes> NumberCorectorsList = new List<NumberCorectorValueTypes>();
            RandomNumber randomNumber = new RandomNumber();
            MapContainer mapContainer = new MapContainer();

            int i = 0;
            int indexi = 0;
            int j = 0;
            int indexj = 0;
            int indexjComparer = 3;
            int countSquares = 0;

            int FailFailCount = 0;

            int mapCounter_A = 0;
            int mapCounter_B = 0;

            int countRow = 0;
            int countColumn = 0;
            bool ifStartsNewSquare = false;

            int failCount = 0;
            int numberCheck = 0;

            int countMapCounterAtempts = 0;

            RandomHolder = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (i = indexi; i < Map.GetLength(0); i++)
            {
                countRow++;
               
                for (j = indexj; j < indexjComparer; j++)
                {

                    countColumn++;

                    if (countColumn > 3)
                    {
                        countColumn = 1;
                    }
                    
                    do
                    {
                        
                        numberCheck = randomNumber.Get(countRow, countColumn, randomNumberCorector, NumberCorectorsList, RandomHolder);


                        if (numberCheck == 666 || randomNumberCorector.TotalImposibleFromHolderList(numberCheck, NumberCorectorsList))
                        {
                            ifStartsNewSquare = true;

                            if (mapCounter > mapHolder.Count) mapCounter = 1;
                            
                            failCount++;

                            mapCounter_A = mapCounter;


                            if(mapHolder.Count == 8 && failCount == 1)
                            {
                                FailFailCount++;
                            }
                         
                            if (failCount > 1)
                            {

                                mapCounter++;
                                failCount = 0;
                           }
                         
                            if(FailFailCount == 5 )
                            {
                                mapCounter = 5;
                                mapHolder.RemoveRange(mapHolder.Count - 5, 5);
                                FailFailCount = 0;
                            }
                           
                            mapCounter_B = mapCounter;

                            mapContainer.Get(mapHolder, ref Map, mapCounter);

                            RandomHolder = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                            if(mapCounter_A != mapCounter_B) NumberCorectorsList = new List<NumberCorectorValueTypes>();

                            MapStepBack.SetIndexersToProperPpositions(Map, ref i, ref j, ref indexi, ref indexj, ref indexjComparer, ref countRow, ref countSquares);
                            randomNumberCorector.RemoveSquareNumbers(ref NumberCorectorsList);

                            countColumn = 0;

                            break;
                        }
                        else
                        {
                            Map[i, j] = numberCheck;
                        }
                    } while (NumberChecking.NumberDuplicate(Map, Map[i, j], ref randomNumberCorector, ref NumberCorectorsList, countRow, countColumn, j));


                    if (ifStartsNewSquare == false) RandomHolder.Remove(Map[i, j]);

                    ifStartsNewSquare = false;
                }
 
                if (countRow == 3)
                {
                    
                    countMapCounterAtempts++;
                    NumberCorectorsList = new List<NumberCorectorValueTypes>();

                    CountTry++;
                    if (CountTry > 30)
                    {
                        CountTry = 0;
                        goto Start;
                    }

                    mapContainer.Add(Map, ref mapHolder);
                    mapCounter = 1;
                                                                                                   
                    countSquares++;
                    if (countSquares == 3 && indexi + 3 < Map.GetLength(0))
                    {

                        countSquares = 0;
                        indexi += 3;
                        indexj = 0;
                        indexjComparer = 3;
                        countRow = 0;

                        RandomHolder = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                    }
                    else
                    {
                        RandomHolder = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                        if (i == 5)
                        {
                            i = 2;
                        }
                        else if (i == 8)
                        {
                            i = 5;
                        }
                        else
                        {
                            i = -1;
                        }

                        if (i != 8 && j != 9)
                        {
                            indexjComparer += 3;
                        }
                        else
                        {
                            i = Map.GetLength(0);
                        }

                        indexj += 3;

                        countRow = 0;
                    }

                }
            }
            return Map;
        }

        private class RandomNumber
        {

            Random random = new Random();
            public int Get(int row, int column, RandomNumberCorector randomNumberCorector, List<NumberCorectorValueTypes> numberCorectorList, List<int> randomHolder)
            {
                int randomNum = 0;
                int number = 0;
                int count = 0;

                List<int> randomHolderForIndex = new List<int>();


                for (int j = 0; j < randomHolder.Count; j++)
                {
                    randomHolderForIndex.Add(randomHolder[j]);
                }

                while (randomHolder.Count > count)
                {
                    number = randomHolder[count];
                    randomNumberCorector.GetRandomNumlist(row, column, number, randomHolder, numberCorectorList, ref randomHolderForIndex);
                    count++;
                }

                if (randomHolderForIndex.Count == 0) return randomNum = 666;
                int num = random.Next(0, randomHolderForIndex.Count);

                randomNum = randomHolderForIndex[num];

                return randomNum;
            }
        }

        private class MapContainer:MapGenerator
        {
            public void Add(int[,] map, ref List<int[,]> mapHolder)
            {

                int mapCount = CountFilledIndexes.GetArrayNumberCount(map);
                var mapCoppy = new int[9, 9];

                if (mapHolder.Count == 0)
                {
                    for (int i = 0; i < map.GetLength(0); i++)
                    {
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            mapCoppy[i, j] = map[i, j];
                        }
                    }
                    mapHolder.Add(mapCoppy);
                }
                else
                {
                    int mapHolderItemCount = 0;

                    for (int i = 0; i < mapHolder.Count; i++)
                    {
                        mapHolderItemCount = CountFilledIndexes.GetArrayNumberCount(mapHolder[i]);

                        if (mapCount == mapHolderItemCount)
                        {
                            for (int a = 0; a < map.GetLength(0); a++)
                            {
                                for (int b = 0; b < map.GetLength(1); b++)
                                {
                                    mapCoppy[a, b] = map[a, b];
                                }
                            }

                            mapHolder.Insert(i, mapCoppy);
                            mapHolder.RemoveAt(i + 1);

                            return;
                        }
                    }


                    mapHolderItemCount = CountFilledIndexes.GetArrayNumberCount(mapHolder[mapHolder.Count - 1]);

                    if (mapCount > mapHolderItemCount)
                    {
                        for (int i = 0; i < map.GetLength(0); i++)
                        {
                            for (int j = 0; j < map.GetLength(1); j++)
                            {
                                mapCoppy[i, j] = map[i, j];
                            }
                        }

                        mapHolder.Add(mapCoppy);
                        return;
                    }

                }


            }

            public int[,] Get(List<int[,]> mapHolder, ref int[,] Map, int tryCount)
            {
                int[,] map = new int[9, 9];
                int counter = 0;

                if (mapHolder.Count == 1)
                {

                    foreach (var item in mapHolder)
                    {
                        for (int i = 0; i < item.GetLength(0); i++)
                        {
                            for (int j = 0; j < item.GetLength(1); j++)
                            {
                                Map[i, j] = item[i, j];
                            }
                        }
                    }
                    return map;
                }

                foreach (var item in mapHolder)
                {

                    if (counter == mapHolder.Count - tryCount)
                    {
                        for (int i = 0; i < item.GetLength(0); i++)
                        {
                            for (int j = 0; j < item.GetLength(1); j++)
                            {
                                Map[i, j] = item[i, j];
                            }
                        }
                        return map;
                    }
                    counter++;
                }

                return map;
            }
        }
        private class CountFilledIndexes
        {
            public static int GetArrayNumberCount(int[,] map)
            {
                int count = 0;
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        if (map[i, j] != 0)
                        {
                            count++;
                        }
                    }
                }
                return count;
            }
        }
      
        private class NumberChecking
        {
            public static bool NumberDuplicate(int[,] map, int num, ref RandomNumberCorector randomNumberCorector, ref List<NumberCorectorValueTypes> numberCorectorsList, int countRow, int countColumn, int j)
            {
                bool duplicate = false;

                if (CheckForSquareMach(map, num, ref randomNumberCorector, ref numberCorectorsList)) return duplicate = true;
                if (CheckForHorizontalMach(map, num, ref randomNumberCorector, ref numberCorectorsList, countRow, countColumn)) return duplicate = true;
                if (CheckForVerticalMach(map, num, ref randomNumberCorector, ref numberCorectorsList, countRow, countColumn, j)) return duplicate = true;

                return duplicate;
            }
            private static bool CheckForSquareMach(int[,] map, int num, ref RandomNumberCorector randomNumberCorector, ref List<NumberCorectorValueTypes> numberCorectorsList)
            {
                bool isMatch = false;
                int countMach = 0;

                int i = 0;
                int indexi = 0;
                int j = 0;
                int indexj = 0;
                int indexjComparer = 3;
                int countSquares = 0;
                int countRow = 0;

                for (i = indexi; i < map.GetLength(0); i++)
                {
                    for (j = indexj; j < indexjComparer; j++)
                    {
                        if (num == map[i, j] && num != 0)
                        {
                            countMach++;
                            if (countMach == 2)
                            {
                                randomNumberCorector.AddNumbersSquare(666, 666, num, ref numberCorectorsList);/////
                                isMatch = true;
                                return isMatch;
                            }

                        }

                    }

                    countRow++;
                    if (countRow == 3)
                    {
                        countSquares++;
                        if (countSquares == 3 && indexi + 3 < map.GetLength(0))
                        {
                            countSquares = 0;
                            indexi += 3;
                            indexj = 0;
                            indexjComparer = 3;
                            countRow = 0;

                            countMach = 0;
                        }
                        else
                        {
                            countMach = 0;

                            if (i == 5)
                            {
                                i = 2;
                            }
                            else if (i == 8)
                            {
                                i = 5;
                            }
                            else
                            {
                                i = -1;
                            }

                            if (i != 8 && j != 9)
                            {
                                indexjComparer += 3;
                            }
                            else
                            {
                                i = map.GetLength(0);
                            }

                            indexj += 3;

                            countRow = 0;
                        }

                    }
                }

                return isMatch;
            }
            private static bool CheckForHorizontalMach(int[,] map, int num, ref RandomNumberCorector randomNumberCorector, ref List<NumberCorectorValueTypes> numberCorectorsList, int countRow, int countColumn)
            {
                bool isMatch = false;
                int countMach = 0;

                int i = 0;
                int j = 0;

                for (i = 0; i < map.GetLength(0); i++)
                {

                    for (j = 0; j < map.GetLength(1); j++)
                    {

                        if (num == map[i, j] && num != 0)
                        {
                            countMach++;
                            if (countMach == 2)
                            {
                                randomNumberCorector.AddNumbersHorizontal(countRow, countColumn, num, ref numberCorectorsList);
                                isMatch = true;
                                return isMatch;
                            }
                        }


                    }

                    countMach = 0;
                }

                return isMatch;
            }
            private static bool CheckForVerticalMach(int[,] map, int num, ref RandomNumberCorector randomNumberCorector, ref List<NumberCorectorValueTypes> numberCorectorsList, int countRow, int countColumn, int j)
            {
                bool isMatch = false;
                int countMach = 0;

                int counter = 0;

                while (counter < 9)
                {
                    if (map[counter, j] == num && num != 0)
                    {
                        countMach++;
                        if (countMach == 2)
                        {
                            randomNumberCorector.AddNumbersVertical(countRow, countColumn, num, ref numberCorectorsList);
                            isMatch = true;
                            return isMatch;
                        }
                    }
                    counter++;
                }

                return isMatch;
            }
        }
        private class MapStepBack
        {
            public static void SetIndexersToProperPpositions(int[,] map, ref int i, ref int j, ref int indexi1, ref int indexj1, ref int indexjComparer1, ref int countRow1, ref int countSquares1)
            {

                int a = 0;
                int indexi = 0;
                int b = 0;
                int indexj = 0;
                int indexjComparer = 3;
                int countSquares = 0;
                int countRow = 0;

                for (a = indexi; a < map.GetLength(0); a++)
                {
                    countRow++;
                    for (b = indexj; b < indexjComparer; b++)
                    {
                        if (map[a, b] == 0)
                        {

                            j = b - 1;
                            i = a; indexi1 = indexi; indexj1 = indexj; indexjComparer1 = indexjComparer; countRow1 = countRow; countSquares1 = countSquares;
                            return;
                        }

                    }

                    if (countRow == 3)
                    {
                        countSquares++;
                        if (countSquares == 3 && indexi + 3 < map.GetLength(0))
                        {
                            countSquares = 0;
                            indexi += 3;
                            indexj = 0;
                            indexjComparer = 3;
                            countRow = 0;

                        }
                        else
                        {

                            if (a == 5)
                            {
                                a = 2;
                            }
                            else if (a == 8)
                            {
                                a = 5;
                            }
                            else
                            {
                                a = -1;
                            }

                            if (a != 8 && b != 9)
                            {
                                indexjComparer += 3;
                            }
                            else
                            {
                                a = map.GetLength(0);
                            }

                            indexj += 3;

                            countRow = 0;
                        }

                    }
                }

            }
        }
       
    }
}
