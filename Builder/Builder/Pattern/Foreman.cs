namespace Builder.Pattern
{
    class Foreman
    {
        Builder.Builder builder = new Builder.Builder();
        public void ConstructHouse()
        {
            builder.BuildBasement();
            builder.BuildStorey();
            builder.BuildRoof();
        }
    }
}
