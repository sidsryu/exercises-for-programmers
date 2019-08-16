using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._15
{
    public class Authentication
    {
        private Dictionary<string, string> listOfAccounts = new Dictionary<string, string>();

        public bool SignUp(string username, string password)
        {
            if (listOfAccounts.ContainsKey(username))
            {
                return false;
            }

            listOfAccounts.Add(username, password);
            return true;
        }

        public bool SignIn(string username, string password)
        {
            if (listOfAccounts.ContainsKey(username))
            {
                if (listOfAccounts[username].Equals(password))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
