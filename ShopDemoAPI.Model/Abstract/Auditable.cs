using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopDemoAPI.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        [MaxLength(250)]
        public string METAKEYWORD { get; set; }

        [MaxLength(250)]
        public string METADESCRIPTION { get; set; }

        public DateTime? CREATEDDAY { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string CREATEDBY { get; set; }

        public DateTime? UPDATEDDATE { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string UPDATEDBY { get; set; }

        public bool STATUS { get; set; }
    }
}