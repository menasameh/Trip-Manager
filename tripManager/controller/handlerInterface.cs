using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tripManager.model;

namespace tripManager.controller
{
    public interface handlerInterface
    {
        bool insertTrip(Trip t);
        bool insertClient(Client c);
        bool insertTripGroup(Trip t, Group g);
        bool insertResrvation(Reservation r);


        Trip getTrip(int tripID);
        Client getClient(string name);
        Group getGroup(int groupID);
        Reservation getReservation(string clientName, string tripName);
        Reservation getReservation(int clientID, int tripID);


        List<Trip> getTrips();
        List<Client> getTripClients(int tripID);
        List<Group> getTripGroups(int tripID);
        List<Reservation> getTripResrvations(int tripID);


        bool updateTrip(Trip t);
        bool updateClient(Client c);
        bool updateGroup(Group g);
        bool updateResrvation(Reservation r);

        bool removeTrip(Trip t);
        bool removeClient(Client c);
        bool removeGroup(Group g);
        bool removeResrvation(Reservation r);
    }
}
