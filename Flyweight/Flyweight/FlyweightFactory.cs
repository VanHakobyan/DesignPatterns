using System.Collections;

namespace Flyweight
{
    class FlyweightFactory
    {
        Hashtable flyweightsPool = new Hashtable
        {
            {"1",new ConctreteFlyweight() },
            {"2",new ConctreteFlyweight() },
            {"3",new ConctreteFlyweight() }
        };

        public AbstractFlyweight GetFlyweight(string key)
        {
            if (!flyweightsPool.ContainsKey(key))
                flyweightsPool.Add(key, new ConctreteFlyweight());
            return flyweightsPool[key] as AbstractFlyweight;
        }
    }
}
