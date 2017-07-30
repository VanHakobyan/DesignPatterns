```C#

abstract class Colleague
{
  protected Mediator mediator;
  public Colleague(Mediator mediator)
  {
      this.mediator = mediator;
  }
}

class ConcreteColleague1 : Colleague
{
  public ConcreteColleague1(Mediator mediator)
  : base(mediator)
  {
  }
  public void Send(string message)
  {
      mediator.Send(message, this);
  }
  public void Notify(string message)
  {
      Console.WriteLine(message);
  }
}

class ConcreteColleague2 : Colleague
{
  public ConcreteColleague2(Mediator mediator)
  : base(mediator)
  {
  }
  public void Send(string message)
  {
      mediator.Send(message, this);
  }
  public void Notify(string message)
  {
      Console.WriteLine(message);
  }
}
static void Main()
{
    var mediator = new ConcreteMediator();
    var colleague1 = new ConcreteColleague1(mediator);
    var colleague2 = new ConcreteColleague2(mediator);
    mediator.Colleague1 = colleague1;
    mediator.Colleague2 = colleague2;
    colleague1.Send("Message 1");
    colleague2.Send("Message 2");
}
```
