using System.ComponentModel.DataAnnotations;

namespace PeopleInspection.ViewModels
{
    public class CreatePersonViewModel
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string City { get; set; } = string.Empty;
    }
}


