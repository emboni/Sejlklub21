using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Models
{
    public class Booking : IBooking
    {
        private int _id;
        private int _boat;
        private int _member;
        private bool _completed;
        private Journey _journey;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        //[Required]
        public int BoatNum
        {
            get { return _boat; }
            set { _boat = value; }
        }

        //[Required]
        public int MemberId
        {
            get { return _member; }
            set { _member = value; }
        }

        [DisplayName("Tur er færdig")]
        public bool Completed
        {
            get { return _completed; }
            set { _completed = value; }
        }

        [Required]
        public Journey Journey
        {
            get { return _journey; }
            set { _journey = value; }
        }
    }
}
