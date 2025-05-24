using Microsoft.AspNetCore.Mvc;
using Tutorial5.Models;
using Tutorial5.Services;

namespace Tutorial5.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DoctorsController : ControllerBase
{
    private readonly IDbService _dbService;

    public DoctorsController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet]
    public async Task<IActionResult> GetDoctors()
    {
        var doctors = await _dbService.GetDoctorsAsync();
        return Ok(doctors);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetDoctor(int id)
    {
        var doctor = await _dbService.GetDoctorAsync(id);
        if (doctor == null)
            return NotFound();

        return Ok(doctor);
    }

    [HttpPost]
    public async Task<IActionResult> AddDoctor(Doctor doctor)
    {
        await _dbService.AddDoctorAsync(doctor);
        return CreatedAtAction(nameof(GetDoctor), new { id = doctor.IdDoctor }, doctor);
    }
}