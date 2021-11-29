using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Interfaces
{
    interface IBoat
    {
        int BoatNum { get; }
        string Model { get; }

        string Name { get; }

        string Specification { get; }

        string Location { get; }

        List<IDamage> Damages { get; }
    }
}
