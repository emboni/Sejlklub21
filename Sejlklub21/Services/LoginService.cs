using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sejlklub21.Interfaces;

namespace Sejlklub21.Services
{
    public class LoginService : ILoginService
    {
        public IMember CurrentMember { get; set; }
        public bool AdminPrivilege { get; set; }

        public void SetCurrentMember(IMember member)
        {
            CurrentMember = member;

            if (member != null)
            {
                AdminPrivilege = member.Admin;
            }
            else
            {
                AdminPrivilege = false;
            }
        }

        public bool CheckCurrentMember()
        {
            if (CurrentMember != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}