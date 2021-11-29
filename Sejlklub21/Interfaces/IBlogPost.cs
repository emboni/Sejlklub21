using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sejlklub21.Interfaces
{
    public interface IBlogPost
    {
        string Title
        {
            get;
            set;
        }

        string Content
        {
            get;
            set;
        }

        string Picture
        {
            get;
            set;
        }

        int Id
        {
            get;
            set;
        }

        DateTime Date
        {
            get;
            set;
        }

       
    }
}
