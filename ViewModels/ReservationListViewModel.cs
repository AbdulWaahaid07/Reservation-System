using Reservation.Commands;
using Reservation.Models;
using Reservation.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservation.ViewModels
{
    public class ReservationListViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ReservationViewModel> _reservation = new ObservableCollection<ReservationViewModel>();
        public IEnumerable<ReservationViewModel> Reservation => _reservation;
        
        public Organization Organization { get; }

        
        public ReservationListViewModel(Organization _organization, NavigationService navigatetoMakeReservation)
        {
            Organization = _organization;

            openMakeReservationCommand = new NavigateCommand(navigatetoMakeReservation);

            updateReservation();
        }

        private void updateReservation()
        {
            _reservation.Clear();

            foreach (Reservations reservation in Organization.GetAllReservations()) 
            {
                ReservationViewModel reachReservation = new ReservationViewModel(reservation);
                _reservation.Add(reachReservation);
            }
        }


        // COMMANDS -------------------------------------------------------------------------------
        public ICommand openMakeReservationCommand { get; }

    }

}
