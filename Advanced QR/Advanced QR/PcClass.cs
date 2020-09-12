using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_QR
{
    class PcClass
    {
        public string pcname { get; set; }

        public PcClass(string _pcname)
        {
            pcname = _pcname;
        }

        public PcClass()
        {
        }

        public static bool IsEqual(PcClass user1, PcClass user2)
        {
            if (user1 is null || user2 is null)
            {
                return false;
            }

            if (user1.pcname != user2.pcname)
            {
                return false;
            }

            return true;
        }

    }
}
