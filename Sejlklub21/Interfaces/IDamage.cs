using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Models;

namespace Sejlklub21.Interfaces
{
    interface IDamage
    {
        int Id { get; }

        DateTime Date { get; }

        string Description { get; }

        DamageStatus.Status Status { get; }
    }
}
