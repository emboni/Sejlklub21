using Sejlklub21.Interfaces;
using Sejlklub21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Services
{
    public class EventCatalog : IEventCatalog
    {
        private List<IEvent> eventList;

        public EventCatalog()
        {
            eventList = new List<IEvent>();

            eventList.Add(new Event(0, "Navn", DateTime.Now, "Location", "Description"));
        }
        public void AddEvent(IEvent @event)
        {
            eventList.Add(@event);
        }
        public void UpdateEvent(IEvent @event)
        {
            //foreach (IEvent @event in eventList)
            //{
                
            //}
            eventList[@event.Id] = @event;
            //Poul tror ikke, den dur
        }
        public IEvent GetEvent(int id)
        {
            return eventList[id];
        }
        public List<IEvent> GetAllEvents()
        {
            return eventList;
        }

        public void DeleteEvent(int id)
        {
            throw new NotImplementedException();
        }
    }
}
