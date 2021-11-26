using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Models;

namespace Sejlklub21.Interfaces
{
    public interface IMemberCatalog
    {
        public void AddMember(Member member);
        public void UpdateMember(Member member);
        public void DeleteMember(Member member);

        public Member GetMember();
        public List<Member> GetAllMembers();
    }
}
