using System;

namespace SortingLibrary
{
    public static class Quick
    {
        static void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }

        static public void QuickSort(int[] items)
        {
            quicksort(items, 0, items.Length - 1);
        }

        static private void quicksort(int[] items, int left, int right)
        {
            Random _pivotRng = new Random();

            if (left < right)
            {
                int pivotIndex = _pivotRng.Next(left, right);

                int newPivot = partition(items, left, right, pivotIndex);
                quicksort(items, left, newPivot - 1);
                quicksort(items, newPivot + 1, right);
            }
        }

        static private int partition(int[] items, int left, int right, int pivotIndex)
        {
            int pivotValue = items[pivotIndex];

            Swap(items, pivotIndex, right);

            int storeIndex = left;

            for (int i = left; i < right; i++)
            {
                if (items[i].CompareTo(pivotValue) < 0)
                {
                    Swap(items, i, storeIndex);
                    storeIndex += 1;
                }
            }

            Swap(items, storeIndex, right);
            return storeIndex;
        }
    }
}
