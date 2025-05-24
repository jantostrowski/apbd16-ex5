using System.ComponentModel.DataAnnotations;

namespace Tutorial5.DTOs;

public class CreatePrescriptionDto
{
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    public int IdPatient { get; set; }
    public int IdDoctor { get; set; }

    [MinLength(1)]
    public List<PrescribeMedicamentDto> Medicaments { get; set; }
}