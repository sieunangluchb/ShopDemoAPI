using ShopDemoAPI.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Model.Models
{
    [Table("POSTCATEGORIES")]
    public class POSTCATEGORY : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_POSTCATEGORY { get; set; }

        [Required]
        [MaxLength(250)]
        public string NAME { get; set; }

        [Required]
        [MaxLength(250)]
        [Column(TypeName = "varchar")]
        public string ALIAS { get; set; }

        [MaxLength(500)]
        public string DESCRIPTION { get; set; }

        public int? PARENT_ID { get; set; }

        public int? DISPLAYORDER { get; set; }

        [MaxLength(500)]
        public string IMAGE { get; set; }
        
        public bool? HOMEFLAG { get; set; }

        public virtual IEnumerable<POST> POSTs { get; set; }
    }
}
