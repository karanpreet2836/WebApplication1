﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OfficeEntities1 : DbContext
    {
        public OfficeEntities1()
            : base("name=OfficeEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Login> Logins { get; set; }

        public System.Data.Entity.DbSet<WebApplication1.Models.Membership> Memberships { get; set; }
    }
}