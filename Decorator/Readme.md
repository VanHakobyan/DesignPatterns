<p align="center"><img src="https://sourcemaking.com/files/v2/content/patterns/Decorator_example-2x.png"></p>
<br>

Decorator pattern allows a user to add new functionality to an existing object without altering its structure. This type of design pattern comes under structural pattern as this pattern acts as a wrapper to existing class.

This pattern creates a decorator class which wraps the original class and provides additional functionality keeping class methods signature intact.

We are demonstrating the use of decorator pattern via following example in which we will decorate a shape with some color without alter shape class.

### Implementation :rat:

* Carlson - Component :baby_chick:

```C#

class Carlson : AbstractCarlson
{
    public override void Operation()
    {
        Console.WriteLine("I am realy Carlson");
    }
}

```

* Abstract Decorator:whale:

```C#
abstract class Decorator : AbstractCarlson
{
    public AbstractCarlson carlson { protected get; set; }

    public override void Operation()
    {
        if (carlson != null)
            carlson.Operation();
    }
}

```

* Оveralls - Conctrete Decorator 1 :snake:
```C#
class Оveralls : Decorator
{
    string state = "Some State";

    public override void Operation()
    {
        base.Operation();
        Console.WriteLine(state);
    }
}
  
```

* Propeller- Conctrete Decorator 2:rabbit2:

```C#

class Propeller:Decorator
{
    void Behavior()
    {
        Console.WriteLine("New Behavior");
    }
    public override void Operation()
    {
        base.Operation();
        Behavior();
    }
}

```

* Building :snail:

```C#
AbstractCarlson carlon = new Carlson();
Decorator overalls = new Оveralls();
Decorator propeller = new Propeller();

overalls.carlson = carlon;
propeller.carlson = overalls;
propeller.Operation();

```
