﻿using System.Xml.Linq;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Services
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; set; }
        
        static TicketService()
        {
            //Tickets = new List<Ticket>
            //{
            //    new Ticket {Category="PlatinumPlus",Price=5000,MaxLimit=200000},
            //    new Ticket {Category="Platinum",Price=4000,MaxLimit=300000},
            //    new Ticket {Category="Glod",Price=3000,MaxLimit=500000},
            //    new Ticket {Category="Silver",Price=2000,MaxLimit=500000},
            //    new Ticket {Category="General",Price=800,MaxLimit=1000000}
            //};
        }
        public static List<Ticket> GetAll() => Tickets;
     
    }
}
