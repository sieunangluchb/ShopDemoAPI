using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Model.Models
{
    [Table("SLIDES")]
    public class SLIDE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_SLIDE { get; set; }

        [Required]
        [MaxLength(50)]
        public string NAME { get; set; }

        [MaxLength(250)]
        public string DESCRIPTION { get; set; }

        [Required]
        [MaxLength(500)]
        public string IMAGE { get; set; }

        [Required]
        [MaxLength(500)]
        public string URL { get; set; }

        public int? DISPLAYORDER { get; set; }

        [Required]
        public bool STATUS { get; set; }
    }
}
