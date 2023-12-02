using System;

class Program
{
    static void Main(string[] args)
    {
        Address lecAddress = new Address("510 S Center St", "Rexburg", "ID", "320 Science & Technology Center\n");
        Address recAddress = new Address("50 W Viking Drive, 525 S 1st W", "Rexburg", "ID", "BYU-Idaho Center\n");
        Address outAddress = new Address("525 S Center St", "Rexburg", "ID", "Thomas E. Ricks Gardens\n");

        List<Event> events = new List<Event>();
        events.AddRange(new List<Event>
        {
            new Lecture("Brother Carter's CSE 210 Lecture", "An excellent lecture covering everything you need to know about classes and OOP.", "December 13 @ 6pm", lecAddress, "Brother Carter", 30),

            new Reception("Brother Carter's Reception", "A reception for Brother Carter after he wins the Professor of the Year award at this year's Prof Awards.", "December 15 @ 6pm", recAddress, "rsvp@profawards.com"),

            new OutsideMtg("Brother Carter's Campfire Chat", "A campfire chat led by Brother Carter to finish out 2023.", "December 16 @ 6pm", outAddress, "Cloudy")
        });

        Console.WriteLine("====================");
        foreach (Event ev in events)
        {
            Console.WriteLine(ev.GetShortDesc());
            Console.WriteLine("--------------------");

            Console.WriteLine(ev.GetStandardDesc());
            Console.WriteLine("--------------------");

            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine("====================");
        }
    }
}