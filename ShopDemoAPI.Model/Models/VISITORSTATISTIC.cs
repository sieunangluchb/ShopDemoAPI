using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Model.Models
{
    [Table("VISITORSTATISTICS")]
    public class VISITORSTATISTIC
    {
        [Key]
        public Guid ID_VISITORSTATISTIC { get; set; }

        [Required]
        public DateTime VISITEDDATE { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string IPADDRESS { get; set; }
    }
}
