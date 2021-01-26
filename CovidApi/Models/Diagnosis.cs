using System.Collections.Generic;
using System.Collections;

namespace CovidApi.Models
{
    public class Diagnosis
    {
        public Diagnosis()
        {
            this.Evidences = new HashSet<Evidence>();
        }
        public int DiagnosisId { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public ICollection<Evidence> Evidences { get; set; }
    }
}