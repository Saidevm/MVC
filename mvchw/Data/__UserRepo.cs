using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvchw.Data
{
    public class __UserRepo : __IUserRepo
    {
        private userdbEntities context;
        public __UserRepo(userdbEntities udb)
        {
            context = udb;
        }
        public void DeletedUser(User1 user)
        {
            context.User1.Remove(user);
        }

        public List<User1> GetUsers()
        {
            return context.User1.ToList();
        }

        public void InsertUser(User1 user)
        {
            context.User1.Add(user);
        }

        public void ModifyUser(User1 user)
        {
            
        }

        public User1 GetUserById(int id)
        {
            return context.User1.Find(id);
        }

        public void Commit()
        {
            context.SaveChanges();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    context.Dispose();   
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~UserRepo() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}