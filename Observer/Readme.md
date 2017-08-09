<p align="center"><img src="https://i.gyazo.com/9c45b57cb47da6691f451a1f8f6a6cb4.png"></p>
<p align="center"><img src="https://i.gyazo.com/c5803b79cf427aeb75d0c39ef839bac1.png"></p>

The observer design pattern enables a subscriber to register with and receive notifications from a provider. It is suitable for any scenario that requires push-based notification. The pattern defines a provider (also known as a subject or an observable) and zero, one, or more observers. Observers register with the provider, and whenever a predefined condition, event, or state change occurs, the provider automatically notifies all observers by calling one of their methods. In this method call, the provider can also provide current state information to observers. In the .NET Framework, the observer design pattern is applied by implementing the generic System.IObservable<T> and System.IObserver<T> interfaces. The generic type parameter represents the type that provides notification information.

### Applying the Pattern :full_moon:

The observer design pattern is suitable for distributed push-based notifications, because it supports a clean separation between two different components or application layers, such as a data source (business logic) layer and a user interface (display) layer. The pattern can be implemented whenever a provider uses callbacks to supply its clients with current information.

### Implementation :earth_africa:

```C#
using System;
using System.Collections.Generic;

public class BaggageInfo
{
 private int flightNo;
 private string origin;
 private int location;

 internal BaggageInfo(int flight, string from, int carousel)
 {
    this.flightNo = flight;
    this.origin = from;
    this.location = carousel;
 }

 public int FlightNumber {
    get { return this.flightNo; }
 }

 public string From {
    get { return this.origin; }
 }

 public int Carousel {
    get { return this.location; }
 }
}
```

Both collections are represented by generic List<T> objects that are instantiated in the BaggageHandler class constructor. The source code for the BaggageHandler class is shown in the following example.:bug:

```C#
public class BaggageHandler : IObservable<BaggageInfo>
{
   private List<IObserver<BaggageInfo>> observers;
   private List<BaggageInfo> flights;

   public BaggageHandler()
   {
      observers = new List<IObserver<BaggageInfo>>();
      flights = new List<BaggageInfo>();
   }

   public IDisposable Subscribe(IObserver<BaggageInfo> observer)
   {
      // Check whether observer is already registered. If not, add it
      if (! observers.Contains(observer)) {
         observers.Add(observer);
         // Provide observer with existing data.
         foreach (var item in flights)
            observer.OnNext(item);
      }
      return new Unsubscriber<BaggageInfo>(observers, observer);
   }

   // Called to indicate all baggage is now unloaded.
   public void BaggageStatus(int flightNo)
   {
      BaggageStatus(flightNo, String.Empty, 0);
   }

   public void BaggageStatus(int flightNo, string from, int carousel)
   {
      var info = new BaggageInfo(flightNo, from, carousel);

      // Carousel is assigned, so add new info object to list.
      if (carousel > 0 && ! flights.Contains(info)) {
         flights.Add(info);
         foreach (var observer in observers)
            observer.OnNext(info);
      }
      else if (carousel == 0) {
         // Baggage claim for flight is done
         var flightsToRemove = new List<BaggageInfo>();
         foreach (var flight in flights) {
            if (info.FlightNumber == flight.FlightNumber) {
               flightsToRemove.Add(flight);
               foreach (var observer in observers)
                  observer.OnNext(info);
            }
         }
         foreach (var flightToRemove in flightsToRemove)
            flights.Remove(flightToRemove);

         flightsToRemove.Clear();
      }
   }

   public void LastBaggageClaimed()
   {
      foreach (var observer in observers)
         observer.OnCompleted();

      observers.Clear();
   }
}


```

:zap:The provider's Subscribe method returns an IDisposable implementation that enables observers to stop receiving notifications before the OnCompleted method is called. The source code for this Unsubscriber(Of BaggageInfo) class is shown in the following example. When the class is instantiated in the BaggageHandler.Subscribe method, it is passed a reference to the observers collection and a reference to the observer that is added to the collection. These references are assigned to local variables. When the object's Dispose method is called, it checks whether the observer still exists in the observers collection, and, if it does, removes the observer.

```C#
internal class Unsubscriber<BaggageInfo> : IDisposable
{
   private List<IObserver<BaggageInfo>> _observers;
   private IObserver<BaggageInfo> _observer;

   internal Unsubscriber(List<IObserver<BaggageInfo>> observers, IObserver<BaggageInfo> observer)
   {
      this._observers = observers;
      this._observer = observer;
   }

   public void Dispose() 
   {
      if (_observers.Contains(_observer))
         _observers.Remove(_observer);
   }
}

```

