using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.Entities
{
    public class Employee : BaseEntity
    {
        [Required]
        public string? CivilId { get; set; }= string.Empty;
        [Required]
        public string? FileNumber { get; set; }= string.Empty;
        [Required]
        public string? FullName { get; set; } = string.Empty;
        [Required]
        public string? JobName { get; set; }= string.Empty;
        [Required]
        public string? Address { get; set; }= string.Empty;

        [Required, DataType(DataType.PhoneNumber)]
        public string? TelephoneNumber { get; set; }= string.Empty;
        [Required]
        public string? Photo { get; set; }= string.Empty;
        public string? Other { get; set; }

        //RelationsShi: Many to One
         public GeneralDepartment? GeneralDepartment { get; set; }
  public int GeneralDepartmentsId { get; set; }
         public Department? Department { get; set; }
         public int DepartmentId { get; set; }
        //Many to one relationShip with Branch
         public Branch? Branch { get; set; }
        public int BranchId { get; set; }
         public Town? Town { get; set; }
        public int TownId { get; set;}
    }
}
