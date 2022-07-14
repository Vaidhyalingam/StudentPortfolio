using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPortfolio.Models;

public class Student
{
    [Key]
    public int StudentID { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    [Required(ErrorMessage = "Please Enter Name.")]
    public string StudentName { get; set; }

    [Required(AllowEmptyStrings = true)]
    public int Age { get; set; }

    [Column(TypeName = "nvarchar(30)")]
    public string? Location { get; set; }

    public int Rank { get; set; }
}
