using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace HospitalPatientAPI.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        [Required]

        public string Speciality { get; set; }
        public string ContactInfo { get; set; }
    }
}
