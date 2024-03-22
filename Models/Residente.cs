using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ModelsUser.User;

namespace ModelResidente.Residente;

public class Residente
{
    public Residente(String Nombre_residente, String Num_apartamento, User usuario, String Num_telefono)
    {
        this.Nombre_residente = Nombre_residente;
        this.Num_apartamento = Num_apartamento;
        this.usuario = usuario;
        this.Num_telefono = Num_telefono;
    }

    [Key] //primarykey
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//autoincrementable
    public int Id_residente { set; get; }
    [Required]
    public required String Nombre_residente { set; get; }
    [Required]
    public String Num_apartamento { get; set; }

    public String Num_telefono { get; set; }

    [ForeignKey("Id_User")]
    public required User usuario { set; get; }



}