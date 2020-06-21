using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.DTOs.Requests;
using cw11.Models;
using cw11.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorDbService _service;

        public DoctorsController(IDoctorDbService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_service.GetDoctors());
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            _service.DeleteDoctor(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateDoctor(Doctor doctor)
        {
            _service.CreateDoctor(doctor);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDoctor(UpdateDoctorRequest request, int id)
        {
            _service.UpdateDoctor(request, id);
            return Ok();
        }
    }
}
