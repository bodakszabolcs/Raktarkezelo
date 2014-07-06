using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raktarkezelo.DataBase;
using Raktarkezelo.Security;

namespace Raktarkezelo.User
{
    public class Users
    {
        private string Name;
        private string Password;
        private List<Privilages> Priv;
        
        public Users()
        {
            Name = null;
            Password = null;
            Priv = null;
        }
        public Users(string name, string pwd)
        {
            Name = name;
            Password = pwd;
        }
        public bool userLogin(string name, string pwd)
        {
            MySQLDB db = new MySQLDB();
            CryptoLib cl = new CryptoLib();
            string where = string.Format(" where user_name='{0}' and user_pwd='{1}'",name, cl.MD5Hash(pwd) );
            int count = db.Count(" users ", where);
            return Convert.ToBoolean(count);

        }

    }
    public class Privilages
    {
        public string Name;
        public string Value;

        public Privilages()
        {
            Name = null;
            Value = null;
        }
        public Privilages(string name,string value)
        {
            Name = name;
            Value = name;
        }
    }
   
    
}
