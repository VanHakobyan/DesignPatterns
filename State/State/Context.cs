namespace State
{
    internal class Context
    {
        public State State { get; set; }

        public Context(State State)
        {
            this.State = State;
        }

        internal void Request()
        {
            this.State.Handle(this);
        }
    }
}