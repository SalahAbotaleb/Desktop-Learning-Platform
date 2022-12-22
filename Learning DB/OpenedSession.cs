using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_DB
{
    static class OpenedSession
    {
        public static int ID;
        public static Usertype User;
        public static void intit(int id,Usertype usertype)
        {
            ID = id;
            User = usertype;
        }
    }
}
