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
            return DB.trips.Where(n => n.ID == tripID).Include("reservations").Include("tripGroups.group").FirstOrDefault();
        }
        public Client getClient(string name, string phone)
        {
            return DB.clients.Where(c => c.name.Equals(name) && c.phoneNumber.Equals(phone)).Include("clientGroups.group").Single();
        }

        public Client getClient(int clientID)
        {
            return DB.clients.Where(c => c.ID== clientID).Include("clientGroups.group").Single();
        }
        
        public Group getGroup(int groupID)
        {
            return DB.groups.Where(n => n.ID == groupID).FirstOrDefault();
        }
        public Reservation getReservation(int clientID, int tripID) 
        {
            return DB.reservations.Where(r => r.clientID == clientID && r.tripID == tripID).FirstOrDefault();
        }



        public List<Trip> getTrips() { return DB.trips.Where(t => !t.isDeleted).ToList(); }
        public List<Client> getClients() { return DB.clients.ToList(); }
        public List<Client> getTripClients(int tripID) 
        {
            Trip t = DB.trips.Where(n => n.ID == tripID).Include("reservations.client").FirstOrDefault();
            return  t.reservations.Select(r => r.client).ToList();
        }
        public List<Reservation> getTripResrvations(int tripID) 
        {
            Trip t = getTrip(tripID);
            return t.reservations.ToList();
        }



        public bool updateTrip(Trip t) 
        {
            DB.trips.Attach(t);
            DB.Entry(t).State = EntityState.Modified;
            return DB.SaveChanges() > 0;
        }
        public bool updateClient(Client c) 
        {
            DB.clients.Attach(c);
            DB.Entry(c).State = EntityState.Modified;
            return DB.SaveChanges() > 0;
        }
        public bool updateGroup(Group g)
        {
            DB.groups.Attach(g);
            DB.Entry(g).State = EntityState.Modified;
            return DB.SaveChanges() > 0;
        }
        public bool updateTripReservations(int tripID, float newPrice)
        {
            Trip t = DB.trips.Where(n => n.ID == tripID).Include("reservations").FirstOrDefault();
            t.reservations.ToList().ForEach(r => r.priceToPay = newPrice);
            DB.trips.Attach(t);
            DB.Entry(t).State = EntityState.Modified;
            return DB.SaveChanges() > 0;
        }

        public bool updateResrvation(Reservation r)
        {
            DB.reservations.Attach(r);
            DB.Entry(r).State = EntityState.Modified;
            return DB.SaveChanges() > 0;
        }



        public bool removeTrip(Trip t) 
        {
            t.isDeleted = true;
            DB.Entry(t).State = EntityState.Modified;
            return DB.SaveChanges() > 0;
        }
        public bool removeClient(Client c)
        {
            DB.clients.Remove(c);
            return DB.SaveChanges() > 0;
        }
        public bool removeClientGroup(int clientID, int groupID)
        {
            ClientGroup cg = DB.clientGroups.Where(clientGroup => clientGroup.clientID == clientID && clientGroup.groupID == groupID).SingleOrDefault();
            DB.clientGroups.Remove(cg);
            return DB.SaveChanges() > 0;
        }
        public bool removeGroup(Group g) 
        {
            DB.groups.Remove(g);
            return DB.SaveChanges() > 0;

        }
        public bool removeResrvation(Reservation r) 
        {
            DB.reservations.Remove(r);
            return DB.SaveChanges() > 0;
        }




    }
}
