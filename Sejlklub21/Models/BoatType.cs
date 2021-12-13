using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Models
{
    public class BoatType : IBoatType
    {
        public int Id { get; set; } 
        public string Name { get; set; }
    }
}