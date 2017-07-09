<p align="center"><img src="http://www.vincehuston.org/images/proxy_check.gif"></a>
<br>

In proxy pattern, a class represents functionality of another class. This type of design pattern comes under structural pattern.

In proxy pattern, we create object having original object to interface its functionality to outer world.

### Implementation

```C#

interface IHuman { void Request(); }


class Operator : IHuman
{
    public void Request()
    {
        Console.WriteLine("Operator");
    }
}

//Proxy
class Surrogate : IHuman
{
    IHuman @operator;
    public Surrogate(IHuman @operator)
    {
        this.@operator = @operator;
    }
    public void Request()
    {
        @operator.Request();
    }
}


//Program

class Program
{
    static void Main(string[] args)
    {
        IHuman Bruce = new Operator();
        Surrogate surrogate = new Surrogate(Bruce);
        surrogate.Request();
    }
}

```

Full for implementation <a href="https://github.com/VanHakobyan/DesignPatterns/tree/master/Proxy/ProxySurrogate">here</a>

