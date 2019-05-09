using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP11
{
    class Concert
    {

        public int ConcertID { get; set; }
        public string Group { get; set; }
        public DateTime ConcertDate { get; set; }
        public int DayOfWeek { get; set; }
        public int TicketsVIPZone { get; set; }
        public int TicketsFanZone { get; set; }
        public int TicketsDanceZone { get; set; }
        public int TicketsTribuneZone { get; set; }

        public Concert(string group, DateTime concertDate, int ticketVIP, int ticketFan, int ticketDance, int ticketTribune)
        {
            Group = group;
            ConcertDate = concertDate;
            switch(concertDate.DayOfWeek)
            {
                case System.DayOfWeek.Monday: DayOfWeek = 0;
                    break;
                case System.DayOfWeek.Tuesday: DayOfWeek = 1;
                    break;
                case System.DayOfWeek.Wednesday: DayOfWeek = 2;
                    break;
                case System.DayOfWeek.Thursday: DayOfWeek = 3;
                    break;
                case System.DayOfWeek.Friday: DayOfWeek = 4;
                    break;
                case System.DayOfWeek.Saturday: DayOfWeek = 5;
                    break;
                case System.DayOfWeek.Sunday: DayOfWeek = 6;
                    break;
                default: DayOfWeek = -1;
                    break;
            }
            TicketsVIPZone = ticketVIP;
            TicketsFanZone = ticketFan;
            TicketsTribuneZone = ticketTribune;
            TicketsDanceZone = ticketDance;
        }
    }
}
