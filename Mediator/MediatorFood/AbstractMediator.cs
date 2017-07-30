namespace MediatorFood
{
    public abstract class AbstractMediator
    {
        public abstract void Send(string msg, Colleague colleague);
    }
}