namespace ProxySurrogate
{
    class Surrogate : IHuman
    {
        IHuman @operator;
        public Surrogate(IHuman @operator)
        {
            this.@operator = @operator;
        }
        public void Request()
        {
            @operator.Request();
        }
    }
}
