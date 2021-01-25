using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace BeMyGuest.Models
{
    public class Guest
    {
        public Guest()
        {
            this.Hosts = new HashSet<Gathering>();
            this.Events = new HashSet<Gathering>();
        }

        // Guest Info
        public int GuestId { get; set; }
        public string Name { get; set; }
        public string Pronouns { get; set; }
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
        public bool PlusOne { get; set; } = false;
        public bool SmallChildren { get; set; } = false;
        //public virtual ICollection <Pod> PodMates { get; set; } // stretch

        //Lists
        public virtual ICollection<Gathering> Guests { get; set; }
        //covid ID
    }
}