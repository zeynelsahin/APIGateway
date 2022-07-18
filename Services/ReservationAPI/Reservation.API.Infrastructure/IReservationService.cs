using Reservation.API.Models;

namespace Reservation.API.Infrastructure;

public interface IReservationService
{
    public ReservationDTO GetByBookingNumber(int bookingNumber);
}