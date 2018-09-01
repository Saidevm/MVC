using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvchw.Data.Generic
{
    interface IGenericRepo<IEntity> where IEntity : class
    {
        List<IEntity> GetUsers();
        IEntity GetUserById(int id);
        void InsertUser(IEntity user);
        void ModifyUser(IEntity user);
        void DeletedUser(IEntity user);
        void Commit();
    }
}
