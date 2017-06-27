namespace SimpleSingleton
{
    class Singleton
    {
        static Singleton uniqueValue;
        private Singleton()
        {
        }
        public static Singleton Instance()
        {
            if (uniqueValue == null)
                uniqueValue = new Singleton();
            return uniqueValue;
        }
    }
}
