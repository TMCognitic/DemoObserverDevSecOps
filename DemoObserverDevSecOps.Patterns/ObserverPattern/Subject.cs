namespace DemoObserverDevSecOps.Patterns.ObserverPattern
{
    public abstract class Subject : ISubject
    {

        public event Action<ISubject>? NotifyHandler;

        protected void Notify()
        {
            NotifyHandler?.Invoke(this);
        }
    }
}
