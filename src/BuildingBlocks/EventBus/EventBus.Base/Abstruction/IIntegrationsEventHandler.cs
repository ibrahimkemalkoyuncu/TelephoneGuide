﻿using EventBus.Base.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Abstruction
{
    public interface IIntegrationsEventHandler<TIntegrationEvent> : IntegrationEventHandler where TIntegrationEvent: IntegrationEvent
    {
        Task Handle(TIntegrationEvent @event);
    }


    public interface IntegrationEventHandler
    {

    }





    //
}
