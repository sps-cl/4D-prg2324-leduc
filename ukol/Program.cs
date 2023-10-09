using System;
using EventApp;
using EventApp.Models;

public class Program {

    public static void Main(string[] args) {
        
        Guest guest1 = new Guest("Jack", "Sparrow", 38);
        Guest guest2 = new Guest("Jim", "Beam", 228);
        Guest guest3 = new Guest("Bruce", "Lee", 32);
        Guest guest4 = new Guest("Tony", "Stark", 53);

        Performer performer1 = new Performer("Harry", "Styles", 29, "singer");
        Performer performer2 = new Performer("Josh", "Devine", 32, "drummer");
        Performer performer3 = new Performer("Dan", "Richards", 35, "guitarist");

        Event event1 = new Event("Fireworks", "A firework show outside");

        event1.AddAtendee(guest1);
        event1.AddAtendee(guest2);
        event1.AddAtendee(guest3);

        event1.AddAtendee(performer1);
        event1.AddAtendee(performer2);
        event1.AddAtendee(performer3);
        
        guest1.processInvitation(true);
        guest2.processInvitation(false);

        event1.DisplayPerformers();
        Console.WriteLine("");
        event1.DisplayGuests();
        Console.WriteLine("");

        event1.RemoveAtendee("Jim", "Beam");
        event1.RemoveAtendee("Josh", "Devine");

        event1.DisplayPerformers();
        Console.WriteLine("");
        event1.DisplayGuests();

        Console.ReadLine();
    }

}