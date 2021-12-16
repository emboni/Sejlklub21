using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Interfaces
{
    public interface IBoatTypeCatalog
    {
        void CreateType(IBoatType boatType);
        void UpdateType(IBoatType boatType);
        void DeleteType(IBoatType boatType);

        IBoatType GetType(int id);
        List<IBoatType> GetAllTypes();
    }
}