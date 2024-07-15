using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.Models
{
    public class ReservedID
    {

        public int FloorNumber { get; set; }
        public int RoomNumber { get; set; }




        public ReservedID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;

            RoomNumber = roomNumber;        
         }


        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }


        public override bool Equals(object obj)
        {
            return obj is ReservedID rid && 
                rid.FloorNumber == FloorNumber && 
                rid.RoomNumber == RoomNumber;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }


        public static bool operator ==(ReservedID id1, ReservedID id2) 
        {
            if (id1 is null && id2 is null) 
            {
                return true; 
            }

            return !(id1 is null) && id1.Equals(id2);
        }
        
        public static bool operator !=(ReservedID id1, ReservedID id2) 
        {            
            return !(id1 == id2);
        }
    }
}
