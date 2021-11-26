using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Models
{
    public class Boat
    {
        private string _name;

        private string _model;

        private string _specifications; 

        public string Specifications
        {
            get { return _specifications; }
            set { _specifications = value; }
        }


        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
