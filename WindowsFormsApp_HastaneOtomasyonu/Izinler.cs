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
    
    public partial class Izinler
    {
        public int IzinID { get; set; }
        public int PersonelID { get; set; }
        public string IzınTuru { get; set; }
        public System.DateTime IzinBaslangic { get; set; }
        public System.DateTime IzinBitis { get; set; }
        public string IzinAdresi { get; set; }
    
        public virtual Personel Personel { get; set; }
    }
}
