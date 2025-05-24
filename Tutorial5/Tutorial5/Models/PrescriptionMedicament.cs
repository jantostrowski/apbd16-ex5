using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutorial5.Models;

[Table("Prescription_Medicament")]
public class PrescriptionMedicament
{
    [Key]
    [ForeignKey("Medicament")]
    public int IdMedicament { get; set; }

    public virtual Medicament Medicament { get; set; }

    [Key]
    [ForeignKey("Prescription")]
    public int IdPrescription { get; set; }

    public virtual Prescription Prescription { get; set; }

    [Required]
    [MaxLength(128)]
    public string Dosage { get; set; } = null!;

    [MaxLength(256)]
    public string Details { get; set; } = null!;
}