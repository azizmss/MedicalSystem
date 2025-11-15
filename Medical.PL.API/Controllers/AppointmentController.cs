using Medical.Application.DTO;
using Medical.Application.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Medical.PL.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AppointmentController : ControllerBase
{

    public IAppointmentService _service;
    public AppointmentController(IAppointmentService service)
    {
        _service=service;
    }
    [HttpPost]
    public async Task<IActionResult> CreateAppointment([FromBody] AppointmentDTO dto)
    {
        await _service.CreateAppointment(dto);
        return Ok("Appointment created Successfully");
    }
}
