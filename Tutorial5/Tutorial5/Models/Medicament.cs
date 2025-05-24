using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutorial5.Models;

[Table("Medicament")]
public class Medicament
{
    [Key]
    public int IdMedicament { get; set; }

    [Required]
    [MaxLength(128)]
    public string Name { get; set; } = null!;

    [Required]
    [MaxLength(512)]
    public string Description { get; set; } = null!;

    [Required]
    [MaxLength(128)]
    public string Type { get; set; } = null!;
    public virtual ICollection<PrescriptionMedicament> PrescriptionMedicament { get; set; } = new List<PrescriptionMedicament>();
}