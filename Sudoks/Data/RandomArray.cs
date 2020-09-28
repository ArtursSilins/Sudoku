using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoks
{
    public class RandomArray
    {
        Random random = new Random();

        public int[] randomArray(int level)
        {
            List<int> expiredNum = new List<int>();

            int num = 0;

            int[] randomArrayNumbers = new int[] {0,1,2,3,4,5,6,7,8,10,11,12,13,14,15,16,17,18,20,
                21,22,23,24,25,26,27,28,30,31,32,33,34,35,36,37,38,40,41,42,43,44,45,46,47,48,50,
                51,52,53,54,55,56,57,58,60,61,62,63,64,65,66,67,68,70,71,72,73,74,75,76,77,78,80,81,82,83,84,85,86,87,88};

            int[] randomArray = new int[level];

            for (int i = 0; i < randomArray.Length; i++)
            {
                num = random.Next(0, 81);
                randomArray[i] = randomArrayNumbers[num];

                while (expiredNum.Contains(num))
                {

                    num = random.Next(0, 81);

                    randomArray[i] = randomArrayNumbers[num];

                }
                expiredNum.Add(num);

            }
            return randomArray;

        }
       
    }
}
