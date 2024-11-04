using System.ComponentModel.DataAnnotations;

namespace HospitalPatientAPI.Entities
{
    public class Patient
    {
        public int Id {  get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required]

        public string Gender { get; set; }
        [Required]

        public string ContactInfo { get; set; }
    }
}
