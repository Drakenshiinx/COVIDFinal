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
    
    public partial class TownCTDeathsTable
    {
        public int DeathID { get; set; }
        public System.DateTime Date { get; set; }
        public string TownName { get; set; }
        public int TownID { get; set; }
        public int TotalCases { get; set; }
        public int ConfirmedCases { get; set; }
        public int ProbableCases { get; set; }
        public int TotalDeaths { get; set; }
        public int ConfirmedCOVIDDeaths { get; set; }
        public int ProbableDeaths { get; set; }
        public int PeopleTested { get; set; }
        public int NumOfTest { get; set; }
        public int TestPositive { get; set; }
        public int TestNegative { get; set; }
        public int TestUnknown { get; set; }
    
        public virtual TownNamesIDTable TownNamesIDTable { get; set; }
    }
}
