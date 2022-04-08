using Abstract_Factory_App.Members.Member_Function.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_App.Members
{
    class Admin : Member, IAdAction, IAdConfirm
    {
        public int adminNo;
        protected override string name 
        { 
            get 
            { 
                return name; 
            } 
            set 
            { 
                name = value; 
            } 
        }
        protected override string mail
        {
            get
            {
                return mail;
            }
            set
            {
                mail = value;
            }
        }
        protected override string password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public void AdConfirm()
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        protected override bool isThereAccount()
        {
            return true;
        }
    }
}
