<p align="middle"><img src="https://upload.wikimedia.org/wikipedia/commons/1/11/Composite_Pattern.png"></p>
<br>

### Intruduction :pray:

Composite pattern is used where we need to treat a group of objects in similar way as a single object. Composite pattern composes objects in term of a tree structure to represent part as well as whole hierarchy. This type of design pattern comes under structural pattern as this pattern creates a tree structure of group of objects.

This pattern creates a class that contains group of its own objects. This class provides ways to modify its group of same objects.

We are demonstrating use of composite pattern via following example in which we will show employees hierarchy of an organization. 

### Implementation :bust_in_silhouette:

``` C#

class Program
{
    static void Main(string[] args)
    {
        Component root = new Composite("root");
        Component branch1 = new Composite("br1");
        Component branch2 = new Composite("br2");
        Component leaf1 = new Leaf("leaf1");
        Component leaf2 = new Leaf("leaf2");
        Component leaf3 = new Leaf("leaf3");

        //Create tree

        root.Add(branch1);
        root.Add(branch2);

        //           *           //Root
        //        /     \
        //       *       *       //branch1 and branch2

        branch1.Add(leaf1);
        branch2.Add(leaf2);
        branch1.Add(leaf3);

        //           *           //Root
        //        /     \       
        //       *       *       //branch1 and branch2
        //     / |        \
        //    ~  ~         ~     // leaf1,leaf3 and leaf2
        //
        //
        root.Operation();        // Creating
    }

```

* For more clik [here](https://github.com/VanHakobyan/DesignPatterns/blob/master/Composite/CompositeTree)  :speech_balloon:
