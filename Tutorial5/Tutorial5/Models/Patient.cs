using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tutorial5.Models;

[Table("Patient")]
public class Patient
{
    [Key]
    public int IdPatient { get; set; }

    [Required]
    [MaxLength(128)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(128)]
    public string LastName { get; set; }

    [Required]
    public DateTime Birthdate { get; set; }
    
    [Required]
    [MaxLength(150)]
    public string Email { get; set; }
    
    public virtual ICollection<Prescription> Prescriptions { get; set; }
}