using Microsoft.EntityFrameworkCore;
using Tutorial5.Data;
using Tutorial5.Models;

namespace Tutorial5.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;
    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Doctor>> GetDoctorsAsync()
    {
        return await _context.Doctors.ToListAsync();
    }

    public async Task<Doctor?> GetDoctorAsync(int id)
    {
        return await _context.Doctors.FindAsync(id);
    }

    public async Task AddDoctorAsync(Doctor doctor)
    {
        _context.Doctors.Add(doctor);
        await _context.SaveChangesAsync();
    }
}