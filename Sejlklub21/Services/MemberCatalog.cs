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

        public IMember Login(string email, string password)
        {
            IMember loginMember = GetMemberByEmail(email);

            if (loginMember != null && loginMember.Password == password)
            {
                return loginMember;
            }
            else
            {
                return null;
            }
        }

        public IMember GetMember(int id)
        {
            List<IMember> members = GetAllMembers();

            foreach (Member member in members)
            {
                if (member.Id == id)
                {
                    return member;
                }
            }

            return null;
        }

        public IMember GetMemberByEmail(string email)
        {
            List<IMember> members = GetAllMembers();

            foreach (Member member in members)
            {
                if (member.Email == email)
                {
                    return member;
                }
            }

            return null;
        }

        public List<IMember> GetAllMembers()
        {
            return JsonFileReader.ReadJsonMembers(jsonFilePath);
        }
    }
}