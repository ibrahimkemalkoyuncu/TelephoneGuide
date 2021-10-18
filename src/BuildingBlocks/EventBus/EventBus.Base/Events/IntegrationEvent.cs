using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Events
{
    public class IntegrationEvent
    {
        [JsonProperty]
        public Guid ID { get; private set; }

        [JsonProperty]
        public DateTime CreateDate { get; private set; }

        
        public IntegrationEvent()
        {
            ID = Guid.NewGuid();
            CreateDate = DateTime.Now;
        }

        [JsonConstructor]
        public IntegrationEvent(Guid id, DateTime createDate)
        {
            ID = id;
            CreateDate = createDate;
        }
    }
}
