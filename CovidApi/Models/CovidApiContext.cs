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
                        SexAnswer = null,
                        AgeAnswer = null,
                        Fever = null,
                        Cough = null,
                        Sob = null,
                        YesNo = null,
                        Explanation = null,
                        DiagnosisId = 1
                    }, new Evidence
                    {
                        EvidenceId = 2,
                        Question = "What is your age?",
                        SexAnswer = null,
                        AgeAnswer = null,
                        Fever = null,
                        Cough = null,
                        Sob = null,
                        YesNo = null,
                        Explanation = null,
                        DiagnosisId = 1
                    },
                     new Evidence
                     {
                         EvidenceId = 3,
                         Question = "Do you have an underlying conditions that put you at a high risk? List all that apply.",
                         SexAnswer = null,
                         AgeAnswer = null,
                         Fever = null,
                         Cough = null,
                         Sob = null,
                         YesNo = null,
                         Explanation = null,
                         DiagnosisId = 1
                     },
                      new Evidence
                      {
                          EvidenceId = 4,
                          Question = "Do you have any of the following symptoms?",
                          SexAnswer = null,
                          AgeAnswer = null,
                          Fever = null,
                          Cough = null,
                          Sob = null,
                          YesNo = null,
                          Explanation = null,
                          DiagnosisId = 1
                      },
                      new Evidence
                      {
                          EvidenceId = 5,
                          Question = "Do you have any other symptoms? List all that apply",
                          SexAnswer = null,
                          AgeAnswer = null,
                          Fever = null,
                          Cough = null,
                          Sob = null,
                          YesNo = null,
                          Explanation = null,
                          DiagnosisId = 1
                      },
                       new Evidence
                       {
                           EvidenceId = 6,
                           Question = "Have you recently lost the ability to smell or taste?",
                           SexAnswer = null,
                           AgeAnswer = null,
                           Fever = null,
                           Cough = null,
                           Sob = null,
                           YesNo = null,
                           Explanation = null,
                           DiagnosisId = 1
                       },
                        new Evidence
                        {
                            EvidenceId = 7,
                            Question = "Please explain your current exposure level.",
                            SexAnswer = null,
                            AgeAnswer = null,
                            Fever = null,
                            Cough = null,
                            Sob = null,
                            YesNo = null,
                            Explanation = null,
                            DiagnosisId = 1
                        },
                          new Evidence
                          {
                              EvidenceId = 8,
                              Question = "Have you recently traveled?",
                              SexAnswer = null,
                              AgeAnswer = null,
                              Fever = null,
                              Cough = null,
                              Sob = null,
                              YesNo = null,
                              Explanation = null,
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