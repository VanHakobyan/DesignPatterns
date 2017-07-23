using System;

namespace Command
{
    class ArithmeticUnit
    {
        public int Register { get; private set; }
        public void Run(char operation, int operand)
        {
            switch (operation)
            {
                case '+':
                    Register += operand;
                    break;
                case '-':
                    Register -= operand;
                    break;
                case '*':
                    Register *= operand;
                    break;
                case '/':
                    Register /= operand;
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
