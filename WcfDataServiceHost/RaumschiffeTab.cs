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
    
    public partial class RaumschiffeTab
    {
        public System.DateTime Start_der_Mission { get; set; }
        public int ID { get; set; }
        public int Himmelskoerper_ID { get; set; }
        public int Land_ID { get; set; }
        public int RaumschiffAufgaben_ID { get; set; }
    
        public virtual HimmelskoerperTab HimmelskoerperTab { get; set; }
        public virtual LaenderTab LaenderTab { get; set; }
        public virtual RaumschiffAufgabenTab RaumschiffAufgabenTab { get; set; }
    }
}
