namespace Command
{
    abstract class AbstractCommand
    {
        protected ArithmeticUnit aUnit;
        protected int operand;

        public abstract void Execute();
        public abstract void UnExecute();
    }
}
