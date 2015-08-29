using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Web;
using tripManager.model;

namespace tripManager.controller
{
    class context : DbContext
    {

        public context()
            : base("TripManager.DbConnection")
    {
        Database.SetInitializer<context>(new DBinit());
        Configuration.ProxyCreationEnabled = false;
    }

        public DbSet<Trip> trips { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Group> groups { get; set; }



        public DbSet<Reservation> reservations { get; set; }
        public DbSet<ClientGroup> clientGroups { get; set; }
        public DbSet<TripGroup> tripGroups { get; set; }


       
    }
}
