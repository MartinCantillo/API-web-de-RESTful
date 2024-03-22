using System.ComponentModel.DataAnnotations;

namespace ModelsUser.User;
public class User
{
    private int Id_User { set; get; }

    [Required]

    [EmailAddress(ErrorMessage = "Username invalido")]
    private String Username { set; get; }
    [Required]
    private String Password { set; get; }
    public User(String Username, String Password)
    {
        this.Username = Username;
        this.Password = Password;
    }
}