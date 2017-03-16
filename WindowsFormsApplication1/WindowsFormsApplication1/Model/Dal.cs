using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasseBrique.Model
{
    public class Dal : IDal
    {
        private BddContext bdd;
        public Dal()
        {
            bdd = new BddContext();
        }

        public List<Model_User> GetUsers()
        {
            return bdd.Users.ToList<Model_User>();
        }

        public void AddUser(Model_User user)
        {
            bdd.Users.Add(user);
            bdd.SaveChanges();
        }

        public void setScore()
        {
            bdd.SaveChanges();
        }

        public void Dispose()
        {
            bdd.Dispose();
        }
    }
}
