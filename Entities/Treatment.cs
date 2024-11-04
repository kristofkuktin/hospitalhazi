using System.Text.Json.Serialization;

namespace HospitalPatientAPI.Entities
{
    public class Treatment
    {
        public int Id {  get; set; }
        public int PatientId { get; set; }
        public int DoctorId {  get; set; }

        public string TreatmentDetails {  get; set; }
        public DateTime TreatmentDate { get; set; }
        public DateTime? EndDate {  get; set; }

        [JsonIgnore]
        public Patient Patient { get; set; }
        [JsonIgnore]
        public Doctor Doctor { get; set; }
    }
}
