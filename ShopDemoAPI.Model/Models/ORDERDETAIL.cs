using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Model.Models
{
    [Table("ORDERDETAILS")]
    public class ORDERDETAIL
    {
        [Key]
        [Column(Order = 1)]
        public int ID_ORDER { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ID_PRODUCT { get; set; }

        [Required]
        public int QUANTITY { get; set; }

        [ForeignKey("ID_ORDER")]
        public virtual ORDER ORDER { get; set; }

        [ForeignKey("ID_PRODUCT")]
        public virtual PRODUCT PRODUCT { get; set; }
    }
}
