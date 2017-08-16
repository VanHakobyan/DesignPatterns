using System;

namespace Strategy
{
    class InsertionSort : Strategy
    {
        public override void Sort(ref int[] array)
        {
            Console.WriteLine("InsertionSort");

            for (int i = 1; i < array.Length; i++)
            {
                int j = 0;
                int buffer = array[i];

                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j] < buffer)
                        break;

                    array[j + 1] = array[j];
                }

                array[j + 1] = buffer;
            }
        }
    }
}
