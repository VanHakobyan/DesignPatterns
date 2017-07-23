<p align="center"><img src="https://i.gyazo.com/3126182029ec01c3008deebb525dac5d.png"></p>
<p align="center"><img src="https://i.gyazo.com/0b19356c57f91443fa32243e4c17dc14.png"></p>
<br>

This post is about implementing Chain Of Responsibility design pattern, and few possible extensions to the same. If you are new to design patterns, I suggest you start with Practically Applying Design Patterns – Thought Process.

Coming back to Chain of Responsibility - If you have a scenario where you need to chain multiple handlers to handle an incoming request or command, you better use Chain Of Responsibility.

A typical example is your girlfriend requesting you something – If she is requesting/commanding you something like “Do you want to come with me for my best friend’s Bachelorette party?”, you will handle it directly. But if she is requesting/commanding you some thing like “Buy me a Porsche”, you say “Sorry Honey, I don’t have the money. Better you ask your dad for this, I’ll call him for you.” –i.e, you pass the request to the next handler, in this case your girl friend’s father. To sum up, in the above example, your girl friend is the client who is making the request, and you and your future father-in-law are handlers/approvers who handle/approve her requests. If you cannot handle it, you pass that responsibility to the next handler/approver in the chain.

#### Implementation C#

My Implemetation <a href="https://github.com/VanHakobyan/DesignPatterns/tree/master/Chain%20of%20Responsibility/ChainOfResponsibility">Her</a>
