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

        bool Login(string username, string password);
        void Logout();

        IMember GetMember(int id);
        IMember GetMemberByUsername(string username);
        List<IMember> GetAllMembers();
    }
}
