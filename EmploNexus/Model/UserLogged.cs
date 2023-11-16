using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmploNexus.AppData;

namespace EmploNexus
{
   public class UserLogged
    {
        private static UserLogged _instance;

        public UserAccount UserAccounts { get; set; }

        private UserLogged()
        {

        }

        public static UserLogged GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserLogged();
            }
            return _instance;
        }
    }
}
