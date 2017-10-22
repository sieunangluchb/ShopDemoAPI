using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Model.Models
{
    [Table("POSTTAGS")]
    public class POSTTAG
    {
        [Key]
        public int ID_POST { get; set; }

        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string ID_TAG { get; set; }

        [ForeignKey("ID_POST")]
        public virtual POST POST { get; set; }

        [ForeignKey("ID_TAG")]
        public virtual TAG TAG { get; set; }
    }
}
