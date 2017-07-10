<p align= "center"><img src="http://www.dofactory.com/images/diagrams/net/flyweight.gif"></p>
<br>
<ul>
					<li><font color="#aa0000"><b>Flyweight </b></font>&nbsp;&nbsp;<font color="#007733"><b>(Character)</b></font>
					<ul>
					<li>declares an interface through which flyweights can receive and act on 
					extrinsic state. </li></ul>
					</li><li><font color="#aa0000"><b>ConcreteFlyweight </b></font>&nbsp;&nbsp;<font color="#007733"><b>(CharacterA, CharacterB, ..., CharacterZ)</b></font>
					<ul>
					<li>implements the Flyweight interface and adds storage for intrinsic state, if 
					any. A ConcreteFlyweight object must be sharable. Any state it stores must be 
					intrinsic, that is, it must be independent of the ConcreteFlyweight object's 
					context. </li></ul>
					</li><li><font color="#aa0000"><b>UnsharedConcreteFlyweight </b></font>&nbsp;&nbsp;<font color="#007733"><b>( not used )</b></font>
					<ul>
					<li>not all Flyweight subclasses need to be shared. The Flyweight interface 
					<em>enables</em> sharing, but it doesn't enforce it. It is common for 
					UnsharedConcreteFlyweight objects to have ConcreteFlyweight objects as children 
					at some level in the flyweight object structure (as the Row and Column classes 
					have). </li></ul>
					</li><li><font color="#aa0000"><b>FlyweightFactory </b></font>&nbsp;&nbsp;<font color="#007733"><b>(CharacterFactory)</b></font>
					<ul>
					<li>creates and manages flyweight objects 
					</li><li>ensures that flyweight are shared properly. When a client requests a 
					flyweight, the FlyweightFactory objects assets an existing instance or creates 
					one, if none exists. </li></ul>
					</li><li><font color="#aa0000"><b>Client </b></font>&nbsp;&nbsp;<font color="#007733"><b>(FlyweightApp)</b></font>
					<ul>
					<li>maintains a reference to flyweight(s). 
					</li><li>computes or stores the extrinsic state of flyweight(s). 
					</li></ul></li></ul>


### Structural code in C# :guardsman:

This structural code demonstrates the Flyweight pattern in which a relatively small number of objects is shared many times by different clients.

``` C#
using System;
using System.Collections;
 
namespace DoFactory.GangOfFour.Flyweight.Structural
{
  /// <summary>
  /// MainApp startup class for Structural 
  /// Flyweight Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Arbitrary extrinsic state
      int extrinsicstate = 22;
 
      FlyweightFactory factory = new FlyweightFactory();
 
      // Work with different flyweight instances
      Flyweight fx = factory.GetFlyweight("X");
      fx.Operation(--extrinsicstate);
 
      Flyweight fy = factory.GetFlyweight("Y");
      fy.Operation(--extrinsicstate);
 
      Flyweight fz = factory.GetFlyweight("Z");
      fz.Operation(--extrinsicstate);
 
      UnsharedConcreteFlyweight fu = new
        UnsharedConcreteFlyweight();
 
      fu.Operation(--extrinsicstate);
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  /// <summary>
  /// The 'FlyweightFactory' class
  /// </summary>
  class FlyweightFactory
  {
    private Hashtable flyweights = new Hashtable();
 
    // Constructor
    public FlyweightFactory()
    {
      flyweights.Add("X", new ConcreteFlyweight());
      flyweights.Add("Y", new ConcreteFlyweight());
      flyweights.Add("Z", new ConcreteFlyweight());
    }
 
    public Flyweight GetFlyweight(string key)
    {
      return ((Flyweight)flyweights[key]);
    }
  }
 
  /// <summary>
  /// The 'Flyweight' abstract class
  /// </summary>
  abstract class Flyweight
  {
    public abstract void Operation(int extrinsicstate);
  }
 
  /// <summary>
  /// The 'ConcreteFlyweight' class
  /// </summary>
  class ConcreteFlyweight : Flyweight
  {
    public override void Operation(int extrinsicstate)
    {
      Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
    }
  }
 
  /// <summary>
  /// The 'UnsharedConcreteFlyweight' class
  /// </summary>
  class UnsharedConcreteFlyweight : Flyweight
  {
    public override void Operation(int extrinsicstate)
    {
      Console.WriteLine("UnsharedConcreteFlyweight: " +
        extrinsicstate);
    }
  }
}
 

```

<img src="https://i.gyazo.com/bef574150ce0443896d024d32dc2fa92.png">
<br>

### Another Implementation of Bruce :cop:

Bruce Surrogate implemenation <a href="https://github.com/VanHakobyan/DesignPatterns/tree/master/Flyweight/Flyweight">here</a> :older_man:
