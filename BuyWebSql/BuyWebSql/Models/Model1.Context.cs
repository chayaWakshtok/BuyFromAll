﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuyWebSql.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class buyfromallEntities : DbContext
    {
        public buyfromallEntities()
            : base("name=buyfromallEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<city> cities { get; set; }
        public virtual DbSet<Feature> Features { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<payment> payments { get; set; }
        public virtual DbSet<search> searches { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<brand> brands { get; set; }
        public virtual DbSet<collaborationData> collaborationDatas { get; set; }
        public virtual DbSet<image> images { get; set; }
        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<order_items> order_items { get; set; }
        public virtual DbSet<site> sites { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User_Comment> User_Comment { get; set; }
    }
}
