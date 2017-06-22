<p align="center"><img src="https://dilrukperera.files.wordpress.com/2012/08/normalfac.jpg"></p>

<br>

<article>
    <div class="breadcrumb">
                                    <a class="home" href="/"><i class="fa fa-home"></i></a>
                                                / <a class="type" href="/design_patterns">Design Patterns</a>
                                                / <a class="type" href="/design_patterns/creational_patterns">Creational patterns</a>
                        </div>
    <h1 class="title smaller"><strong>Factory Method</strong> Design Pattern</h1>
<script type="text/javascript" async="" src="https://cdn.userecho.com/js/widget-1.4.gz.js"></script><script type="text/javascript" async="" src="https://www.google-analytics.com/plugins/ua/ec.js"></script><script type="text/javascript">
    // Shorten examples titles for users.
    var h1 = document.getElementsByTagName("H1")[0];
    var title = h1.innerHTML;
    title = title.replace(/^(.*) Design Pattern in (.*)$/, '<strong>$1</strong> in <em>$2</em>');
    title = title.replace(/^(.*) Design Pattern$/, '<strong>$1</strong> Design Pattern');
    h1.innerHTML = title;

    // Shorten examples titles for users.
    var h1 = document.getElementsByTagName("H1")[0];
    h1.className = h1.className.replace('smaller' , '');
    if (h1.offsetHeight > 80) {
        h1.className += ' smaller';
    }
</script>
        
    <h3>Intent</h3>

<ul>
<li>Define an interface for creating an object, but let subclasses decide
which class to instantiate.  Factory Method lets a class defer
instantiation to subclasses.</li>
<li>Defining a "virtual" constructor.</li>
<li>The <code>new</code> operator considered harmful.</li>
</ul>


<h3>Problem</h3>

<p>A framework needs to standardize the architectural model for a range of
applications, but allow for individual applications to define their own
domain objects and provide for their instantiation.</p>


<h3>Discussion</h3>

<p>Factory Method is to creating objects as Template Method is to
implementing an algorithm.  A superclass specifies all standard and
generic behavior (using pure virtual "placeholders" for creation
steps), and then delegates the creation details to subclasses that are
supplied by the client.</p>

<p>Factory Method makes a design more customizable and only a little more
complicated.  Other design patterns require new classes, whereas
Factory Method only requires a new operation.</p>

<p>People often use Factory Method as the standard way to create objects;
but it isn't necessary if: the class that's instantiated never changes,
or instantiation takes place in an operation that subclasses can easily
override (such as an initialization operation).</p>

<p>Factory Method is similar to Abstract Factory but without the emphasis
on families.</p>

<p>Factory Methods are routinely specified by an architectural framework,
and then implemented by the user of the framework.</p>


<h3>Structure</h3>

<p>The implementation of Factory Method discussed in the Gang of Four
(below) largely overlaps with that of Abstract Factory.  For that
reason, the presentation in this chapter focuses on the approach that has become popular since.</p>


<p class="center">
<img src="/files/v2/content/patterns/Factory_Method.svg" alt="Scheme of Factory Method">
</p>

<p>An increasingly popular definition of factory method is: a
<code>static</code> method of a class that returns an object
of that class' type. But unlike a constructor, the actual
object it returns might be an instance of a subclass.  Unlike
a constructor, an existing object might be reused, instead of
a new object created.  Unlike a constructor, factory methods
can have different and more descriptive names (e.g.
<code>Color.make_RGB_color(float red, float green, float blue)</code> and
<code>Color.make_HSB_color(float hue, float saturation, float brightness)</code></p>


<p class="center">
<img src="/files/v2/content/patterns/Factory_Method_1.svg" alt="Scheme of Factory Method">
</p>

<p>The client is totally decoupled from the implementation details
of derived classes.  Polymorphic creation is now possible.</p>

<p class="center">
<img src="/files/v2/content/patterns/Factory_Method__.svg" alt="Scheme of Factory Method">
</p>

<h3>Example</h3>

<p>The Factory Method defines an interface for creating objects, but lets
subclasses decide which classes to instantiate.  Injection molding
presses demonstrate this pattern.  Manufacturers of plastic toys
process plastic molding powder, and inject the plastic into molds of
the desired shapes.  The class of toy (car, action figure, etc.) is
determined by the mold.</p>

<p class="center">
<img src="/files/v2/content/patterns/Factory_Method_example1.svg" alt="Example of Factory Method">
</p>

<h3>Check list</h3>

<ol>
<li>If you have an inheritance hierarchy that exercises polymorphism,
consider adding a polymorphic creation capability by defining a
<code>static</code> factory method in the base class.</li>
<li>Design the arguments to the factory method.  What qualities
or characteristics are necessary and sufficient to identify the
correct derived class to instantiate?</li>
<li>Consider designing an internal "object pool" that will allow
objects to be reused instead of created from scratch.</li>
<li>Consider making all constructors <code>private</code> or
<code>protected</code>.</li>
</ol>


<h3>Rules of thumb</h3>

<ul>
<li>Abstract Factory classes are often implemented with Factory Methods,
but they can be implemented using Prototype.</li>
<li>Factory Methods are usually called within Template Methods.</li>
<li>Factory Method: creation through inheritance. Prototype: creation
through delegation.</li>
<li>Often, designs start out using Factory Method (less complicated, more
customizable, subclasses proliferate) and evolve toward Abstract
Factory, Prototype, or Builder (more flexible, more complex) as the
designer discovers where more flexibility is needed.</li>
<li>Prototype doesn't require subclassing, but it does require an
Initialize operation. Factory Method requires subclassing, but doesn't
require Initialize.</li>
<li>The advantage of a Factory Method is that it can return the same
instance multiple times, or can return a subclass rather than an
object of that exact type.</li>
<li>Some Factory Method advocates recommend that as a matter of
language design (or failing that, as a matter of style) absolutely
all constructors should be private or protected.  It's no one
else's business whether a class manufactures a new object or
recycles an old one.</li>
<li>The <code>new</code> operator considered harmful.  There is a difference
between requesting an object and creating one.  The <code>new</code>
operator always creates an object, and fails to encapsulate
object creation.  A Factory Method enforces that encapsulation,
and allows an object to be requested without inextricable
coupling to the act of creation.</li>
</ul>

    <div class="banner prom ga-triggered" data-id="DP: Part of the ebook 3d" data-creative-id="standard" data-position="content_bottom">
    <div class="line-guide"><div class="line-guide-helper"></div></div>
    
    <div class="image">
        <div class="image3d-right">
            <a href="/design-patterns-ebook"><img src="/files/v2/landings/DesignPatterns-cover.png" alt="AntiPatterns: The Survival Guide"></a>
        </div>
    </div>

    <div class="caption">
        <h3>Read next</h3>
        <p>This article is taken from our book <b><a href="/design-patterns-ebook">Design Patterns Explained Simply</a></b>.</p>

        <p>All of the design patterns are compiled there. The book is written in clear, simple language that makes it easy to read and understand (just like this article).</p>

        <p>We distribute it in PDF &amp; EPUB formats so you can get it onto your iPad, Kindle, or other portable device immediately after your purchase.</p>

        <div class="p">
            <a href="/design-patterns-ebook" class="btn btn-hg btn-featured"><i class="fa fa-heart"></i> Learn more</a>
        </div>
    </div>
</div>

</article>
