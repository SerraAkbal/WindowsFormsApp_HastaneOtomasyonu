//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp_HastaneOtomasyonu
{
    using System;
    using System.Collections.Generic;
    
    public partial class RandevuDetay
    {
        public int RandevuID { get; set; }
        public Nullable<System.DateTime> RandevuTarihi { get; set; }
        public Nullable<System.TimeSpan> RandevuSaati { get; set; }
        public string HastaGeldimi { get; set; }
        public Nullable<System.DateTime> YeniRandevuTarihi { get; set; }
    
        public virtual Randevu Randevu { get; set; }
    }
}
