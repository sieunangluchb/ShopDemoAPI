using System;

namespace ShopDemoAPI.Model.Abstract
{
    public interface IAuditable
    {
        string METAKEYWORD { get; set; }

        string METADESCRIPTION { get; set; }

        DateTime? CREATEDDAY { get; set; }

        string CREATEDBY { get; set; }

        DateTime? UPDATEDDATE { get; set; }

        string UPDATEDBY { get; set; }

        bool STATUS { get; set; }
    }
}