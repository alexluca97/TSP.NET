﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectCarService
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CarServiceModelContainer : DbContext
    {
        public CarServiceModelContainer()
            : base("name=CarServiceModelContainer")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Auto> Autos { get; set; }
        public virtual DbSet<Sasiu> Sasius { get; set; }
        public virtual DbSet<Mecanic> Mecanics { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Imagine> Imagines { get; set; }
        public virtual DbSet<DetaliuComanda> DetaliuComandas { get; set; }
        public virtual DbSet<Operatie> Operations { get; set; }
        public virtual DbSet<Comanda> Comands { get; set; }
    }
}
