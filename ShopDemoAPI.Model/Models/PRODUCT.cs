using ShopDemoAPI.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShopDemoAPI.Model.Models
{
    [Table("PRODUCTS")]
    public class PRODUCT : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_PRODUCT { get; set; }

        [Required]
        [MaxLength(250)]
        public string NAME { get; set; }

        [Required]
        [MaxLength(250)]
        [Column(TypeName = "varchar")]
        public string ALIAS { get; set; }

        public int? ID_PRODUCTCATEGORY { get; set; }

        [MaxLength(500)]
        public string IMAGE { get; set; }

        [Column(TypeName = "xml")]
        public string MOREIMAGES { get; set; }
        
        public decimal PRICE { get; set; }

        public decimal? PROMOTIONPRICE { get; set; }

        public int? WARRANTY { get; set; }

        [MaxLength(500)]
        public string DESCRIPTION { get; set; }

        public string CONTENT { get; set; }
        
        public bool? HOMEFLAG { get; set; }

        public bool? HOTFLAG { get; set; }

        public int? VIEWCOUNT { get; set; }

        [ForeignKey("ID_PRODUCTCATEGORY")]
        public virtual PRODUCTCATEGORY PRODUCTCATEGORY { get; set; }

        public virtual IEnumerable<ORDERDETAIL> ORDERDETAILs { get; set; }

        public virtual IEnumerable<PRODUCTTAG> PRODUCTTAGs { get; set; }
    }
}
