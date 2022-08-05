using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace Keeper
{
    internal class KeeperDb : DbContext
    {
        public DbSet<Administrate> administrates { get; set; }
        public DbSet<Attend> attends { get; set; }
        public DbSet<Donation> donations { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Equipment> equipment { get; set; }
        public DbSet<Eventcal> eventcals { get; set; }
        public DbSet<Family> families { get; set; }
        public DbSet<Group> groups { get; set; }
        public DbSet<GroupMember> groupmember { get; set; }
        public DbSet<Job> jobs { get; set; }
        public DbSet<Messanger> messangers { get; set; }
        public DbSet<Ministerd> ministers { get; set; }
        public DbSet<Person> people { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<User> users { get; set; }
    }
}
