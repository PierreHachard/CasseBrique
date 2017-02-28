using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasseBrique.Model
{
    public class Model_User
    {
        public int Id {get; set; }
        public string Pseudo {get; set;}
        public string Password {get; set;}
        public int HighScore {get; set;}
        //public string Bonus { get; set; }
    }
}
