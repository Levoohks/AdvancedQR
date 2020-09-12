using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_QR
{
    class CheckKey
    {
        public string key { get; set; }
        public string used { get; set; }

        public CheckKey(string _key)
        {
            key = _key;
        }

        public CheckKey()
        {
        }

        public static bool IsEqual(CheckKey user1, CheckKey user2)
        {
            if (user1 is null || user2 is null)
            {
                return false;
            }

            if (user1.key != user2.key)
            {
                return false;
            }

            return true;
        }

    }
}
