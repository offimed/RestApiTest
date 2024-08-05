namespace RestApiTest.Models
{
    public class Patient : IEquatable<Patient?>
    {
        public int Niss { get; set; }
        public string PatientName { get; set; }
        public string PatientCity { get; set; }

        public Patient(int niss, string patientName, string patientCity)
        {
            Niss = niss;
            PatientName = patientName;
            PatientCity = patientCity;
        }

        public Patient()
        {
            Niss = 0;
            PatientName = String.Empty;
            PatientCity = String.Empty;
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Patient);
        }

        public bool Equals(Patient? other)
        {
            return other is not null &&
                   Niss == other.Niss &&
                   PatientName == other.PatientName &&
                   PatientCity == other.PatientCity;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
