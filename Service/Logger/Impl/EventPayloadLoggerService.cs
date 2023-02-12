using Microsoft.Extensions.Logging;
using tetofo.EventBus;

namespace tetofo.Service.Logger.Impl;

public class EventPayloadLoggerService : IEventPayloadLoggerService
{
    private ILogger<EventPayloadLoggerService> _logger;

    public EventPayloadLoggerService
    (
        ILogger<EventPayloadLoggerService> logger
    )
    {
        _logger = logger;
    }

    public void LogEventPayload(IEvent iEvent)
    {
        _logger.LogInformation($"EVENT PAYLOAD: {iEvent?.Payload}");
    }
}