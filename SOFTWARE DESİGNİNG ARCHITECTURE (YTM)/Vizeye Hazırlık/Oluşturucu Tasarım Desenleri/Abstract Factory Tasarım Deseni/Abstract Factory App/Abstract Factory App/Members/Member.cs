using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_App.Members
{
    abstract class Member
    {
        protected abstract string name { get; set; }
        protected abstract string mail { get; set; }
        protected abstract string password { get; set; }

        protected abstract bool isThereAccount();
    }
}
