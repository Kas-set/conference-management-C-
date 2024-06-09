using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCoreMySQL.Models
{
    [Table("utilisateur")]

    public class Utilisateur
    {
        [Key]
        [Column("id_util")]
        public int Id_util { get; set; }

        [Required(ErrorMessage = "Le nom d'utilisateur est requis.")]
        [StringLength(100, ErrorMessage = "La longueur maximale du nom est de 100 caractères.")]
        [Column("nom_util")]
        public String Nom_util { get; set; }

        [Required(ErrorMessage = "L'email de l'utilisateur est requis.")]
        [StringLength(100, ErrorMessage = "La longueur maximale de l'email est de 100 caractères.")]
        [Column("email_util")]
        public String Email_util { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis.")]
        [StringLength(100, ErrorMessage = "La longueur maximale du mot de passe est de 100 caractères.")]
        [Column("mot_de_passe")]
        public String Mot_de_passe { get; set;  }
    }
}
