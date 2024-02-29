
using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models;

public class UserInfo
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Ad alanı zorunludur.")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "E-posta alanı zorunludur.")]
    [EmailAddress(ErrorMessage = "Geçersiz bir e-posta adresi girildi.")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Telefon alanı zorunludur.")]
    public string? Phone { get; set; }

    [Required(ErrorMessage = "Katılım durumu seçimi zorunludur.")]
    public bool WillAttend { get; set; } // true, false, null
}