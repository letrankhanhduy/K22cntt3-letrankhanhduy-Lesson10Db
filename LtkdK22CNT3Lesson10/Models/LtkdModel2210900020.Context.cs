﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LtkdK22CNT3Lesson10.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LtkdK22CNT3Lesson10DbEntities : DbContext
    {
        public LtkdK22CNT3Lesson10DbEntities()
            : base("name=LtkdK22CNT3Lesson10DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<LtkdAccount> LtkdAccount { get; set; }
    }
}
