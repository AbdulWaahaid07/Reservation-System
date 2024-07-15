using Reservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Exceptions
{
    public class ReservationConflictException : Exception
    {
        public Reservations CurrentReservation { get; }

        public Reservations InputReservation { get; }

        public ReservationConflictException(Reservations currentReservation, Reservations inputReservation)
        {
            CurrentReservation = currentReservation;
            InputReservation = inputReservation;
        }

        public ReservationConflictException(string message, Reservations currentReservation, Reservations inputReservation) : base(message)
        {
            CurrentReservation = currentReservation;
            InputReservation = inputReservation;
        }

        public ReservationConflictException(string message, Exception innerException, Reservations currentReservation, Reservations inputReservation) : base(message, innerException)
        {
            CurrentReservation = currentReservation;
            InputReservation = inputReservation;
        }

    }
}
