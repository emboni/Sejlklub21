using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Services
{
    public class BoatCatalog : IBoatCatalog
    {
        private string _filePath = "Data\\BoatCatalog.json";

        public void Add(IBoat boat)
        {
            List<IBoat> allBoats = GetAllBoats();
            boat.BoatNum = allBoats.Count == 0 ? 1 : allBoats.Max(x => x.BoatNum) + 1;
            boat.Damages = new List<Damage>();
            allBoats.Add(boat);
            Helpers.JsonFileWriter.WriteToJsonBoat(allBoats, _filePath);
        }

        public void Update(IBoat boat)
        {
            List<IBoat> allBoats = GetAllBoats();
            allBoats[allBoats.FindIndex(x => x.BoatNum == boat.BoatNum)] = boat;
            Helpers.JsonFileWriter.WriteToJsonBoat(allBoats, _filePath);
        }

        public void Delete(int boatNum)
        {
            List<IBoat> allBoats = GetAllBoats();
            allBoats.Remove(allBoats.First(x=>x.BoatNum == boatNum));
            Helpers.JsonFileWriter.WriteToJsonBoat(allBoats, _filePath);
        }

        public IBoat GetBoat(int boatNum)
        {
            foreach (IBoat boat in Helpers.JsonFileReader.ReadJsonBoats(_filePath))
            {
                if (boat.BoatNum == boatNum)
                {
                    return boat;
                }
            }

            return new Boat();
        }

        public List<IBoat> GetAllBoats()
        {
            return Helpers.JsonFileReader.ReadJsonBoats(_filePath);
        }
    }
}
