using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Model.Models
{
    [Table("ORDERS")]
    public class ORDER
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_ORDER { get; set; }

        [MaxLength(250)]
        public string CUSTOMERNAME { get; set; }

        [MaxLength(250)]
        public string CUSTOMERADDRESS { get; set; }

        [MaxLength(250)]
        public string CUSTOMEREMAIL { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string CUSTOMERMOBILE { get; set; }

        [MaxLength(250)]
        public string CUSTOMERMESSAGE { get; set; }

        public DateTime? CREATEDDATE { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string CREATEDBY { get; set; }

        [MaxLength(250)]
        public string PAYMENTMETHOD { get; set; }

        [MaxLength(50)]
        public string PAYMENTSTATUS { get; set; }

        [Required]
        public bool STATUS { get; set; }

        public virtual IEnumerable<ORDERDETAIL> ORDERDETAILs { get; set; }
    }
}
