using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Models;

namespace Sejlklub21.Interfaces
{
    public interface IBoat
    {
        int BoatNum { get; set; }
        string Model { get; }

        string Name { get; }

        string Specification { get; }

        string Location { get; }

        List<Damage> Damages { get; set; }

        IDamage GetDamage(int id);
    }
}
