namespace PetShelter_StepbyStep_Guide.ViewModels
{
    public class LocationDetailsVM : BaseVM
    {
        public string City { get; set; }

        public string Address { get; set; }

        public string Country { get; set; }

        public int ShelterId { get; set; }

        public ShelterDetailsVM Shelter { get; set; }
        public int Id { get; set; }
    }
}
