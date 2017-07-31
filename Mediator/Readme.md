<p align="center"><img src="https://i.ytimg.com/vi/jWF6dvSr_Pk/hqdefault.jpg"></p><br>

The Mediator Design Pattern allows you to decouple the direct communication between objects by introducing a middle object, the mediator, that facilitates the communication between the objects. Imagine you have a system where numerous objects communicate with each other by holding the reference to other objects. As the number of object grows and the references to other objects increases the system becomes hard to maintain. The mediator pattern is designed to solve this problem.

The mediator is the communication center for the objects. When an object needs to communicate to another object, it does not call the other object directly. Instead, it calls the mediator object whose main duty is to route the messages to the destination object. It allows the developers not having to manage the links between the objects.

Let's look at the UML of the mediator pattern first, then we will look at some code to see how it works. Below is the UML of the Mediator Design Pattern:

<p align="center"><img src="http://www.devlake.com/design-patterns/mediator/mediator.PNG"></p><br>

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
### Other source code <a href="https://github.com/VanHakobyan/DesignPatterns/edit/master/Mediator/MediatorFood">her</a>
