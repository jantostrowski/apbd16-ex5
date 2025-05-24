using Microsoft.AspNetCore.Mvc;
using Tutorial5.Data;
using Tutorial5.Models;

namespace Tutorial5.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MedicamentsController : ControllerBase
{
    private readonly DatabaseContext _context;
    public MedicamentsController(DatabaseContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetMedicaments()
    {
        var medicaments = _context.Medicaments.ToList();
        return Ok(medicaments);
    }

    [HttpPost]
    public async Task<IActionResult> AddMedicament(Medicament medicament)
    {
        _context.Medicaments.Add(medicament);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetMedicaments), new { id = medicament.IdMedicament }, medicament);
    }
}