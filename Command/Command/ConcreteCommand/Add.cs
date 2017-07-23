namespace Command.ConcreteCommand
{
    class Add : AbstractCommand
    {
        public Add(ArithmeticUnit aUnit,int operand)
        {
            this.operand = operand;
            this.aUnit = aUnit;
        }
        public override void Execute()
        {
            aUnit.Run('+', operand);
        }

        public override void UnExecute()
        {
            aUnit.Run('-', operand);
        }
    }
}
