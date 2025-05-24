using Tutorial5.Models;

namespace Tutorial5.Services;

public interface IDbService
{
    Task<IEnumerable<Doctor>> GetDoctorsAsync();
    Task<Doctor?> GetDoctorAsync(int id);
    Task AddDoctorAsync(Doctor doctor);
}