<p align="center"><img src="https://dilrukperera.files.wordpress.com/2012/08/normalfac.jpg"></p>


### Discussion :open_hands:


Factory Method is to creating objects as Template Method is to implementing an algorithm. A superclass specifies all standard and generic behavior (using pure virtual "placeholders" for creation steps), and then delegates the creation details to subclasses that are supplied by the client.

Factory Method makes a design more customizable and only a little more complicated. Other design patterns require new classes, whereas Factory Method only requires a new operation.

People often use Factory Method as the standard way to create objects; but it isn't necessary if: the class that's instantiated never changes, or instantiation takes place in an operation that subclasses can easily override (such as an initialization operation).

Factory Method is similar to Abstract Factory but without the emphasis on families.

Factory Methods are routinely specified by an architectural framework, and then implemented by the user of the framework.

### Structure :foggy:

The implementation of Factory Method discussed in the Gang of Four (below) largely overlaps with that of Abstract Factory. For that reason, the presentation in this chapter focuses on the approach that has become popular since.
<p align="center"><img src="https://sourcemaking.com/files/v2/content/patterns/Factory_Method.svg"></p>

An increasingly popular definition of factory method is: a static method of a class that returns an object of that class' type. But unlike a constructor, the actual object it returns might be an instance of a subclass. Unlike a constructor, an existing object might be reused, instead of a new object created. Unlike a constructor, factory methods can have different and more descriptive names (e.g. Color.make_RGB_color(float red, float green, float blue) and Color.make_HSB_color(float hue, float saturation, float brightness)

<p align="center"><img src="https://sourcemaking.com/files/v2/content/patterns/Factory_Method_1.svg"></p>


The client is totally decoupled from the implementation details of derived classes. Polymorphic creation is now possible.

<p align="center"><img src="https://sourcemaking.com/files/v2/content/patterns/Factory_Method__.svg"></p>

### Example :squirrel:

The Factory Method defines an interface for creating objects, but lets subclasses decide which classes to instantiate. Injection molding presses demonstrate this pattern. Manufacturers of plastic toys process plastic molding powder, and inject the plastic into molds of the desired shapes. The class of toy (car, action figure, etc.) is determined by the mold.
<p align="center"><img src="https://sourcemaking.com/files/v2/content/patterns/Factory_Method_example1.svg"></p>


* Implementation code <a href="https://github.com/VanHakobyan/DesignPatterns/tree/master/FactoryMethod/FactoryMethod">her</a> :octocat:
