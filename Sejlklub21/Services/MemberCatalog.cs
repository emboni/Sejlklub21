using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Services
{
    public class MemberCatalog : IMemberCatalog
    {
        public List<Member> memberList;

        public MemberCatalog()
        {
            memberList = new List<Member>();
        }

        public void AddMember(Member member)
        {
            memberList.Add(member);
        }

        public void UpdateMember(Member member)
        {
            throw new NotImplementedException();
        }

        public void DeleteMember(Member member)
        {
            memberList.Remove(member);
        }

        public Member GetMember()
        {
            throw new NotImplementedException();
        }

        public List<Member> GetAllMembers()
        {
            return memberList;
        }
    }
}