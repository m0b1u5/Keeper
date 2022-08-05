using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keeper
{
    internal class KeepDb : DbContext
    {
        public DbSet<People> poeple { get; set; }
        public DbSet<Event> events { get; set; }
        public DbSet<Giving> giving { get; set; }
        public DbSet<Offices> offices { get; set; }
        public DbSet<Minister> minister { get; set; }
        public DbSet<Attendance> attendance { get; set; }



    }
}
