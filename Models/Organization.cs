using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Models
{
    public class Organization
    {
        private readonly ReservationRecord reservationRecord = new ReservationRecord();

        public string OrganizationName { get; }

        public Organization(string _name)
        {
            OrganizationName = _name;
        }

        public IEnumerable<Reservations> GetReservations(string _nameInput) 
        {
            return reservationRecord.GetReservations(_nameInput);
        }

        public IEnumerable<Reservations> GetAllReservations()
        {
            return reservationRecord.GetAllReservations();
        }

        public void AddReservations(Reservations reservationInput) 
        {
            reservationRecord.AddReservations(reservationInput);
        }

    }
}
