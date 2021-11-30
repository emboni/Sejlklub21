using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Models;

namespace Sejlklub21.Interfaces
{
    public interface IDamage
    {
        int Id { get; set; }

        DateTime Date { get; set; }

        string Description { get; set; }

        DamageStatus.Status Status { get; set; }
    }
}
