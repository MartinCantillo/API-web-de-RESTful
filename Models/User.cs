using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUser.User
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_User { set; get; }

        [Required]
        [EmailAddress(ErrorMessage = "Username invalido")]
        public string Username { set; get; }

        [Required]
        public string Password { set; get; }

        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }
    }
}
