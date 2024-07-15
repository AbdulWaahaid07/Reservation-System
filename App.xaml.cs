using Reservation.Exceptions;
using Reservation.Models;
using Reservation.Services;
using Reservation.Stores;
using Reservation.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Reservation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly Organization _organization;
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _organization = new Organization("Baka");
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = CreateMakeReservationViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };

            MainWindow.Show();

            base.OnStartup(e);
        }

        private MakeReservationViewModel CreateMakeReservationViewModel() 
        {
           return new MakeReservationViewModel(_organization, new NavigationService(_navigationStore, CreateReservationListViewModel));
        }

        private ReservationListViewModel CreateReservationListViewModel() 
        {
            return new ReservationListViewModel(_organization, new NavigationService(_navigationStore, CreateMakeReservationViewModel));
        }
    }
}
