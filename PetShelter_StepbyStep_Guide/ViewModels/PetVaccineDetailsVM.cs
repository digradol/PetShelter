namespace PetShelter_StepbyStep_Guide.ViewModels
{
    public class PetVaccineDetailsVM : BaseVM
    {

        public PetDetailsVM Pet { get; set; }
        public VaccineDetailsVM Vaccine { get; set; }

        public int PetId { get; set; }
        public int VaccineId { get; set; }

        public int Id { get; set; }
    }
}
