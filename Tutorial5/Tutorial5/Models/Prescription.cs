using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutorial5.Models;

[Table("Prescription")]
public class Prescription
{
    [Key]
    public int IdPrescription { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public DateTime DueDate { get; set; }

    [Required]
    [ForeignKey("Patient")]
    public int IdPatient { get; set; }
    
    public virtual Patient Patient { get; set; }

    [Required]
    [ForeignKey("Doctor")]
    public int IdDoctor { get; set; }
    
    public virtual Doctor Doctor { get; set; }
    public virtual ICollection<PrescriptionMedicament> PrescriptionMedicament { get; set; } = new List<PrescriptionMedicament>(); 
}