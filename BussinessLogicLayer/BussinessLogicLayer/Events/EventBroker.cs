using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.Events
{
    public class EventBroker : IPublisher, ISubscriber
    {
        private readonly ConcurrentDictionary<object, object> list = new ConcurrentDictionary<object, object>();

        public void Publish<T>(T eventData)
        {
            foreach (var eventConsumer in list.Keys)
            {
                if(eventConsumer is ICanHandle<T>)
                    ((ICanHandle<T>)eventConsumer).Handle(eventData);
            }
        }

        public void Subscribe(object target)
        {
            list.TryAdd(target, target);
        }

        public void Unsubscribe(object target)
        {
            list.TryRemove(target, out target);
        }
    }
}
