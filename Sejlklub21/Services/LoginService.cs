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
    }
}