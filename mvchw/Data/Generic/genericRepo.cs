using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvchw.Data;
using System.Data.Entity;
using mvchw.Data.Generic;

namespace mvchw.Data.Generic
{
    public class GenericRepo<TEntity>: IGenericRepo<TEntity> where TEntity : class
    {
        private userdbEntities context;
        private DbSet<TEntity> dbset;

        public GenericRepo(userdbEntities ipcontext)
        {
            context = ipcontext;
            dbset = context.Set<TEntity>();
        }

        public void DeletedUser(TEntity entity)
        {
            dbset.Remove(entity);
        }

        public List<TEntity> GetUsers()
        {
            return dbset.ToList();
        }

        public void InsertUser(TEntity entity)
        {
            dbset.Add(entity);
        }

        public void ModifyUser(TEntity user)
        {

        }

        public TEntity GetUserById(int id)
        {
            return dbset.Find(id);
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}