using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Models
{
    public class Reservations
    {

        public ReservedID ID { get; }

        public string Username { get; }

        public DateTime StartTime { get; }

        public DateTime EndTime { get; }

        public TimeSpan Reservedtime => EndTime.Subtract(StartTime);

        public Reservations(ReservedID iD, string username, DateTime startTime, DateTime endTime)
        {
            ID = iD;
            Username = username;
            StartTime = startTime;
            EndTime = endTime;
        }

        public bool Conflicts(Reservations reservationInput)
        {
            if (reservationInput.ID != ID) 
            {
                return false;
            }

            return reservationInput.StartTime > StartTime || reservationInput.StartTime < EndTime;

            //    && reservationInput.EndTime > StartTime || reservationInput.EndTime < EndTime;
        }
    }
}
