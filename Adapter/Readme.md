<p align="center"><img class="irc_mi" src="https://obsoletedeveloper.files.wordpress.com/2012/09/hf-adapter.jpg" alt="adapter pattern" width="504" height="281"></p>

<h2>Background</h2>

<p><span style="line-height: 115%; font-size: 12pt"><strong>Adapter pattern</strong> is placed under the category of structural design pattern. “<strong>Adapter</strong>” as the name suggests is the object which lets two mutually incompatible interfaces communicate with each other. But why we want “someone” to adapt to something? You will get an answer if you answer this simple thing- Your laptop charger which you bought in US has flattish pins which easily gets hooked into electrical sockets in US. But when you travel to European countries you may have round holes in the electrical sockets. What do you do then?-Simple buy socket adapters/converters for that.</span> </p>
        
<p><img src="https://www.codeproject.com/KB/architecture/774259/extracted-png-image1.png" width="400" height="177"></p>
<p><span style="line-height: 115%; font-size: 12pt">We use Adapters when incompatible interfaces are involved. Our client object wants to call a method but it is not able to because the interface which our client object can use, is not available with the code which our client object wants to call. Based on what an adapter does the <strong>adapter design pattern</strong> is also called <strong>wrapper pattern</strong>, <strong>translator pattern</strong>. Let’s look at the various participants (objects, interfaces) involved in an adapter pattern.</span></p>
        
<p><img src="https://www.codeproject.com/KB/architecture/774259/extracted-png-image2.png" width="482" height="375"></p>
        
<b>ITarget</b>: This is the interface which is used by the client to achieve functionality.<br>
<b>Adaptee</b>: This is the functionality which the client desires but its interface is not compatible with the client.<br>
<b>Client</b>: This is the class which wants to achieve some functionality by using the adaptee’s code.<br>
<b>Adapter</b>: This is the class which would implement ITarget and would call the Adaptee code which the client wants to call.<br>

<h3>My C# implementation</h3>

* Implementation [AdapterClass](https://github.com/VanHakobyan/DesignPatterns/tree/master/Adapter/AdapterClass)
* Implementation [AdapterObject](https://github.com/VanHakobyan/DesignPatterns/tree/master/Adapter/AdapterObject)
