<p align="center"><img src="https://i2.wp.com/s3.amazonaws.com/production-wordpress-assets/blog/wp-content/uploads/2017/04/24100210/builder-method.png?fit=540%2C270&ssl=1"></p>

<br>

The builder pattern is an object creation software design pattern. Unlike the abstract factory pattern and the factory method pattern whose intention is to enable polymorphism, the intention of the builder pattern is to find a solution to the telescoping constructor anti-pattern[citation needed]. The telescoping constructor anti-pattern occurs when the increase of object constructor parameter combination leads to an exponential list of constructors. Instead of using numerous constructors, the builder pattern uses another object, a builder, that receives each initialization parameter step by step and then returns the resulting constructed object at once.
