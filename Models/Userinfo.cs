
using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {


  
    public int Id { get; set; }

       [Required(ErrorMessage="Ad Alanı Zorunlu")]

    public string? Name { get; set; }

       [Required(ErrorMessage="Telefon Alanı Zorunlu")]
    public string? Phone { get; set; }

       [Required(ErrorMessage="Email Alanı Zorunlu")]
       [EmailAddress(ErrorMessage="Lütfen Geçerli Bir Email Adresi Giriniz!")]

    public string? Email { get; set; }
    
       [Required(ErrorMessage="Lütfen Katılım Durumunuzu Seçiniz!")]

    public bool? WillAttend { get; set; }

    }
}