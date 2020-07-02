using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LoginTest01
{
    public class KomacUSer
    {
        public int UserID { get; set; }
        public string UserPassword { get; set; }
        public string UserName { get; set; }
        public int TeamInfo { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ UserID } {UserPassword} {UserName} {TeamInfo}";
            }
        }
    }
}
