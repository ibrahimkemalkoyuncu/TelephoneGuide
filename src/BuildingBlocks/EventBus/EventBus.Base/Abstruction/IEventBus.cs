using EventBus.Base.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Abstruction
{
    public interface IEventBus // Susbscrib işlemleri için
    {
        void Publish(IntegrationEvent @event);
        void Subscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationsEventHandler<T>;

        void UnSubscribe<T, TH>() where T : IntegrationEvent where TH : IIntegrationsEventHandler<T>;



    }
}
