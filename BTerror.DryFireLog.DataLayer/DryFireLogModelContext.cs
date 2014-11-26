using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTerror.DryFireLog.Models;

namespace BTerror.DryFireLog.DataLayer
{
    public class DryFireLogModelContext: DbContext
    {

        public DryFireLogModelContext()
        {
            Database.SetInitializer<DryFireLogModelContext>(null);
        }

        public DbSet<Drill> Drills { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Entry> Entries { get; set; }
        public DbSet<DryFireSession> DryFireSessions { get; set; }
    }
}
