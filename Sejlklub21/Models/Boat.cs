using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private List<Damage> _damages;

        public int BoatNum
        {
            get { return _id; }
            set { _id = value; }
        }

        [Required(ErrorMessage = "Model fæltet skal være udfyldt")]
        [DisplayName("Model")]
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        [Required(ErrorMessage = "Navn fæltet skal være udfyldt")]
        [DisplayName("Navn")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [Required(ErrorMessage = "Spesificationer fæltet skal være udfyldt")]
        [DisplayName("Spesificationer")]
        public string Specification
        {
            get { return _specification; }
            set { _specification = value; }
        }

        [Required(ErrorMessage = "Lokation fæltet skal være udfyldt")]
        [DisplayName("Lokation")]
        public string Location
        {
            get { return _location; }
            set { _location = value; }

        }

        public List<Damage> Damages
        {
            get { return _damages; }
            set { _damages = value; }
        }

        public IDamage GetDamage(int id)
        {
            return _damages.First(x => x.Id == id);
        }
    }
}
