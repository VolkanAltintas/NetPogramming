﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentsExam
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbStudentRegisterEntities : DbContext
    {
        public dbStudentRegisterEntities()
            : base("name=dbStudentRegisterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblLesson> tblLessons { get; set; }
        public virtual DbSet<tblNote> tblNotes { get; set; }
        public virtual DbSet<tblStudent> tblStudents { get; set; }
    
        public virtual ObjectResult<NOTLIST_Result> NOTLIST()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NOTLIST_Result>("NOTLIST");
        }
    }
}
