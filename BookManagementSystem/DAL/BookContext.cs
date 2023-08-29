using DAL.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookContext : DbContext
    {
        public DbSet<SellerRegistration> SellerRegistrations { get; set; }
        public DbSet<Booklist> Booklists { get; set; }
        public DbSet<AdminReg> adminRegs { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}
