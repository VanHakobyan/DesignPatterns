namespace Command.ConcreteCommand
{
    class Sub:AbstractCommand
    {
        public Sub(ArithmeticUnit aUnit, int operand)
        {
            this.operand = operand;
            this.aUnit = aUnit;
        }
        public override void Execute()
        {
            aUnit.Run('-', operand);
        }

        public override void UnExecute()
        {
            aUnit.Run('+', operand);
        }
    }
}
