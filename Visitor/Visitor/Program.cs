namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var village = new Village();
            village.Add(new BoysHouse());
            village.Add(new GirlsHouse());
            village.Accept(new Santa());
        }
    }
}
