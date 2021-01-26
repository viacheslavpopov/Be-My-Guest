namespace CovidApi.Models
{
    public class Evidence
    {
        public int EvidenceId { get; set; }
        public string Question { get; set; }
        public bool MultipleAnswer { get; set; }
        public string Answer { get; set; }
        public string Explanation { get; set; }
        public int? DiagnosisId { get; set; }
        public Diagnosis Diagnosis { get; set; }
    }
}