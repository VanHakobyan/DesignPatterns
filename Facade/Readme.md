<p align="center"><img src="http://yuml.me/diagram/scruffy;dir:LR;/class/[Client]depends-.-%3E[Facade],%20[Facade]-*%3E[InternalC],%20[Facade]-%3E[InternalB],%20[Facade]-.-%3E[InternalA]"></p>  

Facade pattern hides the complexities of the system and provides an interface to the client using which the client can access the system. This type of design pattern comes under structural pattern as this pattern adds an interface to existing system to hide its complexities.

This pattern involves a single class which provides simplified methods required by client and delegates calls to methods of existing system classes.

### Implementation :blue_car:

* :one: First Sub System 

```C#

class SubSystemA
{
    public void OperacionA()
    {
        Console.WriteLine("Operacion A");
    }
}

```
* :two: Second Sub System

```C#

class SubSystemB
{
    public void OperacionB()
    {
        Console.WriteLine("Operacion B");
    }
}

```
* :three: Third Sub System 

```C#

class SubSystemC
{
    public void OperacionC()
    {
        Console.WriteLine("Operacion C");
    }
}

```
