using tetofo.EventBus;

namespace tetofo.Service.Logger;

public interface IEventPayloadLoggerService
{
    void LogEventPayload(IEvent iEvent);
}