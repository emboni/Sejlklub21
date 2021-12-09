using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Models
{
    public class DamageStatus
    {
        public enum Status
        {
            IkkeBehandlet,
            Påbegyndt,
            Fikset,
            KanIkkeReperares
        }
    }
}
