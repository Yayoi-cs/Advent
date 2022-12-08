using System;

namespace Advent
{
    public class multiplication
    {
        public static int Remainder(int array1, int array2, int array3)
        {
            int Array3_d = array1;
            for (int i = 0; i < array2 - 1; i++)
            {
                Array3_d = ((Array3_d % array3) * array1);
            }
            Array3_d = Array3_d % array3;
            return Array3_d;
        }
    }
}
