namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractHandler handler1 = new ConcreteHandler1();
            AbstractHandler handler2 = new ConcreteHandler2();
            AbstractHandler handler3 = new ConcreteHandler3();

            handler1.Succsesor = handler2;//1->2
            handler2.Succsesor = handler3;//2->3
                                          //3-> ...
            handler1.RequestHandler(3);   // request for handler3 // tree  
        }
    }
}
