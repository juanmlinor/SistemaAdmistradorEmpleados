using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        //RelationShip One to Many
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }
    }
}
