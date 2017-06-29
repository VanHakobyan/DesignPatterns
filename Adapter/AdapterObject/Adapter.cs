namespace AdapterObject
{
    class Adapter : Target
    {
        SpecificAdapter spa = new SpecificAdapter();
        public override void Request()
        {
            spa.SpecificRequest();
        }
    }
}
