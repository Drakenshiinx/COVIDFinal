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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CovidDeathsDBEntities : DbContext
    {
        public CovidDeathsDBEntities()
            : base("name=CovidDeathsDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<NursingHomeDeathsTable> NursingHomeDeathsTables { get; set; }
        public virtual DbSet<NursingHomeIDTable> NursingHomeIDTables { get; set; }
        public virtual DbSet<TownCTDeathsTable> TownCTDeathsTables { get; set; }
        public virtual DbSet<TownNamesIDTable> TownNamesIDTables { get; set; }
    }
}
