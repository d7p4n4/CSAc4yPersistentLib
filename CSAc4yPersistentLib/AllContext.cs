using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using d7p4n4.Final.Class;

namespace d7p4n4.Context.Class
{
    public class AllContext : DbContext
    {
        public AllContext(string baseName) : base(baseName)
        {
            
        }

        public DbSet<Ac4y> Ac4ys { get; set; }

        public DbSet<Ac4yIdentification> Ac4yIdentifications { get; set; }

        public DbSet<Ac4yIdentificationBase> Ac4yIdentificationBases { get; set; }


    }
}
