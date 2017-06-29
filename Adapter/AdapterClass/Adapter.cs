namespace AdapterClass
{
    class Adapter : SpecificAdapter, IAdapte
    {
        public void Request()
        {
            SpecificRequest();
        }
    }
}
