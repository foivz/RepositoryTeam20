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
    
    public partial class tipzaposlenika
    {
        public tipzaposlenika()
        {
            this.zaposlenik = new HashSet<zaposlenik>();
        }
    
        public int tipZaposlenikaID { get; set; }
        public string naziv { get; set; }
    
        public virtual ICollection<zaposlenik> zaposlenik { get; set; }
    }
}
