using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Interfaces
{
    public interface IEvent
    {
        int Id { get; set; }
        string Name { get; set; }
        DateTime Date { get; set; }
        string Location { get; set; }
        string Description { get; set; }


        


    }
}
