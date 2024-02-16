using System.ComponentModel.DataAnnotations;

namespace BootcampForm.Models;

public class Candidate
{
    [Required(ErrorMessage = "E mail alanı zorunludur ")]
    public String? Email { get; set; } = String.Empty;
    
    [Required(ErrorMessage = "First Name alanı zorunludur ")]
    public String? FirstName { get; set; } = String.Empty;
    
    [Required(ErrorMessage = "Last Name alanı zorunludur ")]
    public String? LastName { get; set; } = String.Empty;
    
    public String? Fullname => $"{FirstName} {LastName?.ToUpper()}";
    public int? Age { get; set; }
    
    [Required(ErrorMessage = "Kurs seçim alanı zorunludur ")]
    public String? SelectedCourse { get; set; } = String.Empty;
    public DateTime ApplyAt { get; set; }

    public Candidate()
    {
        ApplyAt = DateTime.Now;
    }
}