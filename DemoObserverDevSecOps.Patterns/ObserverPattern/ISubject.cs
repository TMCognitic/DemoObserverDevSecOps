namespace DemoObserverDevSecOps.Patterns.ObserverPattern
{
    public interface ISubject
    {
        event Action<ISubject>? NotifyHandler;
    }
}