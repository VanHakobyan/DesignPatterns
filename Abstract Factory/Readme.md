<p align="center"><img src="https://image.slidesharecdn.com/abstract-factory-pattern-150524162103-lva1-app6891/95/abstract-factory-pattern-example-implementation-in-java-17-638.jpg?cb=1432484689"></p></br>

The abstract factory pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes.In normal usage, the client software creates a concrete implementation of the abstract factory and then uses the generic interface of the factory to create the concrete objects that are part of the theme. The client doesn't know (or care) which concrete objects it gets from each of these internal factories, since it uses only the generic interfaces of their products. This pattern separates the details of implementation of a set of objects from their general usage and relies on object composition, as object creation is implemented in methods exposed in the factory interface.


### C# example


```c#
using System;
 
namespace DoFactory.GangOfFour.Abstract.Structural
{
  /// <summary>
  /// MainApp startup class for Structural
  /// Abstract Factory Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    public static void Main()
    {
      // Abstract factory #1
      AbstractFactory factory1 = new ConcreteFactory1();
      Client client1 = new Client(factory1);
      client1.Run();
 
      // Abstract factory #2
      AbstractFactory factory2 = new ConcreteFactory2();
      Client client2 = new Client(factory2);
      client2.Run();
 
      // Wait for user input
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'AbstractFactory' abstract class
  /// </summary>
  abstract class AbstractFactory
  {
    public abstract AbstractProductA CreateProductA();
    public abstract AbstractProductB CreateProductB();
  }
 
 
  /// <summary>
  /// The 'ConcreteFactory1' class
  /// </summary>
  class ConcreteFactory1 : AbstractFactory
  {
    public override AbstractProductA CreateProductA()
    {
      return new ProductA1();
    }
    public override AbstractProductB CreateProductB()
    {
      return new ProductB1();
    }
  }
 
  /// <summary>
  /// The 'ConcreteFactory2' class
  /// </summary>
  class ConcreteFactory2 : AbstractFactory
  {
    public override AbstractProductA CreateProductA()
    {
      return new ProductA2();
    }
    public override AbstractProductB CreateProductB()
    {
      return new ProductB2();
    }
  }
 
  /// <summary>
  /// The 'AbstractProductA' abstract class
  /// </summary>
  abstract class AbstractProductA
  {
  }
 
  /// <summary>
  /// The 'AbstractProductB' abstract class
  /// </summary>
  abstract class AbstractProductB
  {
    public abstract void Interact(AbstractProductA a);
  }
 
 
  /// <summary>
  /// The 'ProductA1' class
  /// </summary>
  class ProductA1 : AbstractProductA
  {
  }
 
  /// <summary>
  /// The 'ProductB1' class
  /// </summary>
  class ProductB1 : AbstractProductB
  {
    public override void Interact(AbstractProductA a)
    {
      Console.WriteLine(this.GetType().Name +
        " interacts with " + a.GetType().Name);
    }
  }
 
  /// <summary>
  /// The 'ProductA2' class
  /// </summary>
  class ProductA2 : AbstractProductA
  {
  }
 
  /// <summary>
  /// The 'ProductB2' class
  /// </summary>
  class ProductB2 : AbstractProductB
  {
    public override void Interact(AbstractProductA a)
    {
      Console.WriteLine(this.GetType().Name +
        " interacts with " + a.GetType().Name);
    }
  }
 
  /// <summary>
  /// The 'Client' class. Interaction environment for the products.
  /// </summary>
  class Client
  {
    private AbstractProductA _abstractProductA;
    private AbstractProductB _abstractProductB;
 
    // Constructor
    public Client(AbstractFactory factory)
    {
      _abstractProductB = factory.CreateProductB();
      _abstractProductA = factory.CreateProductA();
    }
 
    public void Run()
    {
      _abstractProductB.Interact(_abstractProductA);
    }
  }
}

```
