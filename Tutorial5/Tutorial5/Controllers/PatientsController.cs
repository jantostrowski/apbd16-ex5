using Microsoft.AspNetCore.Mvc;
using Tutorial5.Data;
using Tutorial5.Models;

namespace Tutorial5.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PatientsController : ControllerBase
{
    private readonly DatabaseContext _context;
    public PatientsController(DatabaseContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetPatients()
    {
        var patients = _context.Patients.ToList();
        return Ok(patients);
    }

    [HttpPost]
    public async Task<IActionResult> AddPatient(Patient patient)
    {
        _context.Patients.Add(patient);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetPatients), new { id = patient.IdPatient }, patient);
    }
}