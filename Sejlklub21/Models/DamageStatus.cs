using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sejlklub21.Models
{
    public class DamageStatus
    {
        public enum Status
        {
            [Display(Name = "Ikke Behandlet")]
            IkkeBehandlet,
            Påbegyndt,
            Fikset,
            [Display(Name = "Kan Ikke Reperares")]
            KanIkkeReperares
        }
    }
}
