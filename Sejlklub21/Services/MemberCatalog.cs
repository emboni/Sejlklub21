using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Helpers;
using Sejlklub21.Interfaces;
using Sejlklub21.Models;

namespace Sejlklub21.Services
{
    public class MemberCatalog : IMemberCatalog
    {
        private string jsonFilePath = @"Data\Members.json";

        public void AddMember(IMember member)
        {
            List<IMember> members = GetAllMembers();
            member.Id = members.Count == 0 ? 1 : members.Max(x => x.Id) + 1;

            members.Add(member);

            JsonFileWriter.WriteJsonMembers(members, jsonFilePath);
        }

        public void UpdateMember(IMember member)
        {
            List<IMember> members = GetAllMembers();

            members[member.Id] = member;

            JsonFileWriter.WriteJsonMembers(members, jsonFilePath);
        }

        public void DeleteMember(IMember member)
        {
            List<IMember> members = GetAllMembers();

            members.Remove(member);

            JsonFileWriter.WriteJsonMembers(members, jsonFilePath);
        }

        public IMember GetMember(int id)
        {
            return GetAllMembers()[id];
        }

        public List<IMember> GetAllMembers()
        {
            return JsonFileReader.ReadJsonMembers(jsonFilePath);
        }
    }
}