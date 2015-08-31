using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tripManager.model;

namespace tripManager.controller
{
    public class DBHandler 
    {
        private static DBHandler instance;
        private context DB;
        private DBHandler() { DB = new context(); }
        public static DBHandler getInstance()
        {
            if(instance == null){
                instance = new DBHandler();
            }
            return instance;
        }








        public bool insertTrip(Trip t) 
        { 
                DB.trips.Add(t);
                return DB.SaveChanges() > 0;
        }
        public bool insertClient(Client c) 
        {
            DB.clients.Add(c);
            return DB.SaveChanges() > 0;
        }
        public bool insertTripGroup(Trip t, Group g) 
        {
            DB.groups.Add(g);
            TripGroup tg = new TripGroup();
            tg.groupID = g.ID;
            tg.tripID = t.ID;
            DB.tripGroups.Add(tg);
            return DB.SaveChanges() > 0;
        }
        public bool insertResrvation(Client c, Trip t, Reservation r) 
        { 
            insertClient(c);
           // Reservation r = new Reservation();
            r.clientID = c.ID;
            r.tripID = t.ID;
            t.nextTicketID++;
            DB.trips.Attach(t);
            DB.Entry(t).State = EntityState.Modified;
            DB.reservations.Add(r);
            return DB.SaveChanges() > 0;
        }

        public bool insertClientGroup(int clientID, int groupID)
        {
            ClientGroup cg = new ClientGroup();
            cg.clientID = clientID;
            cg.groupID = groupID;
            DB.clientGroups.Add(cg);
            return DB.SaveChanges() > 0;
        }


        public Trip getTrip(int tripID) 
        {
            IQueryable<Trip> trips = DB.trips.Where(n => n.ID == tripID);
            if(trips.Count() == 1){
                return trips.Single();
            }
            return null;
        }
        public Client getClient(string name) { return null; }

        public int getTicketID()
        {
            string sqlQuery = "SELECT [dbo].[getID] ({0})";
            Object[] parameters = { "Clients" };
            int activityCount = DB.Database.SqlQuery<int>(sqlQuery, parameters).DefaultIfEmpty(1).First();
            return activityCount;
        }
        public Group getGroup(int groupID)
        {
            IQueryable<Group> groups = DB.groups.Where(n => n.ID == groupID);
            if (groups.Count() == 1)
            {
                return groups.Single();
            }
            return null;
        }
        public Reservation getReservation(string clientName, string tripName) { return null; }
        public Reservation getReservation(int clientID, int tripID) { return null; }



        public List<Trip> getTrips() { return DB.trips.Where(t => !t.isDeleted).ToList(); }
        public List<Client> getTripClients(int tripID) { return null; }
        public List<Group> getTripGroups(int tripID)
        {
            IQueryable<TripGroup> tripGroups = DB.tripGroups.Where(n => n.tripID == tripID);
            List<Group> groups = tripGroups.Select(s => s.group).ToList();
            return groups;
        }
        public List<Reservation> getTripResrvations(int tripID) { return null; }



        public bool updateTrip(Trip t) 
        {
            DB.trips.Attach(t);
            DB.Entry(t).State = EntityState.Modified;
            return DB.SaveChanges() > 0;
        }
        public bool updateClient(Client c) { return true; }
        public bool updateGroup(Group g)
        {
            DB.groups.Attach(g);
            DB.Entry(g).State = EntityState.Modified;
            return DB.SaveChanges() > 0;
        }
        public bool updateResrvation(Reservation r) { return true; }



        public bool removeTrip(Trip t) 
        {
            var trip = DB.trips.Find(t.ID);
            trip.isDeleted = true;
            DB.Entry(trip).State = EntityState.Modified;
            return DB.SaveChanges() > 0;
        }
        public bool removeClient(Client c) { return true; }
        public bool removeGroup(Group g) 
        {
            var group = DB.groups.Find(g.ID);
            DB.groups.Remove(group);
            return DB.SaveChanges() > 0;

        }
        public bool removeResrvation(Reservation r) { return true; }




    }
}
