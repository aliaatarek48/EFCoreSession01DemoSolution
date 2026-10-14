using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SessionDemo.Models
{
    [Table("EmployeesTable")]
    internal class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [Column(name: "EmployeeName", TypeName = "varchar")]
        [MaxLength(50, ErrorMessage = "Name Cannot Exceed 50 Chars")] // Message Application Validation
        [MinLength(3, ErrorMessage = "Name Must be At Least 3 Char")] // Application Validations
                                                                      //[StringLength(50 , MinimumLength = 3 ,ErrorMessage = "Name Cannot Exceed 50 Chars")] // Min , Message are Application Validation
                                                                      //[Length(3 , 50)] // Application Validation
                                                                      // Application Validation Will No Mapped To database
        public string? EmpName { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        //[Precision(10 , 2)]
        public decimal Salary { get; set; }

        //[Range(22 , 40)] // Application Validation
        public int Age { get; set; }

        [Required]
        [EmailAddress] // Application Validation
        [DataType(DataType.EmailAddress)] // UI Hint To Display Value As Email Address [FrontEnd]
        public string Email { get; set; }

        [DataType(DataType.Password)] //// UI Hint To Display Value As Password [FrontEnd]
        public string? Password { get; set; }

        [Required]
        [Phone] // Application Validation
        [DataType(DataType.PhoneNumber)]// UI Hint To Display Value As Phone Number [FrontEnd]
        public string PhoneNumber { get; set; }

        [NotMapped]
        public string UserName => Email.Split('@')[0];
    }
}
