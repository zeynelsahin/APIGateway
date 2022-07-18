using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;
using Reservation.API.Models;

namespace ReservationAPI.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class ReservationController : Controller
{
    private readonly IReservationService _reservationService;

    public ReservationController(IReservationService reservationService)
    {
        _reservationService = reservationService;
    }

    [HttpGet("{id:int}")]
    public ReservationDTO GetReservationBookingNumber(int bookingNumber)
    {
        return _reservationService.GetByBookingNumber(bookingNumber);
    }
}