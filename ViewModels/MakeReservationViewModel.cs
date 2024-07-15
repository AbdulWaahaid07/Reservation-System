using Reservation.Commands;
using Reservation.Models;
using Reservation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Reservation.ViewModels
{
    public class MakeReservationViewModel : ViewModelBase
    {

        // Username
        private string _username;
        public string Username
        {
            get { return _username; }

            set { _username = value; OnPropertyChanged(nameof(Username)); }
        }



        //Floor NUmber
        private int _floornumber;
        public int FloorNumber
        {
            get { return _floornumber; }

            set { _floornumber = value; OnPropertyChanged(nameof(FloorNumber)); }
        }



        //Room Number
        private int _roomnumber;
        public int RoomNumber
        {
            get { return _roomnumber; }
            set { _roomnumber = value; OnPropertyChanged(nameof(RoomNumber)); }

        }



        // StartTime
        private DateTime _starttime =  DateTime.Now;
        public DateTime Starttime
        {
            get { return _starttime; }
            set { _starttime = value; OnPropertyChanged(nameof(Starttime)); }
        }



        //EndTIme
        private DateTime _endtime = DateTime.Now;
        public DateTime Endtime
        {
            get { return _endtime; }
            set { _endtime = value; OnPropertyChanged(nameof(Endtime)); }
        }


        public MakeReservationViewModel(Organization organization, NavigationService navigatetoReservationList)
        {
            SubmitCommand = new MakereseRvationCommand(organization, this, navigatetoReservationList);

            CancelCommand = new NavigateCommand(navigatetoReservationList);
        }


        public ICommand SubmitCommand { get; }

        public ICommand CancelCommand { get; }

    }
}
