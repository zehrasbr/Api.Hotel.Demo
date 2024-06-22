using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        public BookingController(IBookingService bookingService)
        {
            _bookingService=bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBooking(Booking Booking)
        {
            _bookingService.TInsert(Booking);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetByID(id);
            _bookingService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBooking(Booking Booking)
        {
            _bookingService.TUpdate(Booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var values = _bookingService.TGetByID(id);
            return Ok(values);
        }
    }
}
