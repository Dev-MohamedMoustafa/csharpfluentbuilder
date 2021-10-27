/*
 * this code was written by Mohamed Moustafa
 * As a preview of his knowledge in Design Patterns
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class AccountBuilder
    {
        string _Username;
        string _Password;
        int _ID;
        string _FullName;
        string _UserTown;

        public AccountBuilder WithUsername(string username)
        {
            this._Username = username;
            return this;
        }

        public AccountBuilder WithPassword(string password)
        {
            this._Password = password;
            return this;
        }

        public AccountBuilder WithID(int id)
        {
            this._ID = id;
            return this;
        }

        public AccountBuilder WithFullName(string fullName)
        {
            this._FullName = fullName;
            return this;
        }

        public AccountBuilder WithUsertown(string userTown)
        {
            this._UserTown = userTown;
            return this;
        }
        public AccountBuilder Build()
        {
            if (CanBuild())
            {
                return this;
            }
            else
            {
                throw new Exception("Username and Password are required..");
            }
        }
        private bool CanBuild()
        {
            return !string.IsNullOrEmpty(_Username) && !string.IsNullOrEmpty(_Password) ? true : false;
        }
    }
}
