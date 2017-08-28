<p align="center"><img src="https://sourcemaking.com/files/v2/content/patterns/Template_method_example-2x.png"></p>

We will now explain the Template Method Pattern. Like the Strategy Pattern, this pattern is part of the behavioral design patterns. As the name Template suggests, we know a template is a kind of layout available for some kind of process, that we can modify as needed and use it. The case here is similar. We have some sub-tasks to complete a big task, that we can use as per our situation requirements. So technically speaking, we make the sub-tasks as abstract and implement them, as per our needs, in different cases. But one thing remains common;  the overall steps of the entire procedure or the algorithm, in other words first Step 1, then Step 2, then Step 3 and so on, that remain the same in their execution order.

Let's explain this concept in detail now.

### What the Template Method Pattern is

According to the GoF's definition, this pattern:

Defines the skeleton of an algorithm in an operation, deferring some steps to sub-classes. The Template Method lets sub-classes redefine certain steps of an algorithm without changing the algorithm's structure.

### A real-world example

An organization goes to colleges and hires beginner. They have a number of steps defined for the process of hiring in the following order:

* Step 1: Take a test in the first round
* Step 2: Group discussion in the second round
* Step 3: Technical interview
* Step 4: HR interview

They have a common process of group discussions and HR interviews for all the departments, but a different test and technical interview process, depending on whether it is for computer or electronics departments. So we create a hiring process template that can be used by the company for two different departments.

Let's convert the preceding real-world example into technical code.

We will be dividing the system into the following components for our implementation of this pattern:

1. <h3>Abstract Class:</h3> This will be an abstract class, that will have the abstract methods of our technical and test rounds, that will be implemented in the sub-classes based on the departments and the non-abstract methods of the group discussion and the HR rounds.

Most importantly, this class will contain a Non Abstract method that will be calling the abstract methods or any other method defined in this class, to outline the flow of the overall process in a step-wise call to these methods, or you can say, it will contain the sequence of an algorithm.
 
2. <h3>Concrete Classes:</h3> These will be concrete implementations of our abstract steps of the tests and technical interviews, depending on the departments.


For more and my sourse code go <a href="https://github.com/VanHakobyan/DesignPatterns/tree/master/Template/Template">her</a> 
