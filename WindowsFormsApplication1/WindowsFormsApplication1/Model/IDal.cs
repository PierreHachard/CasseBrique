using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Model
{
    public interface IDal : IDisposable
    {
        void AddUser(Model_User user);
        List<Model_User> GetUsers();
    }
}
