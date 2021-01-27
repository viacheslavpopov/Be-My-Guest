using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace BeMyGuest.Models
{
    public class Guest
    {
        public Guest()
        {
            this.JoinEntries = new HashSet<Gathering>();
        }

        // Guest Info
        public int GuestId { get; set; }
        public string Name { get; set; }
        public string Pronouns { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        // public string Phone { get; set; } // Stretch for instant contact tracing

        // Covid Screening & Medical Requirements
        public bool Vaccinated { get; set; } = false;
        [Display(Name = "High Risk")]
        public bool HighRisk { get; set; } = false;
        [Display(Name = "Recent Travel")]
        public bool RecentTravel { get; set; } = false;
        [Display(Name = "Completed the Questionnaire")]
        public bool CompletedQuestionnaire { get; set; } = false;
        [Display(Name = "Medical Mobility Needs")]
        public string MedicalMobilityNeeds { get; set; }
        [Display(Name = "Medical Conditions")]
        public string MedicalConditions { get; set; }
        [Display(Name = "Service Animal")]
        public bool ServiceAnimal { get; set; } = true;

        // Food, Drink, & Misc.
        [Display(Name = "Dietary Restrictions")]
        public string DietaryRestrictions { get; set; }
        public string Allergies { get; set; }
        [Display(Name = "Preferred Language")]
        public string PreferredLanguage { get; set; }
        [Display(Name = "Alcohol Free")]
        public bool AlcoholFree { get; set; } = false;
        [Display(Name = "Not-a-Hugger")]
        public bool NotAHugger { get; set; } = false;

        // Group Connections
        [Display(Name = "Plus One(s) in Tow")]
        public bool PlusOne { get; set; } = false;
        [Display(Name = "Small Children in Tow")]
        public bool SmallChildren { get; set; } = false;
        //public virtual ICollection <Pod> PodMates { get; set; } // stretch

        //Outside Table Data
        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Gathering> JoinEntries { get; set; }
        public int? CovidDataId { get; set; }
        public virtual CovidData CovidData { get; set; }
    }
}