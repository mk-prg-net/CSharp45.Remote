//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfDataServiceHost
{
    using System;
    using System.Collections.Generic;
    
    public partial class UmlaufbahnenTab
    {
        public double Laenge_grosse_Halbachse_in_km { get; set; }
        public double Exzentritzitaet { get; set; }
        public double Umlaufdauer_in_Tagen { get; set; }
        public double Mittlere_Umlaufgeschwindigkeit_in_km_pro_sec { get; set; }
        public int ID { get; set; }
        public int Trabant_ID { get; set; }
        public int Zentralobjekt_ID { get; set; }
    
        public virtual HimmelskoerperTab HimmelskoerperTab { get; set; }
        public virtual HimmelskoerperTab HimmelskoerperTab1 { get; set; }
    }
}
