using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Model.Models
{
    [Table("TAGS")]
    public class TAG
    {
        [Key]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string ID_TAG { get; set; }

        [MaxLength(50)]
        public string NAME { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string TYPE { get; set; }

        public virtual IEnumerable<POSTTAG> POSTTAGs { get; set; }

        public virtual IEnumerable<PRODUCTTAG> PRODUCTTAGs { get; set; }
    }
}
