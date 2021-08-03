using System.ComponentModel.DataAnnotations.Schema;

namespace Centoreal.Entities.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
