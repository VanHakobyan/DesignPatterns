<p align="center"><img src="http://img.my.csdn.net/uploads/201109/7/0_1315359672962x.gif"></p><br>

### Introduction :droplet:

This article describes what is state pattern, when could we find state pattern useful and how to have a rudimentary implementation of state pattern in C#.

### Background :speech_balloon:

There are times when we find some scenarios in our application when we need to maintain the state of a sub system. This state needs to be changed based on some conditions and/or user actions. One way to keep track of such states is by using the conditional logic in code.

Using conditional logic will get us the desired result but that would result in a code that is less understandable and is harder to maintain. Also, if we need to add more states in the system then that is very difficult and could create problems in existing system too.


```C#

public interface StateBase
{
    void Change(Context context);
}
 
public class StateA : StateBase
{
    public void Change(Context context)
    {
        //Change state of context from A to B.
        context.State = new StateB();
        Console.WriteLine("Change state from A to B.");
    }
}
 
public class StateB : StateBase
{
    public void Change(Context context)
    {
        //Change state of context from B to C.
        context.State = new StateC();
        Console.WriteLine("Change state from B to C.");
    }
}
 
public class StateC : StateBase
{
    public void Change(Context context)
    {
        //Change state of context from C to A.
        context.State = new StateA();
        Console.WriteLine("Change state from C to A.");
    }
}

//Client Code

public class Context
{
    public Context(StateBase state)
    {
        State = state;
        Console.WriteLine("Create object of context class with initial State.");
    }
 
    public StateBase State { get; set; }
 
    /// <summary>
    /// State change request
    /// </summary>
    public void Request()
    {
        State.Change(this);
    }
}
 
//Sample code and output
 
static void Main(string[] args)
{
    // create Context object and suplied current state or initial state (state A).
    Context context = new Context(new StateA());
 
    //Change state request from A to B.
    context.Request();
 
    //Change state request from B to C.
    context.Request();
 
    //Change state request from C to A.
    context.Request();
}
```
<img src="http://csharpcorner.mindcrackerinc.netdna-cdn.com/UploadFile/ff2f08/state-design-pattern/Images/State-Design-Pattern-3.jpg">

### Conclusion :skull:
 
The State Design Pattern enables us to alter an object's behavior when it's internal state changes. Using the State Design Pattern, it is much easier to track all the possible condition s(or states) and this ensures that our application will have less undefined behavior.  There are also many other ways to implement a State Pattern. The design of an effective State Pattern requires the designer to make a list of possible states and relate each state with each other or we can say define a sequence of states to be changed.

* For more info or code click <a href="https://github.com/VanHakobyan/DesignPatterns/tree/master/State/State">her</a>
