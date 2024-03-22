using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsUser.User;
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id_User { set; get; }

    [Required]

    [EmailAddress(ErrorMessage = "Username invalido")]
    String Username { set; get; }
    [Required]
    public String Password { set; get; }
    public User(String Username, String Password)
    {
        this.Username = Username;
        this.Password = Password;
    }
}