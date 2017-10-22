using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopDemoAPI.Model.Models
{
    [Table("MENUGROUPS")]
    public class MENUGROUP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_MENUGROUP { get; set; }

        [Required]
        [MaxLength(250)]
        public string NAME { get; set; }

        public virtual IEnumerable<MENU> MENUs { get; set; }
    }
}