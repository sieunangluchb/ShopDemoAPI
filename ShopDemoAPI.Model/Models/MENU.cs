using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Model.Models
{
    [Table("MENUS")]
    public class MENU
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_MENU { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string NAME { get; set; }

        [Required]
        [MaxLength(500)]
        public string URL { get; set; }

        public int? DISPLAYORDER { get; set; }

        [Required]
        public int ID_MENUGROUP { get; set; }

        [MaxLength(10)]
        [Column(TypeName = "varchar")]
        public string TARGET { get; set; }

        [Required]
        public bool STATUS { get; set; }

        [ForeignKey("ID_MENUGROUP")]
        public virtual MENUGROUP MENUGROUP { get; set; }
    }
}
