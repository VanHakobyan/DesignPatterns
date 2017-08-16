namespace SortingLibrary
{
    public static class Bubble
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

        public static void BubbleSort(ref int[] items)
        {
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 1; i < items.Length; i++)
                {
                    if (items[i - 1].CompareTo(items[i]) > 0)
                    {
                        Swap(items, i - 1, i);

                        swapped = true;
                    }
                }
            }

            while (swapped != false);
        }
    }
}
