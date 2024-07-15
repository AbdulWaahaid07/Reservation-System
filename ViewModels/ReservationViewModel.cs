using Reservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservation.ViewModels
{
    public class ReservationViewModel : ViewModelBase
    {

        public string ID => _reservations.ID.ToString();

        public string Username => _reservations.Username;

        public string StartTime => _reservations.StartTime.ToString("d");

        public string EndTime => _reservations.EndTime.ToString("d");


        public readonly Reservations _reservations;

        public ReservationViewModel(Reservations reservations)
        {
            _reservations = reservations;
        }


        public ICommand MakereseRvationCommand { get; }

    }
}
