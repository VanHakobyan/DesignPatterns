namespace Facade
{
    class Facade
    {
        SubSystemA subSystemA = new SubSystemA();
        SubSystemB subSystemB = new SubSystemB();
        SubSystemC subSystemC = new SubSystemC();

        public void OperacionAB()
        {
            subSystemA.OperacionA();
            subSystemB.OperacionB();
        }
        public void OperacionBC()
        {
            subSystemB.OperacionB();
            subSystemC.OperacionC();
        }
        public void OperacionAC()
        {
            subSystemA.OperacionA();
            subSystemC.OperacionC();
        }
        public void OperacionABC()
        {
            subSystemA.OperacionA();
            subSystemB.OperacionB();
            subSystemC.OperacionC();
        }
    }
}
