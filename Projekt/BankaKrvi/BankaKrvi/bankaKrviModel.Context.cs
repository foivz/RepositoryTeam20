﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bankakrviEntities : DbContext
    {
        public bankakrviEntities()
            : base("name=bankakrviEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<bolest> bolest { get; set; }
        public DbSet<donacija> donacija { get; set; }
        public DbSet<hladnjak> hladnjak { get; set; }
        public DbSet<krvnagrupa> krvnagrupa { get; set; }
        public DbSet<pacijent> pacijent { get; set; }
        public DbSet<spol> spol { get; set; }
        public DbSet<test> test { get; set; }
        public DbSet<tippacijenta> tippacijenta { get; set; }
        public DbSet<tipptreakcije> tipptreakcije { get; set; }
        public DbSet<tipzaposlenika> tipzaposlenika { get; set; }
        public DbSet<transfuzija> transfuzija { get; set; }
        public DbSet<ustanova> ustanova { get; set; }
        public DbSet<zaposlenik> zaposlenik { get; set; }
    }
}
