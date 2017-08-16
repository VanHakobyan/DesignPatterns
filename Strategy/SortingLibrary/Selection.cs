namespace SortingLibrary
{
    public static class Selection
    {
        static private void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }


        static public void SelectionSort(int[] items)
        {
            int sortedRangeEnd = 0;

            while (sortedRangeEnd < items.Length)
            {
                int nextIndex = FindIndexOfSmallestFromIndex(items, sortedRangeEnd);
                Swap(items, sortedRangeEnd, nextIndex);
                sortedRangeEnd++;
            }
        }


        static private int FindIndexOfSmallestFromIndex(int[] items, int sortedRangeEnd)
        {
            int currentSmallest = items[sortedRangeEnd];
            int currentSmallestIndex = sortedRangeEnd;

            for (int i = sortedRangeEnd + 1; i < items.Length; i++)
            {
                if (currentSmallest.CompareTo(items[i]) > 0)
                {
                    currentSmallest = items[i];
                    currentSmallestIndex = i;
                }
            }

            return currentSmallestIndex;
        }
    }
}
