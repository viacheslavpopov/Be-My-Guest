namespace CovidApi.Models
{
    public class Evidence
    {
        public int EvidenceId { get; set; }
        public string Question { get; set; }
        public string SexAnswer { get; set; }
        public int? AgeAnswer { get; set; }
        public bool? Fever { get; set; }
        public bool? Cough { get; set; }
        public bool? Sob { get; set; }
        public bool? YesNo { get; set; }
        public string Explanation { get; set; }
        public int? DiagnosisId { get; set; }
        public Diagnosis Diagnosis { get; set; }
    }
}