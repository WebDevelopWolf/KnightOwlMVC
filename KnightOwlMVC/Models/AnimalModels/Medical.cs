using System;

namespace KnightOwlMVC.Models.AnimalModels
{
    public class Medical
    {
        public int MedicalId { get; set; }

        public DateTime TreatmentDate { get; set; }

        public string TreatmentType { get; set; }

        public string MedicationsAdministered { get; set; }

        public int Dosage { get; set; }

        public string AffectedAreaOrIllness { get; set; }

        public string Notes { get; set; }

        public string OutComeOrChange { get; set; }

        public virtual AnimalModels.Animal AnimalId { get; set; }
    }
}