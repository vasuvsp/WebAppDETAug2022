using APIDemo.Models;

namespace APIDemo.Services
{
    public static class TicketService
    {
        static List<Ticket> Tickets { get; }
        static int nextId = 3;
        static TicketService()
        {
            Tickets = new List<Ticket>
                {
                    new Ticket { ID = 1, BookedFor= "PlatinumPlus", Price=2000,Qty=20 },
                    new Ticket { ID = 11, BookedFor= "Platinum", Price=789,Qty=56},
                    new Ticket { ID = 12, BookedFor= "Gold", Price=500,Qty=27 },
                    new Ticket { ID = 14, BookedFor= "Silver", Price=6000,Qty=89 },
                  new Ticket { ID = 20, BookedFor= "general", Price=200,Qty=30 },
                  new Ticket { ID = 31, BookedFor= "Classic Italian", Price=789,Qty=79 }
                };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(x => x.ID == id);
            return ticket;

        }
    }
}