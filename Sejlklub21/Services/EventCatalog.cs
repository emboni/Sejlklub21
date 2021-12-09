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

            eventList.Add(new Event(0, "Navn", "Description", "Location", DateTime.Now));

            eventList.Add(new Event(1, "Sejl i december", "Spas og sjov", "Hillerød", new DateTime(2021,12,16)));
        }
        public List<IEvent> GetAllEvents()
        {
            return eventList;
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
        

        public void DeleteEvent(int id)
        {
            throw new NotImplementedException();
        }
    }
}
