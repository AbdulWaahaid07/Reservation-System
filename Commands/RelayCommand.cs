using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Commands
{
    public class RelayCommand<T> : CommandBase
    {

        private readonly Action<T> _action;

        public RelayCommand(Action<T> action)
        {
            _action = action ?? throw new ArgumentNullException(nameof(action), "Empty Method");
        }

        public override void Execute(object parameter)
        {
            _action((T)parameter);
        }
    }
}
