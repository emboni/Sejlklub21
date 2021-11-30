using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Models
{
    public class Boat : IBoat
    {
        private int _id;

        private string _name;

        private string _model;

        private string _specification;
        
        private string _location;

        private List<IDamage> _damages;

        public int BoatNum
        {
            get { return _id; }
            set { _id = value; }
        }

        [Required]
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        [Required]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [Required]
        public string Specification
        {
            get { return _specification; }
            set { _specification = value; }
        }

        [Required]
        public string Location
        {
            get { return _location; }
            set { _location = value; }

        }

        public List<IDamage> Damages
        {
            get { return _damages; }
        }
    }
}
