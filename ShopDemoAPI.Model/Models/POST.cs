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
    [Table("POSTS")]
    public class POST : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_POST { get; set; }

        [Required]
        [MaxLength(250)]
        public string NAME { get; set; }

        [Required]
        [MaxLength(250)]
        [Column(TypeName = "varchar")]
        public string ALIAS { get; set; }

        public int? ID_POSTCATEGORY { get; set; }

        [MaxLength(500)]
        public string IMAGE { get; set; }

        [MaxLength(500)]
        public string DESCRIPTION { get; set; }

        public string CONTENT { get; set; }
        
        public bool? HOMEFLAG { get; set; }

        public bool? HOTFLAG { get; set; }
        
        public int? VIEWCOUNT { get; set; }

        [ForeignKey("ID_POSTCATEGORY")]
        public virtual POSTCATEGORY POSTCATEGORY { get; set; }

        public virtual IEnumerable<POSTTAG> POSTTAGs { get; set; }
    }
}
