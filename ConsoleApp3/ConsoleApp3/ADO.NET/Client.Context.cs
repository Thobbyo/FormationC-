﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp3.ADO.NET
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class exerciceLocationEntities : DbContext
    {
        public exerciceLocationEntities()
            : base("name=exerciceLocationEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CATEGORIE> CATEGORIE { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<LOUE> LOUE { get; set; }
        public virtual DbSet<Marque> Marque { get; set; }
        public virtual DbSet<VEHICULE> VEHICULE { get; set; }
    }
}
