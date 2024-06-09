using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCoreMySQL.Models
{
    [Table("conference")]
    public class Conference
    {

        [Key]
        [Column("idConf")]
        public int IdConf { get; set; }

        [Required(ErrorMessage = "Le theme de la conference est requis.")]
        [StringLength(100, ErrorMessage = "La longueur maximale du theme est de 100 caractères.")]
        [Column("themeConf")]
        public string themeConf { get; set; }
        [Column("interSoumStart")]
        public DateTime interSoumStart { get; set; }

        [Column("interSoumEnd")]
        public DateTime interSoumEnd { get; set; }

        [Column("interResulStart")]
        public DateTime interResulStart { get; set; }

        [Column("interResulEnd")]
        public DateTime interResulEnd { get; set; }

        [Column("interinscStart")]
        public DateTime interinscStart { get; set; }

        [Column("interinscEnd")]
        public DateTime interinscEnd { get; set; }

        [Column("Articles")]
        public List<Article>? Articles { get; set; }

        [Column("Date")]
        public DateTime Date { get; set; }
       
    }
}
