<p align="center"><img src="https://i2.wp.com/s3.amazonaws.com/production-wordpress-assets/blog/wp-content/uploads/2017/04/24100210/builder-method.png?fit=540%2C270&ssl=1"></p>

<br>

The builder pattern is an object creation software design pattern. Unlike the abstract factory pattern and the factory method pattern whose intention is to enable polymorphism, the intention of the builder pattern is to find a solution to the telescoping constructor anti-pattern. The telescoping constructor anti-pattern occurs when the increase of object constructor parameter combination leads to an exponential list of constructors. Instead of using numerous constructors, the builder pattern uses another object, a builder, that receives each initialization parameter step by step and then returns the resulting constructed object at once.
<br>
<p align="center"><img src="https://i.ytimg.com/vi/Okw_XkQaXtE/maxresdefault.jpg"></p>

<br>

### C# Implemetation :notes:

```C#
public class Car
{
    public string Colour { get; }
    public int Wheels { get; }

    public Car(string colour, int wheels)
    {
        Colour = colour;
        Wheels = wheels;
    }
}


public interface ICarBuilder
{
    string Colour { get; set; }
    int Wheels { get; set; }

    Car GetResult();
}


public class CarBuilder : ICarBuilder
{
    public string Colour { get; set; }
    public int Wheels { get; set; }

    public Car GetResult()
    {
        return new Car(Colour, Wheels);
    }
}


public class CarBuildDirector
{
    private readonly CarBuilder _builder;
    public CarBuildDirector()
    {
        _builder = new CarBuilder();
    }

    public Car ConstructRedCar()
    {
        _builder.Colour = "Red";
        _builder.Wheels = 4;
        return _builder.GetResult();
    }
}
```

* [My Another Implementation (Build House)](https://github.com/VanHakobyan/DesignPatterns/tree/master/Builder/Builder):hand:
