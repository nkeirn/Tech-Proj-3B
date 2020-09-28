using System;

namespace Tech_Proj_3B
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lets automatically populate an array with integers.");


            {
                int[] array = new int[25];
                array[0] = 1;
                array[1] = 2;
                array[2] = 3;
                array[3] = 4;
                array[4] = 5;
                array[5] = 6;
                array[6] = 7;
                array[7] = 8;
                array[8] = 9;
                array[9] = 10;
                array[10] = 11;
                array[11] = 12;
                array[12] = 13;
                array[13] = 14;
                array[14] = 15;
                array[15] = 16;
                array[16] = 17;
                array[17] = 18;
                array[18] = 19;
                array[19] = 20;
                array[20] = 21;
                array[21] = 22;
                array[22] = 23;
                array[23] = 24;
                array[24] = 25;

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);

                }

                }
        }
    }
}
