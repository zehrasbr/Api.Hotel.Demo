﻿using HotelProject.BusinessLayer.Abstract;
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
        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var values = _bookingService.TGetByID(id);
            _bookingService.TDelete(values);
            return Ok();
        }
        [HttpPut("UpdateBooking")]
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
        [HttpPut("aaaaa")]
        public IActionResult aaaaa(Booking booking)
        {
            _bookingService.TBookingStatusChangeApproved(booking);
            return Ok();
        }
        [HttpPut("bbbbb")]
        public IActionResult bbbbb(int id)
        {
            _bookingService.TBookingStatusChangeApproved2(id);
            return Ok();
        }
        //[HttpGet("Last6Booking")]
        //public IActionResult Last6Booking()
        //{
        //    var values = _bookingService.TLast6Bookings();
        //    return Ok(values);
        //}

        //[HttpGet("BookingAproved")]
        //public IActionResult BookingAproved(int id)
        //{
        //    _bookingService.TBookingStatusChangeApproved3(id);
        //    return Ok();
        //}

        //[HttpGet("BookingCancel")]
        //public IActionResult BookingCancel(int id)
        //{
        //    _bookingService.TBookingStatusChangeCancel(id);
        //    return Ok();
        //}
        //[HttpGet("BookingWait")]
        //public IActionResult BookingWait(int id)
        //{
        //    _bookingService.TBookingStatusChangeWait(id);
        //    return Ok();
        //}
    }
}
