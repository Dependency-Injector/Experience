namespace BussinessLogicLayer.Events
{
    /// <summary>
    /// Interface for publishing events
    /// </summary>
    public interface IPublisher
    {
        void Publish<T>(T eventData);
    }
}
