using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Model.Models
{
    [Table("PAGES")]
    public class PAGE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_PAGE { get; set; }

        [MaxLength(250)]
        public string NAME { get; set; }

        public string CONTENT { get; set; }
        
        [MaxLength(250)]
        public string METAKEYWORD { get; set; }

        [MaxLength(250)]
        public string METADESCRIPTION { get; set; }
        
        [Required]
        public bool STATUS { get; set; }
    }
}
