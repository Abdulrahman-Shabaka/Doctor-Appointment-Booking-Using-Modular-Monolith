namespace SharedKernel.Events;

public class EventDispatcher
{
    private readonly Dictionary<Type, List<Action<IEvent>>> _handlers = new();

    public void Register<TEvent>(Action<TEvent> handler) where TEvent : IEvent
    {
        var eventType = typeof(TEvent);
        if (!_handlers.ContainsKey(eventType))
        {
            _handlers[eventType] = [];
        }

        _handlers[eventType].Add(e => handler((TEvent)e));
    }

    public void Dispatch(IEvent @event)
    {
        var eventType = @event.GetType();
        if (!_handlers.TryGetValue(eventType, out var handler1)) return;
        foreach (var handler in handler1)
        {
            handler(@event);
        }
    }
}