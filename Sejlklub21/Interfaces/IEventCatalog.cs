using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Interfaces
{
    public interface IEventCatalog
    {
        void AddEvent(IEvent ev);
        void UpdateEvent(IEvent ev);
        void DeleteEvent(int id);

        List<IEvent> GetAllEvents();

        IEvent GetEvent(int id);


    }
}
