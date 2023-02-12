using tetofo.Service.Logger;

namespace tetofo.EventBus.Impl;

public class EventPayloadLoggerCallback : BaseCallback
{
    private IEventPayloadLoggerService _eventPayloadLoggerService;

    public EventPayloadLoggerCallback
    (
        IEventPayloadLoggerService eventPayloadLoggerService
    )
    : base()
    {
        _eventPayloadLoggerService = eventPayloadLoggerService;
    }

    public override void Callback(IEvent iEvent) => _eventPayloadLoggerService.LogEventPayload(iEvent);
}