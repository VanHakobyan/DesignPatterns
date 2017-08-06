namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ConctreteContextA());

            context.Request();//Go to state B
            context.Request();//Go to state A
            context.Request();//Go to state B
            context.Request();//Go to state A

        }
    }
}
