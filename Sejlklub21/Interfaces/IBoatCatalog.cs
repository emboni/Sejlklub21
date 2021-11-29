using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Interfaces
{
    interface IBoatCatalog
    {
        void Add(IBoat boat);

        void Update(IBoat boat);

        void Delete(int boatNum);

        IBoat GetBoat(int boatNum);

        List<IBoat> GetAllBoats();
    }
}
