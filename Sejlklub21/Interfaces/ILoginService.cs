using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Interfaces
{
    public interface ILoginService
    {
        IMember CurrentMember { get; set; }
        bool AdminPrivilege { get; set; }

        void SetCurrentMember(IMember member);
        bool CheckCurrentMember();
        string GetImageFileName();
    }
}