using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace CovidApi.Models
{
    public class CovidApiContext : DbContext
    {
        public CovidApiContext(DbContextOptions<CovidApiContext> options) : base(options)
        {
        }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Evidence> Evidences { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Evidence>()
                .HasData(
                    new Evidence
                    {
                        EvidenceId = 1,
                        Question = "What is your sex?",
                        MultipleAnswer = false,
                        Answer = "Female",
                        Explanation = "none",
                        DiagnosisId = 1
                    }
                );
            builder.Entity<Diagnosis>()
                .HasData(
                    new Diagnosis
                    {
                        DiagnosisId = 1,
                        Sex = "Female",
                        Age = 20
                    }
                );
        }
    }
}