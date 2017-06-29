namespace AdapterClass
{
    class Program
    {
        static void Main(string[] args)
        {
            IAdapte adapter = new Adapter();
            adapter.Request();
        }
    }
}
