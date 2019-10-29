using System;
using Aula142ExcecaoPersonalizada.Entities;
using Aula142ExcecaoPersonalizada.Entities.Exceptions;

namespace Aula142ExcecaoPersonalizada
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine(reservation);

                Console.WriteLine();
                Console.WriteLine("Enter date to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Erro na reserva {e.Message}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
    }
}
