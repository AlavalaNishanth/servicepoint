﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SafteyServicePointMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SafetyDBEntities : DbContext
    {
        public SafetyDBEntities()
            : base("name=SafetyDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AdminTbl> AdminTbls { get; set; }
        public DbSet<TblContact> TblContacts { get; set; }
        public DbSet<TblUser> TblUsers { get; set; }
    }
}
