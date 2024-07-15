using Reservation.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Models
{
    public class ReservationRecord
    {
        private readonly List<Reservations> reservations = new List<Reservations>();

        public IEnumerable<Reservations> GetReservations(string _nameInput) 
        {
            return reservations.Where(r => r.Username == _nameInput);
        }

        public IEnumerable<Reservations> GetAllReservations()
        {
            return reservations;
        }

        public void AddReservations(Reservations reservationInput) 
        {
            foreach(Reservations exsistingreservation in reservations) 
            {
                if (exsistingreservation.Conflicts(reservationInput)) 
                {
                    throw new ReservationConflictException(exsistingreservation, reservationInput);
                }
            }

            reservations.Add(reservationInput);
        }
    }
}
