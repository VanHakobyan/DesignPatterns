namespace Builder.Pattern.Builder
{
    abstract class AbstractBuilder
    {
        public abstract void BuildBasement();
        public abstract void BuildStorey();
        public abstract void BuildRoof();
        public abstract House.House GetResulit();
    }
}
