//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _420Final
{
    using System;
    using System.Collections.Generic;
    
    public partial class TownNamesIDTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TownNamesIDTable()
        {
            this.TownCTDeathsTables = new HashSet<TownCTDeathsTable>();
        }
    
        public int TownID { get; set; }
        public string TownName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TownCTDeathsTable> TownCTDeathsTables { get; set; }
    }
}
