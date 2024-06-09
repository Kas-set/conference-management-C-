using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCoreMySQL.Models
{
    [Table("article")]
    public class Article
    {
        [Key]
        [Column("id_article")]
        public int IdArticle { get; set; }

        [Required(ErrorMessage = "Le nom de l'article est requis.")]
        [StringLength(100, ErrorMessage = "La longueur maximale du nom de l'article est de 100 caractères.")]
        [Column("titre_article")]
        public string titreArticle { get; set; }

        [Required(ErrorMessage = "La description de l'article  est requis.")]
        [StringLength(250, ErrorMessage = "La longueur maximale de la description est de 250 caractères.")]
        [Column("descArticle")]
        public string descArticle { get; set; }

        [Required(ErrorMessage = "Le statut de l'article est requis.")]
        [StringLength(90, ErrorMessage = "La longueur maximale du statut est de 90 caractères.")]
        [Column("statut")]
        public string statutArt { get; set; }

        [Required(ErrorMessage = "Le pdf est requis.")]
        [Column("pdfContenu")]
        public byte[] pdfContenu { get; set; }

        [Required(ErrorMessage = "Le nom du pdf de l'article est requis.")]
        [StringLength(100, ErrorMessage = "La longueur maximale du nom du pdf  est de 100 caractères.")]
        [Column("pdfName")]
        public string pdfName { get; set; }

        [Column("ConferenceId")]

        public int ConferenceId { get; set; }

        [Column("Conference")]
        public Conference Conference { get; set; }
    }
}
