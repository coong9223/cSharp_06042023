﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyAngile
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuanliAngileEntities : DbContext
    {
        public QuanliAngileEntities()
            : base("name=QuanliAngileEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Nhanvien> Nhanviens { get; set; }
    
        public virtual ObjectResult<TimKiemNV_Result> TimKiemNV(string masp)
        {
            var maspParameter = masp != null ?
                new ObjectParameter("masp", masp) :
                new ObjectParameter("masp", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<TimKiemNV_Result>("TimKiemNV", maspParameter);
        }
    }
}
