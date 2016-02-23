namespace BussinessLogicLayer.Events
{
    /// <summary>
    /// Interface for handling events
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICanHandle<in T>
    {
        void Handle(T openCompositeTaskWindowEventArgs);
    }
}