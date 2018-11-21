using System;

namespace ArraySomma
{
    public class Program
    {
        static void Main(string[] args){ }

        public static bool SumIsInside(int[] array, int x)
        {
            int sum = 0;

            for (int j = array.Length - 1; j > 0; j--)
            {

                for (int i = 0; i < j; i++)
                {
                    if (array[i] >= x)
                    {
                        return false;
                    }

                    sum = array[i] + array[j];

                    if (sum > x)
                        break;

                    if (sum == x)
                        return true;
                }
            }
            return false;
        }
    }
}
