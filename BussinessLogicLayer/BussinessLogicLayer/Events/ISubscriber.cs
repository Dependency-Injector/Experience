namespace BussinessLogicLayer.Events
{
    /// <summary>
    /// Interface for consuming events
    /// </summary>
    public interface ISubscriber
    {
        void Subscribe(object target);
        void Unsubscribe(object target);
    }
}
