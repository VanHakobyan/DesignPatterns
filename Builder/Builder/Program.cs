namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Pattern.Builder.AbstractBuilder builder = new Pattern.Builder.Builder();
            Pattern.Foreman foreman = new Pattern.Foreman();
            foreman.ConstructHouse();

            House.House house = builder.GetResulit();
        }
    }
}
