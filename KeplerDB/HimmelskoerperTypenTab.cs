//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeplerDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class HimmelskoerperTypenTab
    {
        public HimmelskoerperTypenTab()
        {
            this.HimmelskoerperTab = new HashSet<HimmelskoerperTab>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<HimmelskoerperTab> HimmelskoerperTab { get; set; }
    }
}
