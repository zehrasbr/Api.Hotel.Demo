using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        public StaffController(IStaffService staffService)
        {
            _staffService=staffService;
        }

        [HttpGet]
        public IActionResult StaffList()
        {
            var values = _staffService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            _staffService.TInsert(staff);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteStaff()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateStaff()
        {
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetStaff()
        {
            return Ok();
        }
    }
}
