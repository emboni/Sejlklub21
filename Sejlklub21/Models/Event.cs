using Sejlklub21.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Models
{
    public class Event : IEvent
    {
        private int _id;
        private string _title;
        private string _description;
        private string _location;
        private DateTime _date;

        public int Id { get { return _id; } set { _id = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }
        public string Location { get { return _location; } set { _location = value; } }
        public string Description { get { return _description; } set { _description = value; } }
    }

}
