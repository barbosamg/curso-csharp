using System;
using System.Collections.Generic;
using System.Text;
using Aula142ExcecaoPersonalizada.Entities.Exceptions;

namespace Aula142ExcecaoPersonalizada.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("A data de chek-out não pode ser menor do que a data de check-in");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("As datas de reserva nao pode ser menor que a data atual");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("A data de chek-out não pode ser menor do que a data de check-in");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return $"Room {RoomNumber}, check-in: {CheckIn.ToString("dd/MM/yyyy")}, check-ou: {CheckOut.ToString("dd/MM/yyyy,")}, {Duration()} nights";
        }
    }
}
