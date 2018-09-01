using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvchw.Data
{
    interface __IUserRepo : IDisposable
    {
        List<User1> GetUsers();
        User1 GetUserById(int id);
        void InsertUser(User1 user);
        void ModifyUser(User1 user);
        void DeletedUser(User1 user);
        void Commit();
    }
}
