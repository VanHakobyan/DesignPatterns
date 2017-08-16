namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var sort = new SelectionSort();
            var context = new Context(sort);
            context.Sort();
            context.PrintArray();
        }
    }
}
