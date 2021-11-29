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
        public List<IMember> memberList;

        public MemberCatalog()
        {
            memberList = new List<IMember>();

            memberList.Add(new Member(1, "bob", "gmail", "111111", "city"));
        }

        public void AddMember(IMember member)
        {
            memberList.Add(member);
        }

        public void UpdateMember(IMember member)
        {
            memberList[member.Id] = member;
        }

        public void DeleteMember(IMember member)
        {
            memberList.Remove(member);
        }

        public IMember GetMember(int id)
        {
            return memberList[id];
        }

        public List<IMember> GetAllMembers()
        {
            return memberList;
        }
    }
}