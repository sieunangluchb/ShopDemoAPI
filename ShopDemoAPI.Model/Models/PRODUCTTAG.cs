using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Model.Models
{
    [Table("PRODUCTTAGS")]
    public class PRODUCTTAG
    {
        [Key]
        public int ID_PRODUCT { get; set; }

        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string ID_TAG { get; set; }

        [ForeignKey("ID_PRODUCT")]
        public virtual PRODUCT PRODUCT { get; set; }
        
        [ForeignKey("ID_TAG")]
        public virtual TAG TAGs { get; set; }
    }
}
