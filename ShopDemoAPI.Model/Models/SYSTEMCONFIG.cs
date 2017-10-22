using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Model.Models
{
    [Table("SYSTEMCONFIGS")]
    public class SYSTEMCONFIG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_SYSTEMCONFIG { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string CODE { get; set; }

        [MaxLength(250)]
        public string VALUESTRING { get; set; }
        
        public int? VALUEINT { get; set; }
    }
}
