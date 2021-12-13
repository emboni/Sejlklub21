using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Helpers;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Services
{
    public class BoatTypeCatalog : IBoatTypeCatalog
    {
        private string jsonFilePath = @"Data\BoatTypeCatalog.json";

        public void CreateType(IBoatType boatType)
        {
            List<IBoatType> boatTypes = GetAllTypes();
            boatType.Id = boatTypes.Count == 0 ? 1 : boatTypes.Max(x => x.Id) + 1;

            boatTypes.Add(boatType);

            JsonFileWriter.WriteJsonBoatType(boatTypes, jsonFilePath);
        }

        public void UpdateType(IBoatType boatType)
        {
            List<IBoatType> boatTypes = GetAllTypes();

            boatTypes[boatType.Id] = boatType;

            JsonFileWriter.WriteJsonBoatType(boatTypes, jsonFilePath);
        }

        public void DeleteType(IBoatType boatType)
        {
            List<IBoatType> boatTypes = GetAllTypes();

            boatTypes.Remove(boatType);

            JsonFileWriter.WriteJsonBoatType(boatTypes, jsonFilePath);
        }

        public IBoatType GetType(int id)
        {
            List<IBoatType> boatTypes = GetAllTypes();

            foreach (BoatType boatType in boatTypes)
            {
                if (boatType.Id == id)
                {
                    return boatType;
                }
            }

            return null;
        }

        public List<IBoatType> GetAllTypes()
        {
            return JsonFileReader.ReadJsonBoatTypes(jsonFilePath);
        }
    }
}