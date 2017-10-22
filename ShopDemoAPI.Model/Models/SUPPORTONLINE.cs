using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Model.Models
{
    [Table("SUPPORTONLINES")]
    public class SUPPORTONLINE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_SUPPORTONLINE { get; set; }

        [MaxLength(250)]
        public string NAME { get; set; }

        [MaxLength(250)]
        public string DEPARTMENT { get; set; }

        [MaxLength(250)]
        public string SKYPE { get; set; }

        [MaxLength(250)]
        public string MOBILE { get; set; }

        [MaxLength(250)]
        public string EMAIL { get; set; }

        [MaxLength(250)]
        public string YAHOO { get; set; }

        [MaxLength(250)]
        public string FACEBOOK { get; set; }

        [Required]
        public bool STATUS { get; set; }
    }
}
