using System.ComponentModel.DataAnnotations;

namespace PharmaSafeChain.Models.UserManagementModels
{
    public class User_Information_Model
    {
        public int User_id {  get; set; }   
        public string? UserName { get; set;}
        public string? FirstName { get; set;}
        public string? LastName { get; set;}
        public string? Email { get; set;}

        [RegularExpression(@"^\+?[0-9\- ]+$", ErrorMessage = "Please enter a valid phone number.")]
        public string? PhoneNumber { get; set;}
    }
}
