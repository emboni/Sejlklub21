using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Models
{
    public class Booking : IBooking
    {
        private int _id;
        private IBoat _boat;
        private IMember _member;
        private Journey _journey;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Required]
        public IBoat Boat
        {
            get { return _boat; }
            set { _boat = value; }
        }

        [Required]
        public IMember Member
        {
            get { return _member; }
            set { _member = value; }
        }

        [Required]
        public Journey Journey
        {
            get { return _journey; }
            set { _journey = value; }
        }
    }
}
