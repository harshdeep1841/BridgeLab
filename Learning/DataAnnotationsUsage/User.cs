using System.ComponentModel.DataAnnotations;

namespace ConsoleAppLearning1.Learning.Operator.Learning.Generic.Learning.DataAnnotationsUsage;

public class User
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Name is  required")]
    [StringLength(50 , ErrorMessage = "String must be of  50 characters or less")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Email is  required")]
    [EmailAddress(ErrorMessage = "Email is invalid")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Password is  required")]
    [MinLength(6, ErrorMessage = "Password must have at least 6 characters")]
    public string Password { get; set; }
    [Required]
    [Compare("Password" , ErrorMessage="Password doesn't match")]
    public string ConfimPassword { get; set; }
    [Phone]
    public long  PhoneNumber { get; set; }
    [RegularExpression(@"^[0-9]{6}$", ErrorMessage = "Zipcode is invalid")]
    public string ZipCode { get; set; }
    
}