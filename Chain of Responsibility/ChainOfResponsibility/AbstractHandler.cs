namespace ChainOfResponsibility
{
    abstract class AbstractHandler
    {
        public AbstractHandler Succsesor { get; set; }
        public abstract void RequestHandler(int request);

    }
}
