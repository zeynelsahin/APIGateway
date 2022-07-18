using Reservation.API.Infrastructure;
using Reservation.API.Models;

namespace Reservation.API.Services;

public class ReservationService : IReservationService
{
    public ReservationDTO GetByBookingNumber(int bookingNumber)
    {
        return new ReservationDTO
        {
            BookingNumber = bookingNumber,
            Amount = new Random().Next(0, 100),
            Id = new Random().Next(1000),
            BookingDate = DateTime.Now.AddDays(20),
            CheckinDate = DateTime.Now.AddDays(21),
            CheckoutDate = DateTime.Now.AddDays(50)
        };
    }
}