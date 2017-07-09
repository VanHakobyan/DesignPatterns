<p align= "center"><img src="http://www.dofactory.com/images/diagrams/net/flyweight.gif"></p>
<br>
<ul>
					<li><font color="#aa0000"><b>Flyweight </b></font>&nbsp;&nbsp;<font color="#007733"><b>(Character)</b></font>
					<ul>
					<li>declares an interface through which flyweights can receive and act on 
					extrinsic state. </li></ul>
					</li><li><font color="#aa0000"><b>ConcreteFlyweight </b></font>&nbsp;&nbsp;<font color="#007733"><b>(CharacterA, CharacterB, ..., CharacterZ)</b></font>
					<ul>
					<li>implements the Flyweight interface and adds storage for intrinsic state, if 
					any. A ConcreteFlyweight object must be sharable. Any state it stores must be 
					intrinsic, that is, it must be independent of the ConcreteFlyweight object's 
					context. </li></ul>
					</li><li><font color="#aa0000"><b>UnsharedConcreteFlyweight </b></font>&nbsp;&nbsp;<font color="#007733"><b>( not used )</b></font>
					<ul>
					<li>not all Flyweight subclasses need to be shared. The Flyweight interface 
					<em>enables</em> sharing, but it doesn't enforce it. It is common for 
					UnsharedConcreteFlyweight objects to have ConcreteFlyweight objects as children 
					at some level in the flyweight object structure (as the Row and Column classes 
					have). </li></ul>
					</li><li><font color="#aa0000"><b>FlyweightFactory </b></font>&nbsp;&nbsp;<font color="#007733"><b>(CharacterFactory)</b></font>
					<ul>
					<li>creates and manages flyweight objects 
					</li><li>ensures that flyweight are shared properly. When a client requests a 
					flyweight, the FlyweightFactory objects assets an existing instance or creates 
					one, if none exists. </li></ul>
					</li><li><font color="#aa0000"><b>Client </b></font>&nbsp;&nbsp;<font color="#007733"><b>(FlyweightApp)</b></font>
					<ul>
					<li>maintains a reference to flyweight(s). 
					</li><li>computes or stores the extrinsic state of flyweight(s). 
					</li></ul></li></ul>
