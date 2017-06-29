<p align="center"><img src="https://javainsider.files.wordpress.com/2012/10/java-singleton-design-pattern.jpg"></p>
<br>

<h5>Singleton pattern is one of the simplest design patterns in Java. This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.

This pattern involves a single class which is responsible to create an object while making sure that only single object gets created. This class provides a way to access its only object which can be accessed directly without need to instantiate the object of the class.</h5>

<h2>Implementation</h2>

<h5>We're going to create a SingleObject class. SingleObject class have its constructor as private and have a static instance of itself.

SingleObject class provides a static method to get its static instance to outside world. SingletonPatternDemo, our demo class will use SingleObject class to get a SingleObject object.</h5>

<p align="center"><img src="https://www.tutorialspoint.com/design_pattern/images/singleton_pattern_uml_diagram.jpg" alt="Singleton Pattern UML Diagram"></p>

```C# 
public sealed class Singleton
{
    private static Singleton instance = null; public String field = "Some value";
    public static Singleton Instance { get { return (instance == null) ? instance = new Singleton() : instance; } }
    public static SurrogateSelector SurrogateSelector
    {
        get
        {
            var selector = new SurrogateSelector(); var singleton = typeof(Singleton); var context = new StreamingContext(StreamingContextStates.All); var surrogate = new SerializationSurrogate();
            selector.AddSurrogate(singleton, context, surrogate); return selector;
        }
    }
    private sealed class SerializationSurrogate : ISerializationSurrogate
    {
        void ISerializationSurrogate.GetObjectData(Object obj, SerializationInfo info, StreamingContext context)
        {
            Singleton singleton = Singleton.Instance;
            info.AddValue("field", singleton.field);
        }
        Object ISerializationSurrogate.SetObjectData(
            Object obj, 
            SerializationInfo info, 
            StreamingContext context, 
            ISurrogateSelector selector
            )
        {
            Singleton singleton = Singleton.Instance;
            singleton.field = info.GetString("field");
            return singleton;

        }
    }
}
```
<h3>My simple implementation in C# <a href="https://github.com/VanHakobyan/DesignPatterns/tree/master/Singleton/SimpleSingleton" >here</a>
</h3>
