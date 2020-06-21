using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.DTOs.Requests;
using cw11.Models;

namespace cw11.Services
{
    public interface IDoctorDbService
    {
        public IEnumerable<Doctor> GetDoctors();
        public void DeleteDoctor(int id);
        public void CreateDoctor(Doctor doctor);
        public void UpdateDoctor(UpdateDoctorRequest request, int id);
    }
}
