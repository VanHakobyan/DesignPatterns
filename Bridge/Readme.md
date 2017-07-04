<p align="center"><img src="http://proswift.ru/wp-content/uploads/2016/07/Bridge_example-2x.png"></p>

<h3 id="participants-scroll">Participants</h3>
<br>
<p>  &nbsp;&nbsp;&nbsp;&nbsp;The classes and objects participating in this pattern are:</p>
<ul>
			<li><font color="#aa0000"><b>Abstraction </b></font>&nbsp;&nbsp;<font color="#007733"><b>(BusinessObject)</b></font>
			<ul>
			<li>defines the abstraction's interface. 
			</li><li>maintains a reference to an object of type Implementor. </li></ul>
			</li><li><font color="#aa0000"><b>RefinedAbstraction </b></font>&nbsp;&nbsp;<font color="#007733"><b>(CustomersBusinessObject)</b></font>
			<ul>
			<li>extends the interface defined by Abstraction. </li></ul>
			</li><li><font color="#aa0000"><b>Implementor </b></font>&nbsp;&nbsp;<font color="#007733"><b>(DataObject)</b></font>
			<ul>
			<li>defines the interface for implementation classes. This interface doesn't 
			have to correspond exactly to Abstraction's interface; in fact the two interfaces 
			can be quite different. Typically the Implementation interface provides only 
			primitive operations, and Abstraction defines higher-level operations based on 
			these primitives. </li></ul>
			</li><li><font color="#aa0000"><b>ConcreteImplementor </b></font>&nbsp;&nbsp;<font color="#007733"><b>(CustomersDataObject)</b></font>
			<ul>
			<li>implements the Implementor interface 
			and defines its concrete implementation.</li> 
			</ul></li>
			</ul>
<hr><br>

<h3>Structural code in C#</h3>
<br>
<p>This <font color="#bb0000">structural</font> code demonstrates the Bridge pattern which separates (decouples) the interface from its implementation.  The implementation can evolve without changing clients	which use the abstraction of the object.</p>
<br>

``` C#

using System;
 
namespace DoFactory.GangOfFour.Bridge.Structural
{
  /// <summary>
  /// MainApp startup class for Structural
  /// Bridge Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      Abstraction ab = new RefinedAbstraction();
 
      // Set implementation and call
      ab.Implementor = new ConcreteImplementorA();
      ab.Operation();
 
      // Change implemention and call
      ab.Implementor = new ConcreteImplementorB();
      ab.Operation();
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'Abstraction' class
  /// </summary>
  class Abstraction
  {
    protected Implementor implementor;
 
    // Property
    public Implementor Implementor
    {
      set { implementor = value; }
    }
 
    public virtual void Operation()
    {
      implementor.Operation();
    }
  }
 
  /// <summary>
  /// The 'Implementor' abstract class
  /// </summary>
  abstract class Implementor
  {
    public abstract void Operation();
  }
 
  /// <summary>
  /// The 'RefinedAbstraction' class
  /// </summary>
  class RefinedAbstraction : Abstraction
  {
    public override void Operation()
    {
      implementor.Operation();
    }
  }
 
  /// <summary>
  /// The 'ConcreteImplementorA' class
  /// </summary>
  class ConcreteImplementorA : Implementor
  {
    public override void Operation()
    {
      Console.WriteLine("ConcreteImplementorA Operation");
    }
  }
 
  /// <summary>
  /// The 'ConcreteImplementorB' class
  /// </summary>
  class ConcreteImplementorB : Implementor
  {
    public override void Operation()
    {
      Console.WriteLine("ConcreteImplementorB Operation");
    }
  }
}
 
 
```

#### Output

* ConcreteImplementorA Operation
* ConcreteImplementorB Operation
