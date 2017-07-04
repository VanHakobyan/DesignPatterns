<p align="center"><img src="http://proswift.ru/wp-content/uploads/2016/07/Bridge_example-2x.png"></p>

<h3 id="participants-scroll">Participants</h3>
<br>
<p>  &nbsp;&nbsp;&nbsp;&nbsp;The classes and objects participating in this pattern are:</p>
<ul>
			<li><font color="#aa0000"><b>Abstraction </b></font>&nbsp;&nbsp;<font color="#007733"><b>(BusinessObject)</b></font>
			<ul>
			<li>defines the abstraction's interface. 
			</li><li>maintains a reference to an object of type Implementor. </li></ul>
			</li><li><font color="#aa0000"><b>RefinedAbstraction </b></font>&nbsp;&nbsp;<font color="#007733"><b>(CustomersBusinessObject)</b></font>
			<ul>
			<li>extends the interface defined by Abstraction. </li></ul>
			</li><li><font color="#aa0000"><b>Implementor </b></font>&nbsp;&nbsp;<font color="#007733"><b>(DataObject)</b></font>
			<ul>
			<li>defines the interface for implementation classes. This interface doesn't 
			have to correspond exactly to Abstraction's interface; in fact the two interfaces 
			can be quite different. Typically the Implementation interface provides only 
			primitive operations, and Abstraction defines higher-level operations based on 
			these primitives. </li></ul>
			</li><li><font color="#aa0000"><b>ConcreteImplementor </b></font>&nbsp;&nbsp;<font color="#007733"><b>(CustomersDataObject)</b></font>
			<ul>
			<li>implements the Implementor interface 
			and defines its concrete implementation.</li> 
			</ul></li>
			</ul>
