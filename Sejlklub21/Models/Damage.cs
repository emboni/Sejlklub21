using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Models
{
    public class Damage : IDamage
    {
        private int _id;
        private DateTime _date;
        private string _description;
        private DamageStatus.Status _status;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        [DisplayName("Dato")]
        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        [Required(ErrorMessage = "Der skal være en beskrivelse af skaden")]
        [DisplayName("Beskrivelse")]
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        [Required(ErrorMessage = "Der skal være en status for skaden")]
        public DamageStatus.Status Status
        {
            get => _status;
            set => _status = value;
        }
    }
}
