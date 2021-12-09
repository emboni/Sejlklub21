using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Models;

namespace Sejlklub21.Interfaces
{
    public interface IMemberCatalog
    {
        void AddMember(IMember member);
        void UpdateMember(IMember member);
        void DeleteMember(IMember member);

        IMember Login(string username, string password);

        IMember GetMember(int id);
        IMember GetMemberByEmail(string email);
        List<IMember> GetAllMembers();
    }
}
