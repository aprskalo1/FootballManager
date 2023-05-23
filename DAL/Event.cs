using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Event
    {
        public Event(string eventType, string playerName)
        {
            EventType = eventType;
            PlayerName = playerName;
        }

        public string EventType { get; set; }
        public string PlayerName { get; set; }
    }
}
