using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class GeneralDepartment : BaseEntity 
    {
        //Many to one relationship with Department
       // [JsonIgnore]
       // public List<Department>? Departments { get; set; }
    }
}
