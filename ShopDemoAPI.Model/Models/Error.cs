using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Model.Models
{
    [Table("ERRORS")]
    public class ERROR
    {
        [Key]
        public int ID_ERROR { get; set; }

        public string MESSAGE { get; set; }

        public string STACKTRACE { get; set; }

        public DateTime CREATEDDATE { get; set; }
    }
}
