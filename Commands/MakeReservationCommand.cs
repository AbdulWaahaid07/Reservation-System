using Reservation.Exceptions;
using Reservation.Models;
using Reservation.Services;
using Reservation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Reservation.Commands
{
    public class MakereseRvationCommand : CommandBase
    {
        private readonly Organization _organization;
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly NavigationService _navigatetoReservationList;


        public MakereseRvationCommand(Organization organization, MakeReservationViewModel makeReservationViewModel, NavigationService navigatetoReservationList)
        {
            _organization = organization;
            _makeReservationViewModel = makeReservationViewModel;
            _navigatetoReservationList = navigatetoReservationList;
        }

        public override void Execute(object parameter)
        {
            Reservations currentReservation = new Reservations(
                                  new ReservedID(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
                                  _makeReservationViewModel.Username,
                                  _makeReservationViewModel.Starttime,
                                  _makeReservationViewModel.Endtime
                                               );
            try
            {
                _organization.AddReservations(currentReservation);
                MessageBox.Show("Sucessfully Reserved", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

                _navigatetoReservationList.Navigate();
            }
            catch (ReservationConflictException)
            {
                MessageBox.Show("This Time Peroid Is already Reserved", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
