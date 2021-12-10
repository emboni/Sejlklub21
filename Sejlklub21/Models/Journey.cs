using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Validators;

namespace Sejlklub21.Models
{
    public class Journey
    {
        private DateTime _start;
        private DateTime _end;
        private string _route;

        [Required(ErrorMessage = "Der skal defineres et start tidspunkt til turen")]
        public DateTime Start
        {
            get { return _start; }
            set { _start = value; }
        }

        [Required(ErrorMessage = "Der skal defineres et slut tidspunkt til turen")]
        [DisplayName("Slut")]
        public DateTime End
        {
            get { return _end; }
            set { _end = value; }
        }

        //[Required(ErrorMessage = "Der skal være en forklaring på hvor du sejler hænd")]
        public string Route
        {
            get { return _route; }
            set { _route = value; }
        }

    }
}
