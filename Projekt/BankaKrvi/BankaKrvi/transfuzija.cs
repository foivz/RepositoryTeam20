//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankaKrvi
{
    using System;
    using System.Collections.Generic;
    
    public partial class transfuzija
    {
        public transfuzija()
        {
            this.donacija = new HashSet<donacija>();
            this.tipptreakcije = new HashSet<tipptreakcije>();
        }
    
        public int transfuzijaID { get; set; }
        public string povjest_bolesti { get; set; }
        public Nullable<int> kolicina { get; set; }
        public Nullable<System.DateTime> datum { get; set; }
        public int transfuzija_pacijentID { get; set; }
        public int transfuzija_ustanovaID { get; set; }
    
        public virtual pacijent pacijent { get; set; }
        public virtual ustanova ustanova { get; set; }
        public virtual ICollection<donacija> donacija { get; set; }
        public virtual ICollection<tipptreakcije> tipptreakcije { get; set; }
    }
}
