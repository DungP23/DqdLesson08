using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace DqdLesson8.Models
{
    public class DqdBookStore : DbContext
    {
        public DqdBookStore() : base("DqdBookStoreConnectionStrings")
        {

        }
        //Tao cac bang
        public DbSet<DqdCategory> DqdCategories { get; set; }
        public DbSet<DqdBook> DqdBooks { get; set; }
        public object DqdBook { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal object Entry(DqdBook dqdBook)
        {
            throw new NotImplementedException();
        }

        internal void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public class DbContext
    {
        public DbContext(string v)
        {
            V = v;
        }

        public string V { get; }
    }
}