The following example provides an IObserver<T> implementation named ArrivalsMonitor, which is a base class that displays baggage claim information. The information is displayed alphabetically, by the name of the originating city. The methods of ArrivalsMonitor are marked as overridable (in Visual Basic) or virtual (in C#), so they can all be overridden by a derived class. :clap:


```C#
using System;
using System.Collections.Generic;

public class ArrivalsMonitor : IObserver<BaggageInfo>
{
   private string name;
   private List<string> flightInfos = new List<string>();
   private IDisposable cancellation;
   private string fmt = "{0,-20} {1,5}  {2, 3}";

   public ArrivalsMonitor(string name)
   {
      if (String.IsNullOrEmpty(name))
         throw new ArgumentNullException("The observer must be assigned a name.");

      this.name = name;
   }

   public virtual void Subscribe(BaggageHandler provider)
   {
      cancellation = provider.Subscribe(this);
   }

   public virtual void Unsubscribe()
   {
      cancellation.Dispose();
      flightInfos.Clear();
   }

   public virtual void OnCompleted() 
   {
      flightInfos.Clear();
   }

   // No implementation needed: Method is not called by the BaggageHandler class.
   public virtual void OnError(Exception e)
   {
      // No implementation.
   }

   // Update information.
   public virtual void OnNext(BaggageInfo info) 
   {
      bool updated = false;

      // Flight has unloaded its baggage; remove from the monitor.
      if (info.Carousel == 0) {
         var flightsToRemove = new List<string>();
         string flightNo = String.Format("{0,5}", info.FlightNumber);
         
         foreach (var flightInfo in flightInfos) {
            if (flightInfo.Substring(21, 5).Equals(flightNo)) {
               flightsToRemove.Add(flightInfo);
               updated = true;
            }
         }
         foreach (var flightToRemove in flightsToRemove)
            flightInfos.Remove(flightToRemove);

         flightsToRemove.Clear();
      }
      else {
         // Add flight if it does not exist in the collection.
         string flightInfo = String.Format(fmt, info.From, info.FlightNumber, info.Carousel);
         if (! flightInfos.Contains(flightInfo)) {
            flightInfos.Add(flightInfo);
            updated = true;
         }
      }
      if (updated) {
         flightInfos.Sort();
         Console.WriteLine("Arrivals information from {0}", this.name);
         foreach (var flightInfo in flightInfos)
            Console.WriteLine(flightInfo);

         Console.WriteLine();
      }
   }
}
```

The ArrivalsMonitor class includes the Subscribe and Unsubscribe methods. The Subscribe method enables the class to save the IDisposable implementation returned by the call to Subscribe to a private variable. The Unsubscribe method enables the class to unsubscribe from notifications by calling the provider's Dispose implementation. ArrivalsMonitor also provides implementations of the OnNext, OnError, and OnCompleted methods. Only the OnNext implementation contains a significant amount of code. The method works with a private, sorted, generic List<T> object that maintains information about the airports of origin for arriving flights and the carousels on which their baggage is available. If the BaggageHandler class reports a new flight arrival, the OnNext method implementation adds information about that flight to the list. If the BaggageHandler class reports that the flight's baggage has been unloaded, the OnNext method removes that flight from the list. Whenever a change is made, the list is sorted and displayed to the console.
The following example contains the application entry point that instantiates the BaggageHandler class as well as two instances of the ArrivalsMonitor class, and uses the BaggageHandler.BaggageStatus method to add and remove information about arriving flights. In each case, the observers receive updates and correctly display baggage claim information. :musical_note:

```C#

using System;
using System.Collections.Generic;

public class Example
{
   public static void Main()
   {
      BaggageHandler provider = new BaggageHandler();
      ArrivalsMonitor observer1 = new ArrivalsMonitor("BaggageClaimMonitor1");
      ArrivalsMonitor observer2 = new ArrivalsMonitor("SecurityExit");

      provider.BaggageStatus(712, "Detroit", 3);
      observer1.Subscribe(provider);
      provider.BaggageStatus(712, "Kalamazoo", 3);
      provider.BaggageStatus(400, "New York-Kennedy", 1);
      provider.BaggageStatus(712, "Detroit", 3);
      observer2.Subscribe(provider);
      provider.BaggageStatus(511, "San Francisco", 2);
      provider.BaggageStatus(712);
      observer2.Unsubscribe();
      provider.BaggageStatus(400);
      provider.LastBaggageClaimed();
   }
}
// The example displays the following output:
//      Arrivals information from BaggageClaimMonitor1
//      Detroit                712    3
//
//      Arrivals information from BaggageClaimMonitor1
//      Detroit                712    3
//      Kalamazoo              712    3
//
//      Arrivals information from BaggageClaimMonitor1
//      Detroit                712    3
//      Kalamazoo              712    3
//      New York-Kennedy       400    1
//
//      Arrivals information from SecurityExit
//      Detroit                712    3
//
//      Arrivals information from SecurityExit
//      Detroit                712    3
//      Kalamazoo              712    3
//
//      Arrivals information from SecurityExit
//      Detroit                712    3
//      Kalamazoo              712    3
//      New York-Kennedy       400    1
//
//      Arrivals information from BaggageClaimMonitor1
//      Detroit                712    3
//      Kalamazoo              712    3
//      New York-Kennedy       400    1
//      San Francisco          511    2
//
//      Arrivals information from SecurityExit
//      Detroit                712    3
//      Kalamazoo              712    3
//      New York-Kennedy       400    1
//      San Francisco          511    2
//
//      Arrivals information from BaggageClaimMonitor1
//      New York-Kennedy       400    1
//      San Francisco          511    2
//
//      Arrivals information from SecurityExit
//      New York-Kennedy       400    1
//      San Francisco          511    2
//
//      Arrivals information from BaggageClaimMonitor1
//      San Francisco          511    2
```

* My other implementation <a href="https://github.com/VanHakobyan/DesignPatterns/tree/master/Observer/PullObserver">her</a>
