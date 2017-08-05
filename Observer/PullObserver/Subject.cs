using System.Collections;

namespace PullObserver
{
    internal abstract class Subject
    {
        ArrayList arrayList = new ArrayList();

        public void Attach(Observer observer) => arrayList.Add(observer);
        public void Detach(Observer observer) => arrayList.Remove(observer);
        public virtual string State { get; set; }
        public void Notify()
        {
            foreach (Observer observer in arrayList)
            {
                observer.Update(State);
            }
        }
    }
}
