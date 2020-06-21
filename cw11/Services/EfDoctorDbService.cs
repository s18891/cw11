using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.DTOs.Requests;
using cw11.Models;

namespace cw11.Services
{
    public class EfDoctorDbService : IDoctorDbService
    {
        private readonly DoctorDbContext _context;
        public EfDoctorDbService(DoctorDbContext context)
        {
            _context = context;
        }

        public void CreateDoctor(Doctor doctor)
        {
            _context.Doctor.Add(doctor);
            _context.SaveChanges();
        }

        public void DeleteDoctor(int id)
        {
            var doctorToDelete = _context.Doctor.FirstOrDefault(e => e.IdDoctor == id);
            _context.Doctor.Remove(doctorToDelete);
            _context.SaveChanges();
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            return _context.Doctor.ToList();
        }

        public void UpdateDoctor(UpdateDoctorRequest request, int id)
        {
            var doctor = new Doctor();
            doctor.IdDoctor = id;
            _context.Attach(doctor);
            var firstName = request.FirstName;
            var lastName = request.LastName;
            var email = request.Email;
            var entry = _context.Entry(doctor);
            if (firstName != null)
            {
                doctor.FirstName = firstName;
                entry.Property("FirstName").IsModified = true;
            }
            if (lastName != null)
            {
                doctor.LastName = lastName;
                entry.Property("LastName").IsModified = true;
            }
            if (email != null)
            {
                doctor.Email = email;
                entry.Property("Email").IsModified = true;
            }
            _context.SaveChanges();
        }
    }
}
