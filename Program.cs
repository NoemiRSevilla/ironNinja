using System;
using IronNinja.Classes;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet world = new Buffet();
            SweetTooth Gary = new SweetTooth();
            SpiceHound Marco = new SpiceHound();
            Gary.Consume(world.Serve());
        }
    }
}
