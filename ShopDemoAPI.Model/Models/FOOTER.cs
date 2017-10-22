using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopDemoAPI.Model.Models
{
    [Table("FOOTERS")]
    public class FOOTER
    {
        [Key]
        [MaxLength(250)]
        [Column(TypeName = "varchar")]
        public string ID_FOOTER { get; set; }

        [Required]
        public string CONTENT { get; set; }
    }
}