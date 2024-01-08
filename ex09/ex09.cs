using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_c_
{
    internal class Program
    {
        public static int[] TwoNumberSum(int[] array, int targetSum)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == targetSum)
                    {
                        return new int[] { array[i], array[j] };
                    }
                }
            }
            return new int[0];
            //Cest siaucune pair est trouvée
        }
        static void Main()
        {
            int[] array = { 3, 5, -4, 8, 11, 1, -1, 6 };
            int targetSum = 10;

            int[] result = TwoNumberSum(array, targetSum);

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
   