namespace PullObserver
{
    internal class ConcreteObserver : Observer
    {
        string observerState;
        private ConcreteSubject subject;
        public ConcreteObserver(ConcreteSubject subject) => this.subject = subject;
        public override void Update(string state) => observerState = state;
    }
}