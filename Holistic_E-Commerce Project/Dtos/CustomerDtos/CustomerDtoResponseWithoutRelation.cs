using System.ComponentModel.DataAnnotations;

namespace Holistic_E_Commerce_Project.Dtos.CustomerDtos
{
    public class CustomerDtoResponseWithoutRelation
    {
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Contact { get; set; }
    }
}
