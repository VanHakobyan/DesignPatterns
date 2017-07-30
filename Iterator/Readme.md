<p align="center"><img src="http://i1.wp.com/themoderndeveloper.com/wp-content/uploads/2013/08/Featured_IteratorPattern.jpg?resize=612%2C253"></p>

This article aims at explaining the Iterator pattern and having a rudimentary implementation of the Iterator pattern in C#. This article is meant for beginners and does not use any language built-in features for iterations.

Having a collection of objects is a very common thing in software development. If we have a collection of objects then we might also find ourselves in need to traverse this collection. Most languages provide traversal techniques over basic collection types. C# also contain some special container types capable of holding a collection of values (example: Lists, and ArrayLists in C#). These specialized containers also come with the possibility of getting iterated. C# container classes are the best examples of how the iterator pattern is implemented.

Note: We will not be using any of these techniques in this article.

If we want the underlying working mechanism of these iterator objects then we will perhaps need to understand the Iterator pattern first. The idea behind the Iterator pattern is that we decouple the actual collection object from the traversal logic. This will make the collection object lighter as it does not have to deal with all the iteration related functionalities and from the user's point of view, there is a clear separation between the collection and how the collection is being iterated. Also, the user will not have to worry about keeping track of the number of items traversed, remaining, and whether to check for boundary conditions as all this is already being done in the iterator object (as these things will depend on the underlying structure and implementation of the collection object).

<p align="center"><img width="402" height="393" alt="iterator pattern image" src="https://www.codeproject.com/KB/architecture/362986/idea.JPG"></p>

GoF defines the Iterator pattern as "Provide a way to access the elements of an aggregate object sequentially without exposing its underlying representation". To visualize the GoF design (slightly modified as per our implementation):

<p align="center"><img width="585" height="434" alt="iterator pattern image" src="https://www.codeproject.com/KB/architecture/362986/class.JPG"></p>

```C#
internal class Bank : IEnumerable
{
    List<Banknote> bankValut = new List<Banknote> {
        new Banknote(),
        new Banknote(),
        new Banknote(),
        new Banknote()
    };
    public Banknote this[int index]
    {
        get { return bankValut[index]; }
        set { bankValut.Insert(index, value); }
    }
    public IEnumerator GetEnumerator()
    {
        return new Casher(this);
    }
    public int count
    {
        get { return bankValut.Count; }
    }
}


public class Banknote
{
    public string Nominal="100$";
}

internal class Casher : IEnumerator
{
    private Bank bank;
    int current = -1;
    public Casher(Bank bank)
    {
        this.bank = bank;
    }

    public object Current
    {
        get { return bank[current]; }
    }

    public bool MoveNext()
    {
        if (current < bank.count - 1)
        {
            current++;
            return true;
        }
        return false;
    }

    public void Reset()
    {
        current = -1;
    }
}

//main

static void Main(string[] args)
{
    IEnumerable bank = new Bank();
    IEnumerator cashier = bank.GetEnumerator();
    while (cashier.MoveNext())
    {
        Banknote banknote = cashier.Current as Banknote;
        Console.WriteLine(banknote.Nominal);
    }
}
```

### Source code <a href="https://github.com/VanHakobyan/DesignPatterns/blob/master/Iterator/IteratorBank">her</a>
