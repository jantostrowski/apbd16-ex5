using Tutorial5.Models;

namespace Tutorial5.Data;

public static class SampleData
{
    public static void Seed(DatabaseContext context)
    {
        if (context.Doctors.Any() || context.Patients.Any() || context.Medicaments.Any() || context.Prescriptions.Any())
            return;

        var doctor1 = new Doctor
        {
            FirstName = "Anna",
            LastName = "Nowak",
            Email = "annanowak@medinet.pl"
        };

        var doctor2 = new Doctor
        {
            FirstName = "Jakub",
            LastName = "Kubacki",
            Email = "jakubkubacki@medinet.pl"
        };

        var patient1 = new Patient
        {
            FirstName = "Franz",
            LastName = "Maurer",
            Email = "franzmaurer@wp.pl",
            Birthdate = new DateTime(1965, 5, 1)
        };

        var patient2 = new Patient
        {
            FirstName = "Olo",
            LastName = "Żwirski",
            Email = "olo@bolo.pl",
            Birthdate = new DateTime(1970, 8, 12)
        };

        var medicament1 = new Medicament
        {
            Name = "Apap Noc",
            Description = "Paracetamol 500 mg",
            Type = "tabletka"
        };

        var medicament2 = new Medicament
        {
            Name = "Hepaslimin",
            Description = "Czysta żółć 100 mg",
            Type = "syrop"
        };

        var prescription1 = new Prescription
        {
            Date = DateTime.Now,
            DueDate = DateTime.Now.AddDays(30),
            Doctor = doctor1,
            Patient = patient1
        };

        var prescription2 = new Prescription
        {
            Date = DateTime.Now,
            DueDate = DateTime.Now.AddDays(90),
            Doctor = doctor2,
            Patient = patient2
        };

        var pm1 = new PrescriptionMedicament
        {
            Prescription = prescription1,
            Medicament = medicament1,
            Dosage = "2x dziennie",
            Details = "W trakcie posiłku"
        };

        var pm2 = new PrescriptionMedicament
        {
            Prescription = prescription1,
            Medicament = medicament2,
            Dosage = "1x dziennie",
            Details = "Na czczo"
        };

        var pm3 = new PrescriptionMedicament
        {
            Prescription = prescription2,
            Medicament = medicament1,
            Dosage = "3x dziennie",
            Details = "30 minut po posiłku"
        };

        context.AddRange(doctor1, doctor2, patient1, patient2, medicament1, medicament2, prescription1, prescription2, pm1, pm2, pm3);
        context.SaveChanges();
    }
}